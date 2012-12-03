#include <stdlib.h>
#include <string.h>
#include "sc_types.h"
#include "SMO.h"
#include "SMORequired.h"

/*! \file Implementation of the state machine 'SMO'
*/

// prototypes of all internal functions

static void sMO_entryaction(SMO* handle);
static void sMO_exitaction(SMO* handle);
static void sMO_react_main_region_on_r1_Init(SMO* handle);
static void sMO_react_main_region_on_r1_Running_keypad_CheckKey(SMO* handle);
static void sMO_react_main_region_on_r1_Running_keypad_CheckKeyDown(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_ShowMenu(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckAmount0(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1__final_0(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_MenuA(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_CheckKeyPress(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendData_r1_Send(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendData_r1_Check(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendData_r1__final_0(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_MenuB(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_MenuC(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_MenuD(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1__final_0(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendConfirm_r1_Check(SMO* handle);
static void sMO_react_main_region_on_r1_Running_running_main_SendConfirm_r1__final_0(SMO* handle);
static void clearInEvents(SMO* handle);
static void clearOutEvents(SMO* handle);


void sMO_init(SMO* handle)
{
	int i;

	for (i = 0; i < SMO_MAX_ORTHOGONAL_STATES; ++i)
		handle->stateConfVector[i] = SMO_last_state;
	
	
	handle->stateConfVectorPosition = 0;

	// TODO: initialize all events ...
	// TODO: initialize all variables ... (set default values - here or inenter sequence ?!?)

}

void sMO_enter(SMO* handle)
{
	/* Default enter sequence for statechart SMO */
	sMO_entryaction(handle);
	/* Default enter sequence for region main region */
	/* Default react sequence for initial entry  */
	/* Default enter sequence for state on */
	/* Entry action for state 'on'. */
	handle->iface.lightOn = bool_true;
	/* Default enter sequence for region r1 */
	/* Default react sequence for initial entry  */
	/* Default enter sequence for state Init */
	/* Entry action for state 'Init'. */
	sMO_setTimer( (sc_eventid) &(handle->timeEvents.Init_time_event_0_raised) , 3 * 1000, bool_false);
	handle->iface.tableId = 1;
	sMOIfaceLCD_init();
	sMOIfaceKEYPAD_init();
	sMOIfaceRF_init();
	sMOIfaceLCD_clear();
	sMOIfaceLCD_writeString("STARTING...");
	handle->stateConfVector[0] = SMO_main_region_on_r1_Init;
	handle->stateConfVectorPosition = 0;
}

void sMO_exit(SMO* handle)
{
	/* Default exit sequence for statechart SMO */
	/* Default exit sequence for region main region */
	/* Handle exit of all possible states (of main region) at position 0... */
	switch(handle->stateConfVector[ 0 ]) {
		case SMO_main_region_on_r1_Init : {
			/* Default exit sequence for state Init */
			handle->stateConfVector[0] = SMO_last_state;
			handle->stateConfVectorPosition = 0;
			/* Exit action for state 'Init'. */
			sMO_unsetTimer( (sc_eventid) &(handle->timeEvents.Init_time_event_0_raised) );		
			break;
		}
		case SMO_main_region_on_r1_Running_keypad_CheckKey : {
			/* Default exit sequence for state CheckKey */
			handle->stateConfVector[0] = SMO_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		case SMO_main_region_on_r1_Running_keypad_CheckKeyDown : {
			/* Default exit sequence for state CheckKeyDown */
			handle->stateConfVector[0] = SMO_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		default: break;
	}
	/* Handle exit of all possible states (of main region) at position 1... */
	switch(handle->stateConfVector[ 1 ]) {
		case SMO_main_region_on_r1_Running_running_main_ShowMenu : {
			/* Default exit sequence for state ShowMenu */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
			/* Default exit sequence for state ShowCode */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
			/* Default exit sequence for state EnterCode */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
			/* Default exit sequence for state CheckKeyPress1 */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
			/* Default exit sequence for state CheckCode0 */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
			/* Default exit sequence for state ShowAmount */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
			/* Default exit sequence for state CheckKeyPress2 */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
			/* Default exit sequence for state EnterAmount */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
			/* Default exit sequence for final state. */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_MenuA : {
			/* Default exit sequence for state MenuA */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_CheckKeyPress : {
			/* Default exit sequence for state CheckKeyPress */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendData_r1_Send : {
			/* Default exit sequence for state Send */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendData_r1_Check : {
			/* Default exit sequence for state Check */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendData_r1__final_ : {
			/* Default exit sequence for final state. */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_MenuB : {
			/* Default exit sequence for state MenuB */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_MenuC : {
			/* Default exit sequence for state MenuC */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_MenuD : {
			/* Default exit sequence for state MenuD */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation : {
			/* Default exit sequence for state RequestConfirmation */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation : {
			/* Default exit sequence for state EnterConfirmation */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Exit action for state 'EnterConfirmation'. */
			sMO_unsetTimer( (sc_eventid) &(handle->timeEvents.EnterConfirmation_time_event_0_raised) );		
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress : {
			/* Default exit sequence for state CheckKeyPress */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_ : {
			/* Default exit sequence for final state. */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation : {
			/* Default exit sequence for state SendConfirmation */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_Check : {
			/* Default exit sequence for state Check */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_ : {
			/* Default exit sequence for final state. */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		default: break;
	}
	sMO_exitaction(handle);
}

static void clearInEvents(SMO* handle) {
	handle->ifaceKEYPAD.key_pressed_raised = bool_false;
	handle->ifaceUART.DataRecieved_raised = bool_false;
	handle->ifaceRF.DataRecieved_raised = bool_false;
	handle->iface.switchOff_raised = bool_false;
	handle->iface.switchOn_raised = bool_false;
}

static void clearOutEvents(SMO* handle) {
}

void sMO_runCycle(SMO* handle) {
	
	clearOutEvents(handle);
	
	for (handle->stateConfVectorPosition = 0;
		handle->stateConfVectorPosition < SMO_MAX_ORTHOGONAL_STATES;
		handle->stateConfVectorPosition++) {
			
		switch (handle->stateConfVector[handle->stateConfVectorPosition]) {
		case SMO_main_region_on_r1_Init : {
			sMO_react_main_region_on_r1_Init(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_keypad_CheckKey : {
			sMO_react_main_region_on_r1_Running_keypad_CheckKey(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_keypad_CheckKeyDown : {
			sMO_react_main_region_on_r1_Running_keypad_CheckKeyDown(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_ShowMenu : {
			sMO_react_main_region_on_r1_Running_running_main_ShowMenu(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
			sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
			sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
			sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
			sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
			sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
			sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckAmount0 : {
			sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckAmount0(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
			sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
			sMO_react_main_region_on_r1_Running_running_main_EnterData_r1__final_0(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_MenuA : {
			sMO_react_main_region_on_r1_Running_running_main_MenuA(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_CheckKeyPress : {
			sMO_react_main_region_on_r1_Running_running_main_CheckKeyPress(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendData_r1_Send : {
			sMO_react_main_region_on_r1_Running_running_main_SendData_r1_Send(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendData_r1_Check : {
			sMO_react_main_region_on_r1_Running_running_main_SendData_r1_Check(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendData_r1__final_ : {
			sMO_react_main_region_on_r1_Running_running_main_SendData_r1__final_0(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_MenuB : {
			sMO_react_main_region_on_r1_Running_running_main_MenuB(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_MenuC : {
			sMO_react_main_region_on_r1_Running_running_main_MenuC(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_MenuD : {
			sMO_react_main_region_on_r1_Running_running_main_MenuD(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation : {
			sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation : {
			sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress : {
			sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_ : {
			sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1__final_0(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation : {
			sMO_react_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_Check : {
			sMO_react_main_region_on_r1_Running_running_main_SendConfirm_r1_Check(handle);
			break;
		}
		case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_ : {
			sMO_react_main_region_on_r1_Running_running_main_SendConfirm_r1__final_0(handle);
			break;
		}
		default:
			break;
		}
	}
	
	clearInEvents(handle);
}

void sMO_raiseTimeEvent(SMO* handle, sc_eventid evid) {
	if ( ((intptr_t)evid) >= ((intptr_t)&(handle->timeEvents))
		&&  ((intptr_t)evid) < ((intptr_t)&(handle->timeEvents)) + sizeof(SMOTimeEvents)) {
		*(sc_boolean*)evid = bool_true;
	}		
}

sc_boolean sMO_isActive(SMO* handle, SMOStates state) {
	switch (state) {
		case SMO_main_region_on : 
			return (sc_boolean) (handle->stateConfVector[0] >= SMO_main_region_on
				&& handle->stateConfVector[0] <= SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_);
		case SMO_main_region_on_r1_Init : 
			return (sc_boolean) (handle->stateConfVector[0] == SMO_main_region_on_r1_Init
			);
		case SMO_main_region_on_r1_Running : 
			return (sc_boolean) (handle->stateConfVector[0] >= SMO_main_region_on_r1_Running
				&& handle->stateConfVector[0] <= SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_);
		case SMO_main_region_on_r1_Running_keypad_CheckKey : 
			return (sc_boolean) (handle->stateConfVector[0] == SMO_main_region_on_r1_Running_keypad_CheckKey
			);
		case SMO_main_region_on_r1_Running_keypad_CheckKeyDown : 
			return (sc_boolean) (handle->stateConfVector[0] == SMO_main_region_on_r1_Running_keypad_CheckKeyDown
			);
		case SMO_main_region_on_r1_Running_running_main_ShowMenu : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_ShowMenu
			);
		case SMO_main_region_on_r1_Running_running_main_EnterData : 
			return (sc_boolean) (handle->stateConfVector[1] >= SMO_main_region_on_r1_Running_running_main_EnterData
				&& handle->stateConfVector[1] <= SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_);
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode
			);
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode
			);
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1
			);
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0
			);
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount
			);
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2
			);
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckAmount0 : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckAmount0
			);
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount
			);
		case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_
			);
		case SMO_main_region_on_r1_Running_running_main_MenuA : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_MenuA
			);
		case SMO_main_region_on_r1_Running_running_main_CheckKeyPress : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_CheckKeyPress
			);
		case SMO_main_region_on_r1_Running_running_main_SendData : 
			return (sc_boolean) (handle->stateConfVector[1] >= SMO_main_region_on_r1_Running_running_main_SendData
				&& handle->stateConfVector[1] <= SMO_main_region_on_r1_Running_running_main_SendData_r1__final_);
		case SMO_main_region_on_r1_Running_running_main_SendData_r1_Send : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendData_r1_Send
			);
		case SMO_main_region_on_r1_Running_running_main_SendData_r1_Check : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendData_r1_Check
			);
		case SMO_main_region_on_r1_Running_running_main_SendData_r1__final_ : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendData_r1__final_
			);
		case SMO_main_region_on_r1_Running_running_main_MenuB : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_MenuB
			);
		case SMO_main_region_on_r1_Running_running_main_MenuC : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_MenuC
			);
		case SMO_main_region_on_r1_Running_running_main_MenuD : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_MenuD
			);
		case SMO_main_region_on_r1_Running_running_main_SendRequest : 
			return (sc_boolean) (handle->stateConfVector[1] >= SMO_main_region_on_r1_Running_running_main_SendRequest
				&& handle->stateConfVector[1] <= SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_);
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation
			);
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation
			);
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress
			);
		case SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_ : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_
			);
		case SMO_main_region_on_r1_Running_running_main_SendConfirm : 
			return (sc_boolean) (handle->stateConfVector[1] >= SMO_main_region_on_r1_Running_running_main_SendConfirm
				&& handle->stateConfVector[1] <= SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_);
		case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation
			);
		case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_Check : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_Check
			);
		case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_ : 
			return (sc_boolean) (handle->stateConfVector[1] == SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_
			);
		default: return bool_false;
	}
}



void sMOIfaceKEYPAD_raise_key_pressed(SMO* handle) {
	handle->ifaceKEYPAD.key_pressed_raised = bool_true;
}


sc_integer sMOIfaceKEYPAD_get_key(SMO* handle) {
	return handle->ifaceKEYPAD.key;
}
void sMOIfaceKEYPAD_set_key(SMO* handle, sc_integer value) {
	handle->ifaceKEYPAD.key = value;
}
sc_integer sMOIfaceKEYPAD_get_lastkey(SMO* handle) {
	return handle->ifaceKEYPAD.lastkey;
}
void sMOIfaceKEYPAD_set_lastkey(SMO* handle, sc_integer value) {
	handle->ifaceKEYPAD.lastkey = value;
}
sc_boolean sMOIfaceKEYPAD_get_key_down(SMO* handle) {
	return handle->ifaceKEYPAD.key_down;
}
void sMOIfaceKEYPAD_set_key_down(SMO* handle, sc_boolean value) {
	handle->ifaceKEYPAD.key_down = value;
}
void sMOIfaceUART_raise_dataRecieved(SMO* handle) {
	handle->ifaceUART.DataRecieved_raised = bool_true;
}


sc_string sMOIfaceUART_get_data(SMO* handle) {
	return handle->ifaceUART.data;
}
void sMOIfaceUART_set_data(SMO* handle, sc_string value) {
	handle->ifaceUART.data = value;
}
sc_string sMOIfaceUART_get_lastdata(SMO* handle) {
	return handle->ifaceUART.lastdata;
}
void sMOIfaceUART_set_lastdata(SMO* handle, sc_string value) {
	handle->ifaceUART.lastdata = value;
}
void sMOIfaceRF_raise_dataRecieved(SMO* handle) {
	handle->ifaceRF.DataRecieved_raised = bool_true;
}


sc_string sMOIfaceRF_get_data(SMO* handle) {
	return handle->ifaceRF.data;
}
void sMOIfaceRF_set_data(SMO* handle, sc_string value) {
	handle->ifaceRF.data = value;
}
sc_string sMOIfaceRF_get_lastdata(SMO* handle) {
	return handle->ifaceRF.lastdata;
}
void sMOIfaceRF_set_lastdata(SMO* handle, sc_string value) {
	handle->ifaceRF.lastdata = value;
}
sc_boolean sMOIfaceRF_get_result(SMO* handle) {
	return handle->ifaceRF.result;
}
void sMOIfaceRF_set_result(SMO* handle, sc_boolean value) {
	handle->ifaceRF.result = value;
}
sc_integer sMOIfaceRF_get_retry(SMO* handle) {
	return handle->ifaceRF.retry;
}
void sMOIfaceRF_set_retry(SMO* handle, sc_integer value) {
	handle->ifaceRF.retry = value;
}
sc_integer sMOIfaceRF_get_iD(SMO* handle) {
	return handle->ifaceRF.ID;
}
void sMOIfaceRF_set_iD(SMO* handle, sc_integer value) {
	handle->ifaceRF.ID = value;
}


sc_integer sMOIfaceDISH_get_iD(SMO* handle) {
	return handle->ifaceDISH.ID;
}
void sMOIfaceDISH_set_iD(SMO* handle, sc_integer value) {
	handle->ifaceDISH.ID = value;
}
sc_integer sMOIfaceDISH_get_amount(SMO* handle) {
	return handle->ifaceDISH.amount;
}
void sMOIfaceDISH_set_amount(SMO* handle, sc_integer value) {
	handle->ifaceDISH.amount = value;
}
sc_integer sMOIfaceDISH_get_pos(SMO* handle) {
	return handle->ifaceDISH.pos;
}
void sMOIfaceDISH_set_pos(SMO* handle, sc_integer value) {
	handle->ifaceDISH.pos = value;
}


sc_integer sMOIfaceCONF_get_confirmId(SMO* handle) {
	return handle->ifaceCONF.confirmId;
}
void sMOIfaceCONF_set_confirmId(SMO* handle, sc_integer value) {
	handle->ifaceCONF.confirmId = value;
}
void sMOIface_raise_switchOff(SMO* handle) {
	handle->iface.switchOff_raised = bool_true;
}
void sMOIface_raise_switchOn(SMO* handle) {
	handle->iface.switchOn_raised = bool_true;
}


sc_boolean sMOIface_get_lightOn(SMO* handle) {
	return handle->iface.lightOn;
}
void sMOIface_set_lightOn(SMO* handle, sc_boolean value) {
	handle->iface.lightOn = value;
}
sc_integer sMOIface_get_menuId(SMO* handle) {
	return handle->iface.menuId;
}
void sMOIface_set_menuId(SMO* handle, sc_integer value) {
	handle->iface.menuId = value;
}
sc_integer sMOIface_get_tableId(SMO* handle) {
	return handle->iface.tableId;
}
void sMOIface_set_tableId(SMO* handle, sc_integer value) {
	handle->iface.tableId = value;
}
		
// implementations of all internal functions

/* Entry action for statechart 'SMO'. */
static void sMO_entryaction(SMO* handle) {
	/* Entry action for statechart 'SMO'. */
}

/* Exit action for state 'SMO'. */
static void sMO_exitaction(SMO* handle) {
	/* Exit action for state 'SMO'. */
}

/* The reactions of state Init. */
static void sMO_react_main_region_on_r1_Init(SMO* handle) {
	/* The reactions of state Init. */
	if (handle->timeEvents.Init_time_event_0_raised) { 
		/* Default exit sequence for state Init */
		handle->stateConfVector[0] = SMO_last_state;
		handle->stateConfVectorPosition = 0;
		/* Exit action for state 'Init'. */
		sMO_unsetTimer( (sc_eventid) &(handle->timeEvents.Init_time_event_0_raised) );		
		/* Default enter sequence for state Running */
		/* Default enter sequence for region keypad */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state CheckKey */
		/* Entry action for state 'CheckKey'. */
		handle->ifaceKEYPAD.key = sMOIfaceKEYPAD_checkpress();
		handle->ifaceKEYPAD.key_down = bool_false;
		handle->stateConfVector[0] = SMO_main_region_on_r1_Running_keypad_CheckKey;
		handle->stateConfVectorPosition = 0;
		/* Default enter sequence for region running main */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state CheckKey. */
static void sMO_react_main_region_on_r1_Running_keypad_CheckKey(SMO* handle) {
	/* The reactions of state CheckKey. */
	if (handle->ifaceKEYPAD.key != 0) { 
		/* Default exit sequence for state CheckKey */
		handle->stateConfVector[0] = SMO_last_state;
		handle->stateConfVectorPosition = 0;
		handle->ifaceKEYPAD.lastkey = handle->ifaceKEYPAD.key;
		/* Default enter sequence for state CheckKeyDown */
		/* Entry action for state 'CheckKeyDown'. */
		handle->ifaceKEYPAD.key = sMOIfaceKEYPAD_checkpress();
		handle->ifaceKEYPAD.key_down = bool_true;
		handle->stateConfVector[0] = SMO_main_region_on_r1_Running_keypad_CheckKeyDown;
		handle->stateConfVectorPosition = 0;
	}  else {
		if (handle->ifaceKEYPAD.key == 0) { 
			/* Default enter sequence for state CheckKey */
			/* Entry action for state 'CheckKey'. */
			handle->ifaceKEYPAD.key = sMOIfaceKEYPAD_checkpress();
			handle->ifaceKEYPAD.key_down = bool_false;
			handle->stateConfVector[0] = SMO_main_region_on_r1_Running_keypad_CheckKey;
			handle->stateConfVectorPosition = 0;
		} 
	}
}

/* The reactions of state CheckKeyDown. */
static void sMO_react_main_region_on_r1_Running_keypad_CheckKeyDown(SMO* handle) {
	/* The reactions of state CheckKeyDown. */
	if (handle->ifaceKEYPAD.key == 0) { 
		/* Default exit sequence for state CheckKeyDown */
		handle->stateConfVector[0] = SMO_last_state;
		handle->stateConfVectorPosition = 0;
		handle->ifaceKEYPAD.key_pressed_raised = bool_true;
		/* Default enter sequence for state CheckKey */
		/* Entry action for state 'CheckKey'. */
		handle->ifaceKEYPAD.key = sMOIfaceKEYPAD_checkpress();
		handle->ifaceKEYPAD.key_down = bool_false;
		handle->stateConfVector[0] = SMO_main_region_on_r1_Running_keypad_CheckKey;
		handle->stateConfVectorPosition = 0;
	}  else {
		if (handle->ifaceKEYPAD.key != 0) { 
			/* Default enter sequence for state CheckKeyDown */
			/* Entry action for state 'CheckKeyDown'. */
			handle->ifaceKEYPAD.key = sMOIfaceKEYPAD_checkpress();
			handle->ifaceKEYPAD.key_down = bool_true;
			handle->stateConfVector[0] = SMO_main_region_on_r1_Running_keypad_CheckKeyDown;
			handle->stateConfVectorPosition = 0;
		} 
	}
}

/* The reactions of state ShowMenu. */
static void sMO_react_main_region_on_r1_Running_running_main_ShowMenu(SMO* handle) {
	/* The reactions of state ShowMenu. */
	if (bool_true) { 
		/* Default exit sequence for state ShowMenu */
		handle->stateConfVector[1] = SMO_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state CheckKeyPress */
		/* Entry action for state 'CheckKeyPress'. */
		handle->ifaceKEYPAD.lastkey = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_CheckKeyPress;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state ShowCode. */
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode(SMO* handle) {
	/* The reactions of state ShowCode. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
				/* Default exit sequence for state ShowCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
				/* Default exit sequence for state EnterCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
				/* Default exit sequence for state CheckCode0 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
				/* Default exit sequence for state ShowAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
				/* Default exit sequence for state EnterAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state ShowCode */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state CheckKeyPress1 */
			/* Entry action for state 'CheckKeyPress1'. */
			handle->ifaceKEYPAD.lastkey = 0;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state EnterCode. */
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode(SMO* handle) {
	/* The reactions of state EnterCode. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
				/* Default exit sequence for state ShowCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
				/* Default exit sequence for state EnterCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
				/* Default exit sequence for state CheckCode0 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
				/* Default exit sequence for state ShowAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
				/* Default exit sequence for state EnterAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state EnterCode */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state CheckKeyPress1 */
			/* Entry action for state 'CheckKeyPress1'. */
			handle->ifaceKEYPAD.lastkey = 0;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state CheckKeyPress1. */
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1(SMO* handle) {
	/* The reactions of state CheckKeyPress1. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
				/* Default exit sequence for state ShowCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
				/* Default exit sequence for state EnterCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
				/* Default exit sequence for state CheckCode0 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
				/* Default exit sequence for state ShowAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
				/* Default exit sequence for state EnterAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceDISH.pos < 3 && handle->ifaceKEYPAD.lastkey <= 9 && handle->ifaceKEYPAD.lastkey >= 1 && handle->ifaceKEYPAD.key_pressed_raised) { 
			/* Default exit sequence for state CheckKeyPress1 */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state EnterCode */
			/* Entry action for state 'EnterCode'. */
			sMOIfaceLCD_writeNumberXY(handle->ifaceKEYPAD.lastkey, handle->ifaceDISH.pos * 2, 1, 1);
			handle->ifaceDISH.pos += 1;
			handle->ifaceDISH.ID = handle->ifaceDISH.ID * 10 + handle->ifaceKEYPAD.lastkey;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode;
			handle->stateConfVectorPosition = 1;
		}  else {
			if (handle->ifaceDISH.pos < 3 && handle->ifaceKEYPAD.lastkey == 10 && handle->ifaceKEYPAD.key_pressed_raised) { 
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				/* Default enter sequence for state CheckCode0 */
				/* Entry action for state 'CheckCode0'. */
				handle->ifaceKEYPAD.lastkey = 0;
				handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0;
				handle->stateConfVectorPosition = 1;
			}  else {
				if (handle->ifaceKEYPAD.lastkey == 12 && handle->ifaceKEYPAD.key_pressed_raised) { 
					/* Default exit sequence for state CheckKeyPress1 */
					handle->stateConfVector[1] = SMO_last_state;
					handle->stateConfVectorPosition = 1;
					/* Default enter sequence for state ShowCode */
					/* Entry action for state 'ShowCode'. */
					sMOIfaceLCD_clear();
					sMOIfaceLCD_writeString("ENTER DISH ID:");
					sMOIfaceLCD_writeStringXY("_ _ _", 0, 1);
					handle->ifaceDISH.pos = 0;
					handle->ifaceDISH.ID = 0;
					handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode;
					handle->stateConfVectorPosition = 1;
				}  else {
					if (handle->ifaceKEYPAD.lastkey == 11 && handle->ifaceKEYPAD.key_pressed_raised) { 
						/* Default exit sequence for state CheckKeyPress1 */
						handle->stateConfVector[1] = SMO_last_state;
						handle->stateConfVectorPosition = 1;
						/* Default enter sequence for state ShowAmount */
						/* Entry action for state 'ShowAmount'. */
						sMOIfaceLCD_clear();
						sMOIfaceLCD_writeString("ENTER AMOUNT:");
						sMOIfaceLCD_writeStringXY("_ _", 0, 1);
						handle->ifaceDISH.pos = 0;
						handle->ifaceDISH.amount = 0;
						handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount;
						handle->stateConfVectorPosition = 1;
					}  else {
						if (handle->ifaceKEYPAD.lastkey == 16 && handle->ifaceKEYPAD.key_pressed_raised) { 
							/* Default exit sequence for state CheckKeyPress1 */
							handle->stateConfVector[1] = SMO_last_state;
							handle->stateConfVectorPosition = 1;
							handle->iface.menuId = 0;
							/* Default enter sequence for state null */
							handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_;
							handle->stateConfVectorPosition = 1;
						} 
					}
				}
			}
		}
	}
}

/* The reactions of state CheckCode0. */
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0(SMO* handle) {
	/* The reactions of state CheckCode0. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
				/* Default exit sequence for state ShowCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
				/* Default exit sequence for state EnterCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
				/* Default exit sequence for state CheckCode0 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
				/* Default exit sequence for state ShowAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
				/* Default exit sequence for state EnterAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state CheckCode0 */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state EnterCode */
			/* Entry action for state 'EnterCode'. */
			sMOIfaceLCD_writeNumberXY(handle->ifaceKEYPAD.lastkey, handle->ifaceDISH.pos * 2, 1, 1);
			handle->ifaceDISH.pos += 1;
			handle->ifaceDISH.ID = handle->ifaceDISH.ID * 10 + handle->ifaceKEYPAD.lastkey;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state ShowAmount. */
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount(SMO* handle) {
	/* The reactions of state ShowAmount. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
				/* Default exit sequence for state ShowCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
				/* Default exit sequence for state EnterCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
				/* Default exit sequence for state CheckCode0 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
				/* Default exit sequence for state ShowAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
				/* Default exit sequence for state EnterAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state ShowAmount */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state CheckKeyPress2 */
			/* Entry action for state 'CheckKeyPress2'. */
			handle->ifaceKEYPAD.lastkey = 0;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state CheckKeyPress2. */
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2(SMO* handle) {
	/* The reactions of state CheckKeyPress2. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
				/* Default exit sequence for state ShowCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
				/* Default exit sequence for state EnterCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
				/* Default exit sequence for state CheckCode0 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
				/* Default exit sequence for state ShowAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
				/* Default exit sequence for state EnterAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceDISH.pos < 2 && handle->ifaceKEYPAD.lastkey == 10 && handle->ifaceKEYPAD.key_pressed_raised) { 
			/* Default exit sequence for state CheckKeyPress2 */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state CheckAmount0 */
			/* Entry action for state 'CheckAmount0'. */
			handle->ifaceKEYPAD.lastkey = 0;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckAmount0;
			handle->stateConfVectorPosition = 1;
		}  else {
			if (handle->ifaceDISH.pos < 2 && handle->ifaceKEYPAD.lastkey <= 9 && handle->ifaceKEYPAD.lastkey >= 1 && handle->ifaceKEYPAD.key_pressed_raised) { 
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				/* Default enter sequence for state EnterAmount */
				/* Entry action for state 'EnterAmount'. */
				sMOIfaceLCD_writeNumberXY(handle->ifaceKEYPAD.lastkey, handle->ifaceDISH.pos * 2, 1, 1);
				handle->ifaceDISH.pos += 1;
				handle->ifaceDISH.amount = handle->ifaceDISH.amount * 10 + handle->ifaceKEYPAD.lastkey;
				handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount;
				handle->stateConfVectorPosition = 1;
			}  else {
				if (handle->ifaceKEYPAD.lastkey == 12 && handle->ifaceKEYPAD.key_pressed_raised) { 
					/* Default exit sequence for state CheckKeyPress2 */
					handle->stateConfVector[1] = SMO_last_state;
					handle->stateConfVectorPosition = 1;
					/* Default enter sequence for state ShowAmount */
					/* Entry action for state 'ShowAmount'. */
					sMOIfaceLCD_clear();
					sMOIfaceLCD_writeString("ENTER AMOUNT:");
					sMOIfaceLCD_writeStringXY("_ _", 0, 1);
					handle->ifaceDISH.pos = 0;
					handle->ifaceDISH.amount = 0;
					handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount;
					handle->stateConfVectorPosition = 1;
				}  else {
					if (handle->ifaceKEYPAD.lastkey == 11 && handle->ifaceKEYPAD.key_pressed_raised) { 
						/* Default exit sequence for state EnterData */
						/* Default exit sequence for region r1 */
						/* Handle exit of all possible states (of r1) at position 1... */
						switch(handle->stateConfVector[ 1 ]) {
							case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
								/* Default exit sequence for state ShowCode */
								handle->stateConfVector[1] = SMO_last_state;
								handle->stateConfVectorPosition = 1;
								break;
							}
							case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
								/* Default exit sequence for state EnterCode */
								handle->stateConfVector[1] = SMO_last_state;
								handle->stateConfVectorPosition = 1;
								break;
							}
							case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
								/* Default exit sequence for state CheckKeyPress1 */
								handle->stateConfVector[1] = SMO_last_state;
								handle->stateConfVectorPosition = 1;
								break;
							}
							case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
								/* Default exit sequence for state CheckCode0 */
								handle->stateConfVector[1] = SMO_last_state;
								handle->stateConfVectorPosition = 1;
								break;
							}
							case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
								/* Default exit sequence for state ShowAmount */
								handle->stateConfVector[1] = SMO_last_state;
								handle->stateConfVectorPosition = 1;
								break;
							}
							case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
								/* Default exit sequence for state CheckKeyPress2 */
								handle->stateConfVector[1] = SMO_last_state;
								handle->stateConfVectorPosition = 1;
								break;
							}
							case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
								/* Default exit sequence for state EnterAmount */
								handle->stateConfVector[1] = SMO_last_state;
								handle->stateConfVectorPosition = 1;
								break;
							}
							case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
								/* Default exit sequence for final state. */
								handle->stateConfVector[1] = SMO_last_state;
								handle->stateConfVectorPosition = 1;
								break;
							}
							default: break;
						}
						handle->ifaceRF.result = bool_false;
						handle->ifaceRF.retry = 0;
						/* Default enter sequence for state SendData */
						/* Default enter sequence for region r1 */
						/* Default react sequence for initial entry  */
						/* Default enter sequence for state Send */
						/* Entry action for state 'Send'. */
						handle->ifaceRF.result = sMOIfaceRF_sendData(handle->iface.menuId, handle->iface.tableId, handle->ifaceDISH.ID, handle->ifaceDISH.amount);
						handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendData_r1_Send;
						handle->stateConfVectorPosition = 1;
					}  else {
						if (handle->ifaceKEYPAD.lastkey == 16 && handle->ifaceKEYPAD.key_pressed_raised) { 
							/* Default exit sequence for state CheckKeyPress2 */
							handle->stateConfVector[1] = SMO_last_state;
							handle->stateConfVectorPosition = 1;
							handle->iface.menuId = 0;
							/* Default enter sequence for state null */
							handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_;
							handle->stateConfVectorPosition = 1;
						} 
					}
				}
			}
		}
	}
}

/* The reactions of state CheckAmount0. */
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_CheckAmount0(SMO* handle) {
	/* The reactions of state CheckAmount0. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
				/* Default exit sequence for state ShowCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
				/* Default exit sequence for state EnterCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
				/* Default exit sequence for state CheckCode0 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
				/* Default exit sequence for state ShowAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
				/* Default exit sequence for state EnterAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state CheckAmount0 */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state EnterAmount */
			/* Entry action for state 'EnterAmount'. */
			sMOIfaceLCD_writeNumberXY(handle->ifaceKEYPAD.lastkey, handle->ifaceDISH.pos * 2, 1, 1);
			handle->ifaceDISH.pos += 1;
			handle->ifaceDISH.amount = handle->ifaceDISH.amount * 10 + handle->ifaceKEYPAD.lastkey;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state EnterAmount. */
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount(SMO* handle) {
	/* The reactions of state EnterAmount. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
				/* Default exit sequence for state ShowCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
				/* Default exit sequence for state EnterCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
				/* Default exit sequence for state CheckCode0 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
				/* Default exit sequence for state ShowAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
				/* Default exit sequence for state EnterAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state EnterAmount */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state CheckKeyPress2 */
			/* Entry action for state 'CheckKeyPress2'. */
			handle->ifaceKEYPAD.lastkey = 0;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state null. */
static void sMO_react_main_region_on_r1_Running_running_main_EnterData_r1__final_0(SMO* handle) {
	/* The reactions of state null. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode : {
				/* Default exit sequence for state ShowCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode : {
				/* Default exit sequence for state EnterCode */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 : {
				/* Default exit sequence for state CheckKeyPress1 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 : {
				/* Default exit sequence for state CheckCode0 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount : {
				/* Default exit sequence for state ShowAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 : {
				/* Default exit sequence for state CheckKeyPress2 */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount : {
				/* Default exit sequence for state EnterAmount */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
	}
}

/* The reactions of state MenuA. */
static void sMO_react_main_region_on_r1_Running_running_main_MenuA(SMO* handle) {
	/* The reactions of state MenuA. */
	if (bool_true) { 
		/* Default exit sequence for state MenuA */
		handle->stateConfVector[1] = SMO_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state EnterData */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state ShowCode */
		/* Entry action for state 'ShowCode'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("ENTER DISH ID:");
		sMOIfaceLCD_writeStringXY("_ _ _", 0, 1);
		handle->ifaceDISH.pos = 0;
		handle->ifaceDISH.ID = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state CheckKeyPress. */
static void sMO_react_main_region_on_r1_Running_running_main_CheckKeyPress(SMO* handle) {
	/* The reactions of state CheckKeyPress. */
	if (handle->ifaceKEYPAD.lastkey == 13 && handle->ifaceKEYPAD.key_pressed_raised) { 
		/* Default exit sequence for state CheckKeyPress */
		handle->stateConfVector[1] = SMO_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state MenuA */
		/* Entry action for state 'MenuA'. */
		handle->iface.menuId = 1;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_MenuA;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceKEYPAD.lastkey == 14 && handle->ifaceKEYPAD.key_pressed_raised) { 
			/* Default exit sequence for state CheckKeyPress */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state MenuB */
			/* Entry action for state 'MenuB'. */
			handle->iface.menuId = 2;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_MenuB;
			handle->stateConfVectorPosition = 1;
		}  else {
			if (handle->ifaceKEYPAD.lastkey == 15 && handle->ifaceKEYPAD.key_pressed_raised) { 
				/* Default exit sequence for state CheckKeyPress */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				/* Default enter sequence for state MenuC */
				/* Entry action for state 'MenuC'. */
				handle->iface.menuId = 3;
				handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_MenuC;
				handle->stateConfVectorPosition = 1;
			}  else {
				if (handle->ifaceKEYPAD.lastkey == 16 && handle->ifaceKEYPAD.key_pressed_raised) { 
					/* Default exit sequence for state CheckKeyPress */
					handle->stateConfVector[1] = SMO_last_state;
					handle->stateConfVectorPosition = 1;
					/* Default enter sequence for state MenuD */
					/* Entry action for state 'MenuD'. */
					handle->iface.menuId = 4;
					handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_MenuD;
					handle->stateConfVectorPosition = 1;
				} 
			}
		}
	}
}

/* The reactions of state Send. */
static void sMO_react_main_region_on_r1_Running_running_main_SendData_r1_Send(SMO* handle) {
	/* The reactions of state Send. */
	if (handle->ifaceRF.result == bool_true) { 
		/* Default exit sequence for state SendData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendData_r1_Send : {
				/* Default exit sequence for state Send */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendData_r1_Check : {
				/* Default exit sequence for state Check */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state EnterData */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state ShowCode */
		/* Entry action for state 'ShowCode'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("ENTER DISH ID:");
		sMOIfaceLCD_writeStringXY("_ _ _", 0, 1);
		handle->ifaceDISH.pos = 0;
		handle->ifaceDISH.ID = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceRF.result == bool_true) { 
			/* Default exit sequence for state Send */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state Check */
			/* Entry action for state 'Check'. */
			handle->ifaceRF.result = sMOIfaceRF_getCheck();
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendData_r1_Check;
			handle->stateConfVectorPosition = 1;
		}  else {
			if (handle->ifaceRF.result == bool_false) { 
				/* Default enter sequence for state Send */
				/* Entry action for state 'Send'. */
				handle->ifaceRF.result = sMOIfaceRF_sendData(handle->iface.menuId, handle->iface.tableId, handle->ifaceDISH.ID, handle->ifaceDISH.amount);
				handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendData_r1_Send;
				handle->stateConfVectorPosition = 1;
			} 
		}
	}
}

/* The reactions of state Check. */
static void sMO_react_main_region_on_r1_Running_running_main_SendData_r1_Check(SMO* handle) {
	/* The reactions of state Check. */
	if (handle->ifaceRF.result == bool_true) { 
		/* Default exit sequence for state SendData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendData_r1_Send : {
				/* Default exit sequence for state Send */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendData_r1_Check : {
				/* Default exit sequence for state Check */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state EnterData */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state ShowCode */
		/* Entry action for state 'ShowCode'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("ENTER DISH ID:");
		sMOIfaceLCD_writeStringXY("_ _ _", 0, 1);
		handle->ifaceDISH.pos = 0;
		handle->ifaceDISH.ID = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceRF.result == bool_false) { 
			/* Default exit sequence for state Check */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state Send */
			/* Entry action for state 'Send'. */
			handle->ifaceRF.result = sMOIfaceRF_sendData(handle->iface.menuId, handle->iface.tableId, handle->ifaceDISH.ID, handle->ifaceDISH.amount);
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendData_r1_Send;
			handle->stateConfVectorPosition = 1;
		}  else {
			if (handle->ifaceRF.result == bool_true) { 
				/* Default exit sequence for state Check */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				/* Default enter sequence for state null */
				handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendData_r1__final_;
				handle->stateConfVectorPosition = 1;
			} 
		}
	}
}

/* The reactions of state null. */
static void sMO_react_main_region_on_r1_Running_running_main_SendData_r1__final_0(SMO* handle) {
	/* The reactions of state null. */
	if (handle->ifaceRF.result == bool_true) { 
		/* Default exit sequence for state SendData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendData_r1_Send : {
				/* Default exit sequence for state Send */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendData_r1_Check : {
				/* Default exit sequence for state Check */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state EnterData */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state ShowCode */
		/* Entry action for state 'ShowCode'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("ENTER DISH ID:");
		sMOIfaceLCD_writeStringXY("_ _ _", 0, 1);
		handle->ifaceDISH.pos = 0;
		handle->ifaceDISH.ID = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode;
		handle->stateConfVectorPosition = 1;
	}  else {
	}
}

/* The reactions of state MenuB. */
static void sMO_react_main_region_on_r1_Running_running_main_MenuB(SMO* handle) {
	/* The reactions of state MenuB. */
	if (bool_true) { 
		/* Default exit sequence for state MenuB */
		handle->stateConfVector[1] = SMO_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state EnterData */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state ShowCode */
		/* Entry action for state 'ShowCode'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("ENTER DISH ID:");
		sMOIfaceLCD_writeStringXY("_ _ _", 0, 1);
		handle->ifaceDISH.pos = 0;
		handle->ifaceDISH.ID = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state MenuC. */
static void sMO_react_main_region_on_r1_Running_running_main_MenuC(SMO* handle) {
	/* The reactions of state MenuC. */
	if (bool_true) { 
		/* Default exit sequence for state MenuC */
		handle->stateConfVector[1] = SMO_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state SendRequest */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state RequestConfirmation */
		/* Entry action for state 'RequestConfirmation'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("PROCEED?");
		sMOIfaceLCD_writeStringXY("1-NO  2-YES", 0, 1);
		handle->ifaceCONF.confirmId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state MenuD. */
static void sMO_react_main_region_on_r1_Running_running_main_MenuD(SMO* handle) {
	/* The reactions of state MenuD. */
	if (bool_true) { 
		/* Default exit sequence for state MenuD */
		handle->stateConfVector[1] = SMO_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state SendRequest */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state RequestConfirmation */
		/* Entry action for state 'RequestConfirmation'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("PROCEED?");
		sMOIfaceLCD_writeStringXY("1-NO  2-YES", 0, 1);
		handle->ifaceCONF.confirmId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state RequestConfirmation. */
static void sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation(SMO* handle) {
	/* The reactions of state RequestConfirmation. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state SendRequest */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation : {
				/* Default exit sequence for state RequestConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation : {
				/* Default exit sequence for state EnterConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				/* Exit action for state 'EnterConfirmation'. */
				sMO_unsetTimer( (sc_eventid) &(handle->timeEvents.EnterConfirmation_time_event_0_raised) );		
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress : {
				/* Default exit sequence for state CheckKeyPress */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state RequestConfirmation */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state CheckKeyPress */
			/* Entry action for state 'CheckKeyPress'. */
			handle->ifaceKEYPAD.lastkey = 0;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state EnterConfirmation. */
static void sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation(SMO* handle) {
	/* The reactions of state EnterConfirmation. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state SendRequest */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation : {
				/* Default exit sequence for state RequestConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation : {
				/* Default exit sequence for state EnterConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				/* Exit action for state 'EnterConfirmation'. */
				sMO_unsetTimer( (sc_eventid) &(handle->timeEvents.EnterConfirmation_time_event_0_raised) );		
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress : {
				/* Default exit sequence for state CheckKeyPress */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->timeEvents.EnterConfirmation_time_event_0_raised) { 
			/* Default exit sequence for state EnterConfirmation */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Exit action for state 'EnterConfirmation'. */
			sMO_unsetTimer( (sc_eventid) &(handle->timeEvents.EnterConfirmation_time_event_0_raised) );		
			/* Default enter sequence for state CheckKeyPress */
			/* Entry action for state 'CheckKeyPress'. */
			handle->ifaceKEYPAD.lastkey = 0;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state CheckKeyPress. */
static void sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress(SMO* handle) {
	/* The reactions of state CheckKeyPress. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state SendRequest */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation : {
				/* Default exit sequence for state RequestConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation : {
				/* Default exit sequence for state EnterConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				/* Exit action for state 'EnterConfirmation'. */
				sMO_unsetTimer( (sc_eventid) &(handle->timeEvents.EnterConfirmation_time_event_0_raised) );		
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress : {
				/* Default exit sequence for state CheckKeyPress */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceKEYPAD.lastkey == 2 && handle->ifaceKEYPAD.key_pressed_raised) { 
			/* Default exit sequence for state CheckKeyPress */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state EnterConfirmation */
			/* Entry action for state 'EnterConfirmation'. */
			sMO_setTimer( (sc_eventid) &(handle->timeEvents.EnterConfirmation_time_event_0_raised) , 3 * 1000, bool_false);
			sMOIfaceLCD_clear();
			sMOIfaceLCD_writeString("Order Transferring");
			handle->ifaceCONF.confirmId = handle->ifaceKEYPAD.lastkey;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation;
			handle->stateConfVectorPosition = 1;
		}  else {
			if (handle->ifaceKEYPAD.lastkey == 2 && handle->ifaceKEYPAD.key_pressed_raised) { 
				/* Default exit sequence for state SendRequest */
				/* Default exit sequence for region r1 */
				/* Handle exit of all possible states (of r1) at position 1... */
				switch(handle->stateConfVector[ 1 ]) {
					case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation : {
						/* Default exit sequence for state RequestConfirmation */
						handle->stateConfVector[1] = SMO_last_state;
						handle->stateConfVectorPosition = 1;
						break;
					}
					case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation : {
						/* Default exit sequence for state EnterConfirmation */
						handle->stateConfVector[1] = SMO_last_state;
						handle->stateConfVectorPosition = 1;
						/* Exit action for state 'EnterConfirmation'. */
						sMO_unsetTimer( (sc_eventid) &(handle->timeEvents.EnterConfirmation_time_event_0_raised) );		
						break;
					}
					case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress : {
						/* Default exit sequence for state CheckKeyPress */
						handle->stateConfVector[1] = SMO_last_state;
						handle->stateConfVectorPosition = 1;
						break;
					}
					case SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_ : {
						/* Default exit sequence for final state. */
						handle->stateConfVector[1] = SMO_last_state;
						handle->stateConfVectorPosition = 1;
						break;
					}
					default: break;
				}
				handle->ifaceRF.result = bool_false;
				handle->ifaceRF.retry = 0;
				/* Default enter sequence for state SendConfirm */
				/* Default enter sequence for region r1 */
			}  else {
				if (handle->ifaceKEYPAD.lastkey == 2 || handle->ifaceKEYPAD.lastkey == 1 && handle->ifaceKEYPAD.key_pressed_raised) { 
					/* Default exit sequence for state CheckKeyPress */
					handle->stateConfVector[1] = SMO_last_state;
					handle->stateConfVectorPosition = 1;
					handle->iface.menuId = 0;
					/* Default enter sequence for state null */
					handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_;
					handle->stateConfVectorPosition = 1;
				} 
			}
		}
	}
}

/* The reactions of state null. */
static void sMO_react_main_region_on_r1_Running_running_main_SendRequest_r1__final_0(SMO* handle) {
	/* The reactions of state null. */
	if (handle->iface.menuId == 0) { 
		/* Default exit sequence for state SendRequest */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation : {
				/* Default exit sequence for state RequestConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_EnterConfirmation : {
				/* Default exit sequence for state EnterConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				/* Exit action for state 'EnterConfirmation'. */
				sMO_unsetTimer( (sc_eventid) &(handle->timeEvents.EnterConfirmation_time_event_0_raised) );		
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1_CheckKeyPress : {
				/* Default exit sequence for state CheckKeyPress */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state ShowMenu */
		/* Entry action for state 'ShowMenu'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("A-CALL  B-DEL");
		sMOIfaceLCD_writeStringXY("C-HELP  D-PAY", 0, 1);
		handle->iface.menuId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_ShowMenu;
		handle->stateConfVectorPosition = 1;
	}  else {
	}
}

/* The reactions of state SendConfirmation. */
static void sMO_react_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation(SMO* handle) {
	/* The reactions of state SendConfirmation. */
	if (handle->ifaceRF.result == bool_true) { 
		/* Default exit sequence for state SendConfirm */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation : {
				/* Default exit sequence for state SendConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_Check : {
				/* Default exit sequence for state Check */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state SendRequest */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state RequestConfirmation */
		/* Entry action for state 'RequestConfirmation'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("PROCEED?");
		sMOIfaceLCD_writeStringXY("1-NO  2-YES", 0, 1);
		handle->ifaceCONF.confirmId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceRF.result == bool_true) { 
			/* Default exit sequence for state SendConfirmation */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state Check */
			/* Entry action for state 'Check'. */
			handle->ifaceRF.result = sMOIfaceRF_getCheck();
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_Check;
			handle->stateConfVectorPosition = 1;
		}  else {
			if (handle->ifaceRF.result == bool_false) { 
				/* Default enter sequence for state SendConfirmation */
				/* Entry action for state 'SendConfirmation'. */
				handle->ifaceRF.result = sMOIfaceRF_sendConf(handle->iface.menuId, handle->iface.tableId);
				handle->ifaceRF.retry += 1;
				handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation;
				handle->stateConfVectorPosition = 1;
			} 
		}
	}
}

/* The reactions of state Check. */
static void sMO_react_main_region_on_r1_Running_running_main_SendConfirm_r1_Check(SMO* handle) {
	/* The reactions of state Check. */
	if (handle->ifaceRF.result == bool_true) { 
		/* Default exit sequence for state SendConfirm */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation : {
				/* Default exit sequence for state SendConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_Check : {
				/* Default exit sequence for state Check */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state SendRequest */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state RequestConfirmation */
		/* Entry action for state 'RequestConfirmation'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("PROCEED?");
		sMOIfaceLCD_writeStringXY("1-NO  2-YES", 0, 1);
		handle->ifaceCONF.confirmId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceRF.result == bool_false) { 
			/* Default exit sequence for state Check */
			handle->stateConfVector[1] = SMO_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state SendConfirmation */
			/* Entry action for state 'SendConfirmation'. */
			handle->ifaceRF.result = sMOIfaceRF_sendConf(handle->iface.menuId, handle->iface.tableId);
			handle->ifaceRF.retry += 1;
			handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation;
			handle->stateConfVectorPosition = 1;
		}  else {
			if (handle->ifaceRF.result == bool_true) { 
				/* Default exit sequence for state Check */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				/* Default enter sequence for state null */
				handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_;
				handle->stateConfVectorPosition = 1;
			} 
		}
	}
}

/* The reactions of state null. */
static void sMO_react_main_region_on_r1_Running_running_main_SendConfirm_r1__final_0(SMO* handle) {
	/* The reactions of state null. */
	if (handle->ifaceRF.result == bool_true) { 
		/* Default exit sequence for state SendConfirm */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_SendConfirmation : {
				/* Default exit sequence for state SendConfirmation */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1_Check : {
				/* Default exit sequence for state Check */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMO_main_region_on_r1_Running_running_main_SendConfirm_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMO_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state SendRequest */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state RequestConfirmation */
		/* Entry action for state 'RequestConfirmation'. */
		sMOIfaceLCD_clear();
		sMOIfaceLCD_writeString("PROCEED?");
		sMOIfaceLCD_writeStringXY("1-NO  2-YES", 0, 1);
		handle->ifaceCONF.confirmId = 0;
		handle->stateConfVector[1] = SMO_main_region_on_r1_Running_running_main_SendRequest_r1_RequestConfirmation;
		handle->stateConfVectorPosition = 1;
	}  else {
	}
}


