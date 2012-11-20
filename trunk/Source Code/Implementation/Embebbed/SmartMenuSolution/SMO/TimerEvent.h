/*
 * TimerEvent.h
 *
 * Created: 11/3/2012 6:46:33 PM
 *  Author: Minh Thanh
 */ 
#include <avr/io.h>
#include <stdlib.h>
#include <util/delay.h>
#include <avr/interrupt.h>
#include "sc_types.h"
#include "SMO.h"

#ifndef TIMEREVENT_H_
#define TIMEREVENT_H_

typedef struct {
	sc_eventid EventId;
	int count;
	int max;
	bool enabled;
} TimeEvent;

void TimerInit();
void TimerSet(const sc_eventid evenId,const sc_integer max);
void TimerUnSet(const sc_eventid evenId);
void TimerClear();
void TimerCheck(SMO* handle);

#endif /* TIMEREVENT_H_ */