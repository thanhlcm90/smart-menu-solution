/*
 * UART.c
 *
 * Created: 11/3/2012 10:47:38 PM
 *  Author: Minh Thanh
 */ 
#include "UART.h"
#include "lcd.h"
unsigned char* u_Data;

void UART_Init( unsigned int ubrr )
{
	/* Set baud rate */
	UBRR1H = (unsigned char)(ubrr>>8);
	UBRR1L = (unsigned char)ubrr;
	/* Enable receiver, transmitter and interrup when receive finish */
	UCSR1B = (1<<RXEN1)|(1<<TXEN1)|(1<<RXCIE1);
	/* Set frame format: 8data, 1stop bit */
	UCSR1C = (1<<UCSZ10)|(1<<UCSZ11);
	sei();
}

void uart_putc(unsigned char chr) {
	/* Wait for empty transmit buffer */
	while ( !( UCSR1A & (1<<UDRE1)) );
	/* Put data into buffer, sends the data */
	UDR1 = chr;
}

void uart_puts(const char* s){
	while(*s != '\0'){
		uart_putc(*s);
		s++;
	}
	uart_putc('\0');
}
unsigned char rc[32];
int rc_count=0;
void uart_getc(SMR* handle,unsigned char chr) {
	if (chr!='\0') {
		rc[rc_count]=chr;
		rc_count++;
	} else {
		rc[rc_count]='\0';
		sMRIfaceRF_set_data(handle,rc);
		rc_count=0;
	}
}