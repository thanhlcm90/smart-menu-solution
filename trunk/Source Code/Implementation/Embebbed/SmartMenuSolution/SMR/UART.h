/*
 * UART.h
 *
 * Created: 11/3/2012 6:54:48 PM
 *  Author: Minh Thanh
 */ 
#include <avr/io.h>
#include <stdlib.h>
#include <util/delay.h>
#include <avr/interrupt.h>
#include "SMR.h"

#ifndef UART_H_
#define UART_H_

#define FOSC 8000000// Clock Speed
#define BAUD 9600
#define MYUBRR FOSC/16/BAUD-1

void UART_Init( unsigned int ubrr );
void uart_putc(unsigned char chr);
void uart_puts(const char* s);
void uart_getc(SMR* handle,unsigned char chr);


#endif /* UART_H_ */