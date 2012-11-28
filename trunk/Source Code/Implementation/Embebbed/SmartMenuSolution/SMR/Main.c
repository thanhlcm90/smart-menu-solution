/*
 * Main.c
 *
 * Created: 11/18/2012 2:11:27 PM
 *  Author: Minh Thanh
 */ 
#define F_CPU 8000000UL

#include <avr/io.h>
#include <stdlib.h>
#include <util/delay.h>
#include <avr/interrupt.h>
#include "SMR.h"
#include "lcd.h"
#include "TimerEvent.h"
#include "UART.h"
#include "rf.h"
#include "keypad.h"

//send button
#define BUTTONSEND_DDR DDRC
#define BUTTONSEND_PORT PORTC
#define BUTTONSEND_PIN PINC
#define BUTTONSEND PORTC0
//output led
#define LEDOUT_DDR DDRC
#define LEDOUT_PORT PORTC
#define LEDOUT PORTC1
#define LEDOUTPAUSE 300

struct SMR* l;
char bufferin[NRF24L01_PAYLOAD];
char bufferout[NRF24L01_PAYLOAD];

static uint8_t nrf24l01_addr5[NRF24L01_ADDRSIZE] = NRF24L01_ADDRP5;
static uint8_t nrf24l01_addrtx[NRF24L01_ADDRSIZE] = NRF24L01_ADDRTX;

sc_integer sMRIfaceKEYPAD_checkpress() {
	return KEYPAD_Check();
}
void sMRIfaceKEYPAD_init() {
	KEYPAD_Init();
}

void sMRIfaceLCD_writeString(const sc_string chr) {
	LCDWriteString(chr);
}
void sMRIfaceLCD_writeStringXY(const sc_string chr, const sc_integer x, const sc_integer y) {
	LCDWriteStringXY(x,y,chr);
}
void sMRIfaceLCD_writeNumberXY(const sc_integer num, const sc_integer x, const sc_integer y, const sc_integer l) {
	LCDWriteIntXY(x,y,num,l);
}
void sMRIfaceLCD_clear() {
	LCDClear();
}
void sMRIfaceLCD_init() {
	LCDInit(0);
}

sc_string sMRIfaceRF_getData() {
	uint8_t pipe = 0;
	if (nrf24l01_readready(&pipe)) {
		LCDWriteIntXY(0,1,pipe,1);
		if (pipe==0) {
			//clear buffer
			for(uint8_t i=0; i<NRF24L01_PAYLOAD; i++) bufferin[i] = 0;
			
			//read buffer
			nrf24l01_read(pipe,bufferin);
			return bufferin;
		}
	}
	return "";
}

sc_boolean sMRIfaceRF_sendMsg(const sc_string msg) {
	//clear buffer
	for(uint8_t i=0; i<NRF24L01_PAYLOAD; i++) {
		if (i<strlen(msg)) bufferout[i]=msg[i];
		else bufferout[i] = 0;
	}
	
	//Set Address for Data
	nrf24l01_settxaddr(nrf24l01_addrtx);
	
	uint8_t writeret = nrf24l01_write(bufferout);
	_delay_ms(1);
	
	if(writeret == 1) {
		return true;
	} else {
		return false;
	}
}

sc_boolean sMRIfaceRF_sendCheck() {
	//set all buffer
	for(uint8_t i=0; i<NRF24L01_PAYLOAD; i++) bufferout[i] = 1;
	//Set Address for check
	nrf24l01_settxaddr(nrf24l01_addr5);
	
	uint8_t writeret = nrf24l01_write(bufferout);
	_delay_ms(1);
	
	if(writeret == 1) {
		return true;
	} else {
		return false;
	}
}

sc_boolean sMRIfaceRF_getCheck() {
	uint8_t pipe = 0;
	if (nrf24l01_readready(&pipe)) {
		if (pipe==5) {
			//clear buffer
			for(uint8_t i=0; i<NRF24L01_PAYLOAD; i++) bufferin[i] = 0;
			
			//read buffer
			nrf24l01_read(pipe,bufferin);
			
			for(uint8_t i=0; i<NRF24L01_PAYLOAD; i++) if (bufferin[i]!=1) return false;
			return true;
		}
	}
	return false;
}

sc_boolean sMRIfaceRF_sendData(const sc_integer cmd, const sc_integer id, const sc_integer dish_id, const sc_integer amount) {
	
	unsigned char num;
	unsigned char mod;
	//clear buffer
	for(uint8_t i=0; i<sizeof(bufferout); i++) bufferout[i] = 0;
	
	//Lenh cho data: 1-goi mon, 2-huy mon, 3-thanh toan, 4-goi boi ban
	bufferout[0]=cmd+'0'; //Doi cmd tu so sang chu so
	
	//Chuyen doi ma ban an hoac nha bep
	num=id;
	for (int i=1;i>=0;i--) {
		mod=num % 10;
		num/=10;
		bufferout[i+1]=mod+'0';
	}
	
	//Chuyen doi ma mon an
	num=dish_id;
	for (int i=2;i>=0;i--) {
		mod=num % 10;
		num/=10;
		bufferout[3+i]=mod+'0';
	}
	
	//Chuyen doi so luong mon an
	num=amount;
	for (int i=1;i>=0;i--) {
		mod=num % 10;
		num/=10;
		bufferout[6+i]=mod+'0';
	}
	
	//Set Address for Data
	nrf24l01_settxaddr(nrf24l01_addrtx);
	
	uint8_t writeret = nrf24l01_write(bufferout);
	_delay_ms(1);
	
	if(writeret == 1) {
		return true;
	} else {
		return false;
	}
}

void sMRIfaceUART_init() {
	UART_Init(MYUBRR);
}

void sMRIfaceUART_sendData(const sc_string msg) {
	msg[sizeof(msg)-1]=0;
	uart_puts(msg);
}

void sMR_setTimer(const sc_eventid evid, const sc_integer time_ms, const sc_boolean periodic){
	TimerSet(evid,time_ms);
}
void sMR_unsetTimer(const sc_eventid evid) {
	TimerUnSet(evid);
}

void sMRIfaceRF_init() {
	nrf24l01_init();
}

char temp[9];

void sMRIface_convertNumber(const sc_integer num, const sc_integer pos) {
	temp[pos-1]=num+'0';
}

void sMRIfaceUART_sendTemp() {
	temp[sizeof(temp)-1]='\0';
	LCDWriteStringXY(0,1,temp);
	uart_puts(temp);
}


int main(void)
{
	uint8_t i;
	DDRC=0x0F;
	PORTC=0x0F;
	l=malloc(sizeof(SMR*)) ;
	TimerInit();
	sMR_init(l);
	sMR_enter(l);
	
	//setup buffer
	for(i=0; i<sizeof(bufferout); i++)
	bufferout[i] = i+'a';
	for(i=0; i<sizeof(bufferin); i++)
	bufferin[i] = 0;
	
	uint8_t down=0;
	
	while(1)
	{
		sMR_runCycle(l);
	}
}

ISR (TIMER0_OVF_vect) {
	TCNT0=131;
	TimerCheck(l);
}


ISR (USART1__RX_vect) {
	uart_getc(l,UDR1);
}