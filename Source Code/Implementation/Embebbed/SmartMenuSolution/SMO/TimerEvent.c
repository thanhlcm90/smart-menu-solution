/*
* TimerEvent.c
*
* Created: 11/3/2012 6:45:04 PM
*  Author: Minh Thanh
*/


#include "TimerEvent.h"

TimeEvent tmrEvent[10];
int tmrCount=0;

void TimerInit() {
	TCCR0 = 0b011; //CS02=0, CS01=1, CS00=0, chon Prescaler=64
	//Xung chip la 8MHZ -> 1 xung mat 1us/8 = 0.125 us
	//Prescaler=64, kich 256 lan moi tang 1 lan trong bo dem Timer-> Ton 8us
	//Vay, de Timer ngat moi 1ms, ta can: 1000/8=125 lan dem.
	//Ma Timer ngat khi bo dem toi 255, ta can set gia tri ban dau cho bo dem la: 255-125+1=131
	TCNT0=131;
	TIMSK=(1<<TOIE0); //Cho phep ngat khi cho tran o T/C0
	tmrCount=0;
	sei();
}

//Ham them Timer cho 1 su kien
void TimerSet(const sc_eventid evenId,const sc_integer max) {
	bool check=false;
	for (int i=0;i<tmrCount;i++) {
		if (tmrEvent[i].EventId==evenId) {
			check=true;
			tmrEvent[i].count=0;
			tmrEvent[i].max=max;
			tmrEvent[i].enabled=true;
		}
	}
	if (!check) {
		tmrEvent[tmrCount].EventId=evenId;
		tmrEvent[tmrCount].count=0;
		tmrEvent[tmrCount].max=max;
		tmrEvent[tmrCount].enabled=true;
		tmrCount++;
	}
}

void TimerUnSet(const sc_eventid evenId) {
	for (int i=0;i<tmrCount;i++) {
		if (tmrEvent[i].EventId==evenId) {
			tmrEvent[i].count=0;
			tmrEvent[i].enabled=false;
			return;
		}
	}
}

void TimerCheck(SMO* handle) {
	for (int i=0;i<tmrCount;i++) {
		if (tmrEvent[i].enabled) {
			tmrEvent[i].count++;
			if (tmrEvent[i].count==tmrEvent[i].max) {
				tmrEvent[i].count=0;
				tmrEvent[i].enabled=false;
				sMO_raiseTimeEvent(handle,tmrEvent[i].EventId);
			}
		}
	}
}

void TimerClear() {
	free(tmrEvent);
	tmrCount=0;
}