#ifndef SMCREQUIRED_H_
#define SMCREQUIRED_H_

#include "sc_types.h"

#ifdef __cplusplus
extern "C" {
#endif 



/*! \file This header defines prototypes for all functions that are required by the state machine implementation.

This is a state machine uses time events which require access to a timing service. Thus the function prototypes:
	- sMC_setTimer and
	- sMC_unsetTimer
are defined.

This state machine makes use of operations declared in the state machines interface or internal scopes. Thus the function prototypes:
	- sMCIfaceLCD_clear
	- sMCIfaceLCD_writeString
	- sMCIfaceLCD_writeStringXY
	- sMCIfaceLCD_writeNumberXY
	- sMCIfaceLCD_init
	- sMCIfaceKEYPAD_checkpress
	- sMCIfaceKEYPAD_init
	- sMCIfaceUART_init
	- sMCIfaceUART_sendData
	- sMCIfaceUART_sendTemp
	- sMCIfaceUART_getData
	- sMCIfaceRF_init
	- sMCIfaceRF_sendRequest
	- sMCIfaceRF_sendMsg
	- sMCIfaceRF_sendCheck
	- sMCIfaceRF_getCheck
	- sMCIfaceRF_getData
	- sMCIface_convertNumber
are defined.
		
These functions will be called during a 'run to completion step' (runCycle) of the statechart. 
There are some constraints that have to be considered for the implementation of these functions:
	- never call the statechart API functions from within these functions.
	- make sure that the execution time is as short as possible.
 
*/

extern void sMCIfaceLCD_clear();
extern void sMCIfaceLCD_writeString(const sc_string chr);
extern void sMCIfaceLCD_writeStringXY(const sc_string chr, const sc_integer x, const sc_integer y);
extern void sMCIfaceLCD_writeNumberXY(const sc_integer num, const sc_integer x, const sc_integer y, const sc_integer l);
extern void sMCIfaceLCD_init();

extern sc_integer sMCIfaceKEYPAD_checkpress();
extern void sMCIfaceKEYPAD_init();

extern void sMCIfaceUART_init();
extern void sMCIfaceUART_sendData(const sc_string msg);
extern void sMCIfaceUART_sendTemp();
extern sc_string sMCIfaceUART_getData();

extern void sMCIfaceRF_init();
extern sc_boolean sMCIfaceRF_sendRequest(const sc_integer cmd, const sc_integer id);
extern sc_boolean sMCIfaceRF_sendMsg(const sc_string msg);
extern sc_boolean sMCIfaceRF_sendCheck();
extern sc_boolean sMCIfaceRF_getCheck();
extern sc_string sMCIfaceRF_getData();


extern void sMCIface_convertNumber(const sc_integer num, const sc_integer pos);



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
extern void sMC_setTimer(const sc_eventid evid, const sc_integer time_ms, const sc_boolean periodic);

//! This function has to unset timers for the time events that are required by the state machine.
/*! 
	This function will be called for each time event taht is relevant for a state when a state will be left.
	\param evid An unique identifier of the event.
*/
extern void sMC_unsetTimer(const sc_eventid evid);

#ifdef __cplusplus
}
#endif 

#endif /* SMCREQUIRED_H_ */
