/*
* keypad.c
*
* Created: 10/28/2012 10:21:17 PM
*  Author: Minh Thanh
*/
#include <avr/io.h>
#include <util/delay.h>
#include "keypad.h"

#define KEYPAD_DDR DDRF
#define KEYPAD_PORT PORTF
#define KEYPAD_PIN PINF

uint8_t scan_code[4]={0x0E,0x0D,0x0B,0x07};
//uint8_t ascii_code[4][4]={7,8,9,13,
						  //4,5,6,14,
						  //1,2,3,15,
						  //11,10,12,16};
//uint8_t ascii_code[4][4]={1,2,3,13,
//4,5,6,14,
//7,8,9,15,
						  //11,10,12,16};
uint8_t ascii_code[4][4]={16,15,14,13,
							12,9,6,3,
							10,8,5,2,
						  11,7,4,1};

uint8_t KEYPAD_Check() {
	uint8_t i,j,keyin;
	for (i=0;i<4;i++) {
		KEYPAD_PORT=0xFF-(1<<(i+4));
		_delay_us(10);
		keyin=KEYPAD_PIN & 0x0F;
		if (keyin!=0x0F)
			for (j=0;j<4;j++)
				if (keyin==scan_code[j]) return ascii_code[j][i];					
	}
	return 0;
}

void KEYPAD_Init()
{
	//Khai bao huong cho cac chan ket noi keypad
	KEYPAD_DDR=0xF0;
	KEYPAD_PORT=0x0F;
}