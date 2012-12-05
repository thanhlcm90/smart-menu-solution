#ifndef SMRREQUIRED_H_
#define SMRREQUIRED_H_

#include "sc_types.h"

#ifdef __cplusplus
extern "C" {
#endif 



/*! \file This header defines prototypes for all functions that are required by the state machine implementation.

This is a state machine uses time events which require access to a timing service. Thus the function prototypes:
	- sMR_setTimer and
	- sMR_unsetTimer
are defined.

This state machine makes use of operations declared in the state machines interface or internal scopes. Thus the function prototypes:
	- sMRIfaceLCD_clear
	- sMRIfaceLCD_writeString
	- sMRIfaceLCD_writeStringXY
	- sMRIfaceLCD_writeNumberXY
	- sMRIfaceLCD_init
	- sMRIfaceKEYPAD_checkpress
	- sMRIfaceKEYPAD_init
	- sMRIfaceUART_init
	- sMRIfaceUART_sendMsg
	- sMRIfaceUART_sendTemp
	- sMRIfaceUART_getData
	- sMRIfaceRF_init
	- sMRIfaceRF_sendData
	- sMRIfaceRF_sendMsg
	- sMRIfaceRF_sendCheck
	- sMRIfaceRF_getCheck
	- sMRIfaceRF_getData
	- sMRIface_convertNumber
are defined.
		
These functions will be called during a 'run to completion step' (runCycle) of the statechart. 
There are some constraints that have to be considered for the implementation of these functions:
	- never call the statechart API functions from within these functions.
	- make sure that the execution time is as short as possible.
 
*/

extern void sMRIfaceLCD_clear();
extern void sMRIfaceLCD_writeString(const sc_string chr);
extern void sMRIfaceLCD_writeStringXY(const sc_string chr, const sc_integer x, const sc_integer y);
extern void sMRIfaceLCD_writeNumberXY(const sc_integer num, const sc_integer x, const sc_integer y, const sc_integer l);
extern void sMRIfaceLCD_init();

extern sc_integer sMRIfaceKEYPAD_checkpress();
extern void sMRIfaceKEYPAD_init();

extern void sMRIfaceUART_init();
extern void sMRIfaceUART_sendMsg(const sc_string msg);
extern void sMRIfaceUART_sendTemp();
extern sc_string sMRIfaceUART_getData();

extern void sMRIfaceRF_init();
extern sc_boolean sMRIfaceRF_sendData(const sc_integer cmd, const sc_integer id, const sc_integer dish_id, const sc_integer amount);
extern sc_boolean sMRIfaceRF_sendMsg(const sc_string msg);
extern sc_boolean sMRIfaceRF_sendCheck();
extern sc_boolean sMRIfaceRF_getCheck();
extern sc_string sMRIfaceRF_getData();


extern void sMRIface_convertNumber(const sc_integer num, const sc_integer pos);



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
extern void sMR_setTimer(const sc_eventid evid, const sc_integer time_ms, const sc_boolean periodic);

//! This function has to unset timers for the time events that are required by the state machine.
/*! 
	This function will be called for each time event taht is relevant for a state when a state will be left.
	\param evid An unique identifier of the event.
*/
extern void sMR_unsetTimer(const sc_eventid evid);

#ifdef __cplusplus
}
#endif 

#endif /* SMRREQUIRED_H_ */
