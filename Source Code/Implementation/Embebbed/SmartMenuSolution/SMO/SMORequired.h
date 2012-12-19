#ifndef SMOREQUIRED_H_
#define SMOREQUIRED_H_

#include "sc_types.h"

#ifdef __cplusplus
extern "C" {
#endif 



/*! \file This header defines prototypes for all functions that are required by the state machine implementation.

This is a state machine uses time events which require access to a timing service. Thus the function prototypes:
	- sMO_setTimer and
	- sMO_unsetTimer
are defined.

This state machine makes use of operations declared in the state machines interface or internal scopes. Thus the function prototypes:
	- sMOIfaceLCD_clear
	- sMOIfaceLCD_writeString
	- sMOIfaceLCD_writeStringXY
	- sMOIfaceLCD_writeNumberXY
	- sMOIfaceLCD_init
	- sMOIfaceKEYPAD_checkpress
	- sMOIfaceKEYPAD_init
	- sMOIfaceUART_init
	- sMOIfaceUART_sendData
	- sMOIfaceRF_init
	- sMOIfaceRF_sendData
	- sMOIfaceRF_sendConf
	- sMOIfaceRF_sendMsg
	- sMOIfaceRF_getData
are defined.
		
These functions will be called during a 'run to completion step' (runCycle) of the statechart. 
There are some constraints that have to be considered for the implementation of these functions:
	- never call the statechart API functions from within these functions.
	- make sure that the execution time is as short as possible.
 
*/

extern void sMOIfaceLCD_clear();
extern void sMOIfaceLCD_writeString(const sc_string chr);
extern void sMOIfaceLCD_writeStringXY(const sc_string chr, const sc_integer x, const sc_integer y);
extern void sMOIfaceLCD_writeNumberXY(const sc_integer num, const sc_integer x, const sc_integer y, const sc_integer l);
extern void sMOIfaceLCD_init();

extern sc_integer sMOIfaceKEYPAD_checkpress();
extern void sMOIfaceKEYPAD_init();

extern void sMOIfaceUART_init();
extern void sMOIfaceUART_sendData(const sc_integer cmd, const sc_integer id, const sc_integer dish_id, const sc_integer amount);

extern void sMOIfaceRF_init();
extern sc_boolean sMOIfaceRF_sendData(const sc_integer cmd, const sc_integer id, const sc_integer dish_id, const sc_integer amount);
extern sc_boolean sMOIfaceRF_sendConf(const sc_integer cmd, const sc_integer id);
extern sc_boolean sMOIfaceRF_sendMsg(const sc_string msg);
extern sc_string sMOIfaceRF_getData();





//
// This is a timed state machine that requires timer services
// 

//! This function has to set up timers for the time events that are required by the state machine.
/*! 
	This function will be called for each time event that is relevant for a state when a state will be entered.
	\param evid An unique identifier of the event.
	\time_ms The time in milli seconds
	\periodic Indicates the the time event must be raised periodically until the timer is unset 
*/
extern void sMO_setTimer(const sc_eventid evid, const sc_integer time_ms, const sc_boolean periodic);

//! This function has to unset timers for the time events that are required by the state machine.
/*! 
	This function will be called for each time event taht is relevant for a state when a state will be left.
	\param evid An unique identifier of the event.
*/
extern void sMO_unsetTimer(const sc_eventid evid);

#ifdef __cplusplus
}
#endif 

#endif /* SMOREQUIRED_H_ */
