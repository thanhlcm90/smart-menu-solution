/*
 * keypad.h
 *
 * Created: 10/28/2012 10:32:49 PM
 *  Author: Minh Thanh
 */ 
#include <avr/io.h>
#include <util/delay.h>

#define KEYPAD_DDR PORTF
#define KEYPAD_PORT PORTF
#define KEYPAD_PIN PINF

#ifndef KEYPAD_H_
#define KEYPAD_H_

uint8_t KEYPAD_Check();
void KEYPAD_Init();



#endif /* KEYPAD_H_ */