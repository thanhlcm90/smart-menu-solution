/*
* spi.h
*
* Created: 11/17/2012 4:40:43 PM
*  Author: Minh Thanh
*/


#ifndef _SPI_H_
#define _SPI_H_

#include <avr/io.h>

//spi ports
#define SPI_DDR DDRB
#define SPI_PORT PORTB
#define SPI_MISO PORTB3
#define SPI_MOSI PORTB2
#define SPI_SCK PORTB1
#define SPI_SS PORTB0

extern void spi_init();
extern uint8_t spi_writereadbyte(uint8_t data);

#endif
