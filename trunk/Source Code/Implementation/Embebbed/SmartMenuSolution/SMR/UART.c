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
	UBRR0H = (unsigned char)(ubrr>>8);
	UBRR0L = (unsigned char)ubrr;
	/* Enable receiver, transmitter and interrup when receive finish */
	UCSR0B = (1<<RXEN0)|(1<<TXEN0);//|(1<<RXCIE0);
	/* Set frame format: 8data, 1stop bit */
	UCSR0C = (1<<UCSZ00)|(1<<UCSZ01);
	//sei();
}

void uart_putc(unsigned char chr) {
	/* Wait for empty transmit buffer */
	while ( !( UCSR0A & (1<<UDRE0)) );
	/* Put data into buffer, sends the data */
	UDR0 = chr;
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
unsigned char* uart_gets() {
	unsigned chr;
	rc_count=0;
	do {
		while ( !(UCSR0A & (1<<RXC0)) )
		chr=UDR0;
		rc[rc_count]=chr;
		rc_count++;
		
	} while (chr!='\0' && rc_count<32);
	return rc;
}