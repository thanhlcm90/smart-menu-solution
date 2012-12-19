#include <stdlib.h>
#include <string.h>
#include "sc_types.h"
#include "SMC.h"
#include "SMCRequired.h"

/*! \file Implementation of the state machine 'SMC'
*/

// prototypes of all internal functions

static void sMC_entryaction(SMC* handle);
static void sMC_exitaction(SMC* handle);
static void sMC_react_main_region_On_r1_Init(SMC* handle);
static void sMC_react_main_region_On_r1_Running_keypad_CheckKey(SMC* handle);
static void sMC_react_main_region_On_r1_Running_keypad_CheckKeyDown(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_WaitingForRequest(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_CheckKeyPress(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_FinishDish(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_CancelDish(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_EnterData_r1__final_0(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_EnterData_r1_Clear(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_Send(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_Check(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_SendFail2(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult(SMC* handle);
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send__final_0(SMC* handle);
static void clearInEvents(SMC* handle);
static void clearOutEvents(SMC* handle);


void sMC_init(SMC* handle)
{
	int i;

	for (i = 0; i < SMC_MAX_ORTHOGONAL_STATES; ++i)
		handle->stateConfVector[i] = SMC_last_state;
	
	
	handle->stateConfVectorPosition = 0;

	// TODO: initialize all events ...
	// TODO: initialize all variables ... (set default values - here or inenter sequence ?!?)

}

void sMC_enter(SMC* handle)
{
	/* Default enter sequence for statechart SMC */
	sMC_entryaction(handle);
	/* Default enter sequence for region main region */
	/* Default react sequence for initial entry  */
	/* Default enter sequence for state On */
	/* Entry action for state 'On'. */
	handle->iface.lightOn = bool_true;
	/* Default enter sequence for region r1 */
	/* Default react sequence for initial entry  */
	/* Default enter sequence for state Init */
	/* Entry action for state 'Init'. */
	sMCIfaceRF_init();
	sMCIfaceUART_init();
	handle->stateConfVector[0] = SMC_main_region_On_r1_Init;
	handle->stateConfVectorPosition = 0;
}

void sMC_exit(SMC* handle)
{
	/* Default exit sequence for statechart SMC */
	/* Default exit sequence for region main region */
	/* Handle exit of all possible states (of main region) at position 0... */
	switch(handle->stateConfVector[ 0 ]) {
		case SMC_main_region_On_r1_Init : {
			/* Default exit sequence for state Init */
			handle->stateConfVector[0] = SMC_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		case SMC_main_region_On_r1_Running_keypad_CheckKey : {
			/* Default exit sequence for state CheckKey */
			handle->stateConfVector[0] = SMC_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		case SMC_main_region_On_r1_Running_keypad_CheckKeyDown : {
			/* Default exit sequence for state CheckKeyDown */
			handle->stateConfVector[0] = SMC_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		default: break;
	}
	/* Handle exit of all possible states (of main region) at position 1... */
	switch(handle->stateConfVector[ 1 ]) {
		case SMC_main_region_On_r1_Running_running_main_WaitingForRequest : {
			/* Default exit sequence for state WaitingForRequest */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_CheckKeyPress : {
			/* Default exit sequence for state CheckKeyPress */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_FinishDish : {
			/* Default exit sequence for state FinishDish */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_CancelDish : {
			/* Default exit sequence for state CancelDish */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish : {
			/* Default exit sequence for state ChooseDish */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_EnterData_r1__final_ : {
			/* Default exit sequence for final state. */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear : {
			/* Default exit sequence for state Clear */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_Send : {
			/* Default exit sequence for state Send */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_Check : {
			/* Default exit sequence for state Check */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_SendFail2 : {
			/* Default exit sequence for state SendFail2 */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			/* Exit action for state 'SendFail2'. */
			sMC_unsetTimer( (sc_eventid) &(handle->timeEvents.SendFail2_time_event_0_raised) );		
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult : {
			/* Default exit sequence for state ResetResult */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send__final_ : {
			/* Default exit sequence for final state. */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		default: break;
	}
	sMC_exitaction(handle);
}

static void clearInEvents(SMC* handle) {
	handle->ifaceKEYPAD.key_pressed_raised = bool_false;
	handle->ifaceUART.DataRecieved_raised = bool_false;
	handle->ifaceRF.DataRecieved_raised = bool_false;
	handle->iface.switchOff_raised = bool_false;
	handle->iface.switchOn_raised = bool_false;
}

static void clearOutEvents(SMC* handle) {
}

void sMC_runCycle(SMC* handle) {
	
	clearOutEvents(handle);
	
	for (handle->stateConfVectorPosition = 0;
		handle->stateConfVectorPosition < SMC_MAX_ORTHOGONAL_STATES;
		handle->stateConfVectorPosition++) {
			
		switch (handle->stateConfVector[handle->stateConfVectorPosition]) {
		case SMC_main_region_On_r1_Init : {
			sMC_react_main_region_On_r1_Init(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_keypad_CheckKey : {
			sMC_react_main_region_On_r1_Running_keypad_CheckKey(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_keypad_CheckKeyDown : {
			sMC_react_main_region_On_r1_Running_keypad_CheckKeyDown(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_WaitingForRequest : {
			sMC_react_main_region_On_r1_Running_running_main_WaitingForRequest(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_CheckKeyPress : {
			sMC_react_main_region_On_r1_Running_running_main_CheckKeyPress(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_FinishDish : {
			sMC_react_main_region_On_r1_Running_running_main_FinishDish(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_CancelDish : {
			sMC_react_main_region_On_r1_Running_running_main_CancelDish(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish : {
			sMC_react_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_EnterData_r1__final_ : {
			sMC_react_main_region_On_r1_Running_running_main_EnterData_r1__final_0(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear : {
			sMC_react_main_region_On_r1_Running_running_main_EnterData_r1_Clear(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_Send : {
			sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_Send(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_Check : {
			sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_Check(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_SendFail2 : {
			sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_SendFail2(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult : {
			sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult(handle);
			break;
		}
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send__final_ : {
			sMC_react_main_region_On_r1_Running_running_main_Send_Request_send__final_0(handle);
			break;
		}
		default:
			break;
		}
	}
	
	clearInEvents(handle);
}

void sMC_raiseTimeEvent(SMC* handle, sc_eventid evid) {
	if ( ((intptr_t)evid) >= ((intptr_t)&(handle->timeEvents))
		&&  ((intptr_t)evid) < ((intptr_t)&(handle->timeEvents)) + sizeof(SMCTimeEvents)) {
		*(sc_boolean*)evid = bool_true;
	}		
}

sc_boolean sMC_isActive(SMC* handle, SMCStates state) {
	switch (state) {
		case SMC_main_region_On : 
			return (sc_boolean) (handle->stateConfVector[0] >= SMC_main_region_On
				&& handle->stateConfVector[0] <= SMC_main_region_On_r1_Running_running_main_Send_Request_send__final_);
		case SMC_main_region_On_r1_Init : 
			return (sc_boolean) (handle->stateConfVector[0] == SMC_main_region_On_r1_Init
			);
		case SMC_main_region_On_r1_Running : 
			return (sc_boolean) (handle->stateConfVector[0] >= SMC_main_region_On_r1_Running
				&& handle->stateConfVector[0] <= SMC_main_region_On_r1_Running_running_main_Send_Request_send__final_);
		case SMC_main_region_On_r1_Running_keypad_CheckKey : 
			return (sc_boolean) (handle->stateConfVector[0] == SMC_main_region_On_r1_Running_keypad_CheckKey
			);
		case SMC_main_region_On_r1_Running_keypad_CheckKeyDown : 
			return (sc_boolean) (handle->stateConfVector[0] == SMC_main_region_On_r1_Running_keypad_CheckKeyDown
			);
		case SMC_main_region_On_r1_Running_running_main_WaitingForRequest : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_WaitingForRequest
			);
		case SMC_main_region_On_r1_Running_running_main_CheckKeyPress : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_CheckKeyPress
			);
		case SMC_main_region_On_r1_Running_running_main_FinishDish : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_FinishDish
			);
		case SMC_main_region_On_r1_Running_running_main_CancelDish : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_CancelDish
			);
		case SMC_main_region_On_r1_Running_running_main_EnterData : 
			return (sc_boolean) (handle->stateConfVector[1] >= SMC_main_region_On_r1_Running_running_main_EnterData
				&& handle->stateConfVector[1] <= SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear);
		case SMC_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish
			);
		case SMC_main_region_On_r1_Running_running_main_EnterData_r1__final_ : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_EnterData_r1__final_
			);
		case SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear
			);
		case SMC_main_region_On_r1_Running_running_main_Send_Request : 
			return (sc_boolean) (handle->stateConfVector[1] >= SMC_main_region_On_r1_Running_running_main_Send_Request
				&& handle->stateConfVector[1] <= SMC_main_region_On_r1_Running_running_main_Send_Request_send__final_);
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_Send : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_Send_Request_send_Send
			);
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_Check : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_Send_Request_send_Check
			);
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_SendFail2 : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_Send_Request_send_SendFail2
			);
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult
			);
		case SMC_main_region_On_r1_Running_running_main_Send_Request_send__final_ : 
			return (sc_boolean) (handle->stateConfVector[1] == SMC_main_region_On_r1_Running_running_main_Send_Request_send__final_
			);
		default: return bool_false;
	}
}



void sMCIfaceKEYPAD_raise_key_pressed(SMC* handle) {
	handle->ifaceKEYPAD.key_pressed_raised = bool_true;
}


sc_integer sMCIfaceKEYPAD_get_key(SMC* handle) {
	return handle->ifaceKEYPAD.key;
}
void sMCIfaceKEYPAD_set_key(SMC* handle, sc_integer value) {
	handle->ifaceKEYPAD.key = value;
}
sc_integer sMCIfaceKEYPAD_get_lastkey(SMC* handle) {
	return handle->ifaceKEYPAD.lastkey;
}
void sMCIfaceKEYPAD_set_lastkey(SMC* handle, sc_integer value) {
	handle->ifaceKEYPAD.lastkey = value;
}
sc_boolean sMCIfaceKEYPAD_get_key_down(SMC* handle) {
	return handle->ifaceKEYPAD.key_down;
}
void sMCIfaceKEYPAD_set_key_down(SMC* handle, sc_boolean value) {
	handle->ifaceKEYPAD.key_down = value;
}
void sMCIfaceUART_raise_dataRecieved(SMC* handle) {
	handle->ifaceUART.DataRecieved_raised = bool_true;
}


sc_string sMCIfaceUART_get_data(SMC* handle) {
	return handle->ifaceUART.data;
}
void sMCIfaceUART_set_data(SMC* handle, sc_string value) {
	handle->ifaceUART.data = value;
}
sc_string sMCIfaceUART_get_lastdata(SMC* handle) {
	return handle->ifaceUART.lastdata;
}
void sMCIfaceUART_set_lastdata(SMC* handle, sc_string value) {
	handle->ifaceUART.lastdata = value;
}
void sMCIfaceRF_raise_dataRecieved(SMC* handle) {
	handle->ifaceRF.DataRecieved_raised = bool_true;
}


sc_string sMCIfaceRF_get_data(SMC* handle) {
	return handle->ifaceRF.data;
}
void sMCIfaceRF_set_data(SMC* handle, sc_string value) {
	handle->ifaceRF.data = value;
}
sc_string sMCIfaceRF_get_lastdata(SMC* handle) {
	return handle->ifaceRF.lastdata;
}
void sMCIfaceRF_set_lastdata(SMC* handle, sc_string value) {
	handle->ifaceRF.lastdata = value;
}
sc_boolean sMCIfaceRF_get_result(SMC* handle) {
	return handle->ifaceRF.result;
}
void sMCIfaceRF_set_result(SMC* handle, sc_boolean value) {
	handle->ifaceRF.result = value;
}
sc_integer sMCIfaceRF_get_retry(SMC* handle) {
	return handle->ifaceRF.retry;
}
void sMCIfaceRF_set_retry(SMC* handle, sc_integer value) {
	handle->ifaceRF.retry = value;
}
sc_integer sMCIfaceRF_get_iD(SMC* handle) {
	return handle->ifaceRF.ID;
}
void sMCIfaceRF_set_iD(SMC* handle, sc_integer value) {
	handle->ifaceRF.ID = value;
}


sc_integer sMCIfaceDISH_get_iD(SMC* handle) {
	return handle->ifaceDISH.ID;
}
void sMCIfaceDISH_set_iD(SMC* handle, sc_integer value) {
	handle->ifaceDISH.ID = value;
}
sc_integer sMCIfaceDISH_get_amount(SMC* handle) {
	return handle->ifaceDISH.amount;
}
void sMCIfaceDISH_set_amount(SMC* handle, sc_integer value) {
	handle->ifaceDISH.amount = value;
}
sc_integer sMCIfaceDISH_get_pos(SMC* handle) {
	return handle->ifaceDISH.pos;
}
void sMCIfaceDISH_set_pos(SMC* handle, sc_integer value) {
	handle->ifaceDISH.pos = value;
}
void sMCIface_raise_switchOff(SMC* handle) {
	handle->iface.switchOff_raised = bool_true;
}
void sMCIface_raise_switchOn(SMC* handle) {
	handle->iface.switchOn_raised = bool_true;
}


sc_boolean sMCIface_get_lightOn(SMC* handle) {
	return handle->iface.lightOn;
}
void sMCIface_set_lightOn(SMC* handle, sc_boolean value) {
	handle->iface.lightOn = value;
}
sc_integer sMCIface_get_requestId(SMC* handle) {
	return handle->iface.requestId;
}
void sMCIface_set_requestId(SMC* handle, sc_integer value) {
	handle->iface.requestId = value;
}
sc_integer sMCIface_get_listId(SMC* handle) {
	return handle->iface.listId;
}
void sMCIface_set_listId(SMC* handle, sc_integer value) {
	handle->iface.listId = value;
}
		
// implementations of all internal functions

/* Entry action for statechart 'SMC'. */
static void sMC_entryaction(SMC* handle) {
	/* Entry action for statechart 'SMC'. */
}

/* Exit action for state 'SMC'. */
static void sMC_exitaction(SMC* handle) {
	/* Exit action for state 'SMC'. */
}

/* The reactions of state Init. */
static void sMC_react_main_region_On_r1_Init(SMC* handle) {
	/* The reactions of state Init. */
	if (bool_true) { 
		/* Default exit sequence for state Init */
		handle->stateConfVector[0] = SMC_last_state;
		handle->stateConfVectorPosition = 0;
		/* Default enter sequence for state Running */
		/* Default enter sequence for region keypad */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state CheckKey */
		/* Entry action for state 'CheckKey'. */
		handle->ifaceKEYPAD.key = sMCIfaceKEYPAD_checkpress();
		handle->ifaceKEYPAD.key_down = bool_false;
		handle->stateConfVector[0] = SMC_main_region_On_r1_Running_keypad_CheckKey;
		handle->stateConfVectorPosition = 0;
		/* Default enter sequence for region running main */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state WaitingForRequest */
		/* Entry action for state 'WaitingForRequest'. */
		handle->iface.requestId = 0;
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_WaitingForRequest;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state CheckKey. */
static void sMC_react_main_region_On_r1_Running_keypad_CheckKey(SMC* handle) {
	/* The reactions of state CheckKey. */
	if (handle->ifaceKEYPAD.key != 0) { 
		/* Default exit sequence for state CheckKey */
		handle->stateConfVector[0] = SMC_last_state;
		handle->stateConfVectorPosition = 0;
		handle->ifaceKEYPAD.lastkey = handle->ifaceKEYPAD.key;
		/* Default enter sequence for state CheckKeyDown */
		/* Entry action for state 'CheckKeyDown'. */
		handle->ifaceKEYPAD.key = sMCIfaceKEYPAD_checkpress();
		handle->ifaceKEYPAD.key_down = bool_true;
		handle->stateConfVector[0] = SMC_main_region_On_r1_Running_keypad_CheckKeyDown;
		handle->stateConfVectorPosition = 0;
	}  else {
		if (handle->ifaceKEYPAD.key == 0) { 
			/* Default enter sequence for state CheckKey */
			/* Entry action for state 'CheckKey'. */
			handle->ifaceKEYPAD.key = sMCIfaceKEYPAD_checkpress();
			handle->ifaceKEYPAD.key_down = bool_false;
			handle->stateConfVector[0] = SMC_main_region_On_r1_Running_keypad_CheckKey;
			handle->stateConfVectorPosition = 0;
		} 
	}
}

/* The reactions of state CheckKeyDown. */
static void sMC_react_main_region_On_r1_Running_keypad_CheckKeyDown(SMC* handle) {
	/* The reactions of state CheckKeyDown. */
	if (handle->ifaceKEYPAD.key == 0) { 
		/* Default exit sequence for state CheckKeyDown */
		handle->stateConfVector[0] = SMC_last_state;
		handle->stateConfVectorPosition = 0;
		handle->ifaceKEYPAD.key_pressed_raised = bool_true;
		/* Default enter sequence for state CheckKey */
		/* Entry action for state 'CheckKey'. */
		handle->ifaceKEYPAD.key = sMCIfaceKEYPAD_checkpress();
		handle->ifaceKEYPAD.key_down = bool_false;
		handle->stateConfVector[0] = SMC_main_region_On_r1_Running_keypad_CheckKey;
		handle->stateConfVectorPosition = 0;
	}  else {
		if (handle->ifaceKEYPAD.key != 0) { 
			/* Default enter sequence for state CheckKeyDown */
			/* Entry action for state 'CheckKeyDown'. */
			handle->ifaceKEYPAD.key = sMCIfaceKEYPAD_checkpress();
			handle->ifaceKEYPAD.key_down = bool_true;
			handle->stateConfVector[0] = SMC_main_region_On_r1_Running_keypad_CheckKeyDown;
			handle->stateConfVectorPosition = 0;
		} 
	}
}

/* The reactions of state WaitingForRequest. */
static void sMC_react_main_region_On_r1_Running_running_main_WaitingForRequest(SMC* handle) {
	/* The reactions of state WaitingForRequest. */
	if (bool_true) { 
		/* Default exit sequence for state WaitingForRequest */
		handle->stateConfVector[1] = SMC_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state CheckKeyPress */
		/* Entry action for state 'CheckKeyPress'. */
		handle->ifaceKEYPAD.lastkey = 0;
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_CheckKeyPress;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state CheckKeyPress. */
static void sMC_react_main_region_On_r1_Running_running_main_CheckKeyPress(SMC* handle) {
	/* The reactions of state CheckKeyPress. */
	if (handle->ifaceKEYPAD.lastkey == 13 && handle->ifaceKEYPAD.key_pressed_raised) { 
		/* Default exit sequence for state CheckKeyPress */
		handle->stateConfVector[1] = SMC_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state FinishDish */
		/* Entry action for state 'FinishDish'. */
		handle->iface.requestId = 5;
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_FinishDish;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceKEYPAD.lastkey == 14 && handle->ifaceKEYPAD.key_pressed_raised) { 
			/* Default exit sequence for state CheckKeyPress */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state CancelDish */
			/* Entry action for state 'CancelDish'. */
			handle->iface.requestId = 6;
			handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_CancelDish;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state FinishDish. */
static void sMC_react_main_region_On_r1_Running_running_main_FinishDish(SMC* handle) {
	/* The reactions of state FinishDish. */
	if (bool_true) { 
		/* Default exit sequence for state FinishDish */
		handle->stateConfVector[1] = SMC_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state EnterData */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state Clear */
		/* Entry action for state 'Clear'. */
		handle->iface.listId = 0;
		handle->ifaceKEYPAD.lastkey = 0;
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state CancelDish. */
static void sMC_react_main_region_On_r1_Running_running_main_CancelDish(SMC* handle) {
	/* The reactions of state CancelDish. */
	if (bool_true) { 
		/* Default exit sequence for state CancelDish */
		handle->stateConfVector[1] = SMC_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state EnterData */
		/* Default enter sequence for region r1 */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state Clear */
		/* Entry action for state 'Clear'. */
		handle->iface.listId = 0;
		handle->ifaceKEYPAD.lastkey = 0;
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state ChooseDish. */
static void sMC_react_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish(SMC* handle) {
	/* The reactions of state ChooseDish. */
	if (handle->iface.requestId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMC_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish : {
				/* Default exit sequence for state ChooseDish */
				handle->stateConfVector[1] = SMC_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMC_main_region_On_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMC_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear : {
				/* Default exit sequence for state Clear */
				handle->stateConfVector[1] = SMC_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state WaitingForRequest */
		/* Entry action for state 'WaitingForRequest'. */
		handle->iface.requestId = 0;
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_WaitingForRequest;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state ChooseDish */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			handle->iface.requestId = 0;
			/* Default enter sequence for state null */
			handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_EnterData_r1__final_;
			handle->stateConfVectorPosition = 1;
		}  else {
			if (bool_true) { 
				/* Default exit sequence for state EnterData */
				/* Default exit sequence for region r1 */
				/* Handle exit of all possible states (of r1) at position 1... */
				switch(handle->stateConfVector[ 1 ]) {
					case SMC_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish : {
						/* Default exit sequence for state ChooseDish */
						handle->stateConfVector[1] = SMC_last_state;
						handle->stateConfVectorPosition = 1;
						break;
					}
					case SMC_main_region_On_r1_Running_running_main_EnterData_r1__final_ : {
						/* Default exit sequence for final state. */
						handle->stateConfVector[1] = SMC_last_state;
						handle->stateConfVectorPosition = 1;
						break;
					}
					case SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear : {
						/* Default exit sequence for state Clear */
						handle->stateConfVector[1] = SMC_last_state;
						handle->stateConfVectorPosition = 1;
						break;
					}
					default: break;
				}
				handle->ifaceRF.result = bool_false;
				handle->ifaceRF.retry = 0;
				/* Default enter sequence for state Send Request */
				/* Default enter sequence for region send */
				/* Default react sequence for initial entry  */
				/* Default enter sequence for state Send */
				/* Entry action for state 'Send'. */
				handle->ifaceRF.retry += 1;
				handle->ifaceRF.result = sMCIfaceRF_sendRequest(handle->iface.requestId, handle->iface.listId);
				handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_Send_Request_send_Send;
				handle->stateConfVectorPosition = 1;
			} 
		}
	}
}

/* The reactions of state null. */
static void sMC_react_main_region_On_r1_Running_running_main_EnterData_r1__final_0(SMC* handle) {
	/* The reactions of state null. */
	if (handle->iface.requestId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMC_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish : {
				/* Default exit sequence for state ChooseDish */
				handle->stateConfVector[1] = SMC_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMC_main_region_On_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMC_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear : {
				/* Default exit sequence for state Clear */
				handle->stateConfVector[1] = SMC_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state WaitingForRequest */
		/* Entry action for state 'WaitingForRequest'. */
		handle->iface.requestId = 0;
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_WaitingForRequest;
		handle->stateConfVectorPosition = 1;
	}  else {
	}
}

/* The reactions of state Clear. */
static void sMC_react_main_region_On_r1_Running_running_main_EnterData_r1_Clear(SMC* handle) {
	/* The reactions of state Clear. */
	if (handle->iface.requestId == 0) { 
		/* Default exit sequence for state EnterData */
		/* Default exit sequence for region r1 */
		/* Handle exit of all possible states (of r1) at position 1... */
		switch(handle->stateConfVector[ 1 ]) {
			case SMC_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish : {
				/* Default exit sequence for state ChooseDish */
				handle->stateConfVector[1] = SMC_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMC_main_region_On_r1_Running_running_main_EnterData_r1__final_ : {
				/* Default exit sequence for final state. */
				handle->stateConfVector[1] = SMC_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			case SMC_main_region_On_r1_Running_running_main_EnterData_r1_Clear : {
				/* Default exit sequence for state Clear */
				handle->stateConfVector[1] = SMC_last_state;
				handle->stateConfVectorPosition = 1;
				break;
			}
			default: break;
		}
		/* Default enter sequence for state WaitingForRequest */
		/* Entry action for state 'WaitingForRequest'. */
		handle->iface.requestId = 0;
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_WaitingForRequest;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceKEYPAD.lastkey <= 10 && handle->ifaceKEYPAD.lastkey >= 1 && handle->ifaceKEYPAD.key_pressed_raised) { 
			/* Default exit sequence for state Clear */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state ChooseDish */
			/* Entry action for state 'ChooseDish'. */
			handle->iface.listId = handle->ifaceKEYPAD.lastkey;
			handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state Send. */
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_Send(SMC* handle) {
	/* The reactions of state Send. */
	if (handle->ifaceRF.result == bool_true) { 
		/* Default exit sequence for state Send */
		handle->stateConfVector[1] = SMC_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state Check */
		/* Entry action for state 'Check'. */
		handle->ifaceRF.result = sMCIfaceRF_getCheck();
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_Send_Request_send_Check;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceRF.result == bool_false) { 
			/* Default exit sequence for state Send */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state SendFail2 */
			/* Entry action for state 'SendFail2'. */
			sMC_setTimer( (sc_eventid) &(handle->timeEvents.SendFail2_time_event_0_raised) , 2 * 1000, bool_false);
			sMCIfaceLCD_clear();
			sMCIfaceLCD_writeString("Send fail");
			handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_Send_Request_send_SendFail2;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state Check. */
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_Check(SMC* handle) {
	/* The reactions of state Check. */
	if (handle->ifaceRF.result == bool_false) { 
		/* Default exit sequence for state Check */
		handle->stateConfVector[1] = SMC_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state Send */
		/* Entry action for state 'Send'. */
		handle->ifaceRF.retry += 1;
		handle->ifaceRF.result = sMCIfaceRF_sendRequest(handle->iface.requestId, handle->iface.listId);
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_Send_Request_send_Send;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state Check */
			handle->stateConfVector[1] = SMC_last_state;
			handle->stateConfVectorPosition = 1;
			/* Default enter sequence for state ResetResult */
			/* Entry action for state 'ResetResult'. */
			handle->ifaceRF.result = bool_true;
			handle->ifaceRF.retry = 0;
			handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state SendFail2. */
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_SendFail2(SMC* handle) {
	/* The reactions of state SendFail2. */
	if (handle->timeEvents.SendFail2_time_event_0_raised) { 
		/* Default exit sequence for state SendFail2 */
		handle->stateConfVector[1] = SMC_last_state;
		handle->stateConfVectorPosition = 1;
		/* Exit action for state 'SendFail2'. */
		sMC_unsetTimer( (sc_eventid) &(handle->timeEvents.SendFail2_time_event_0_raised) );		
		/* Default enter sequence for state ResetResult */
		/* Entry action for state 'ResetResult'. */
		handle->ifaceRF.result = bool_true;
		handle->ifaceRF.retry = 0;
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state ResetResult. */
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult(SMC* handle) {
	/* The reactions of state ResetResult. */
	if (bool_true) { 
		/* Default exit sequence for state ResetResult */
		handle->stateConfVector[1] = SMC_last_state;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for state null */
		handle->stateConfVector[1] = SMC_main_region_On_r1_Running_running_main_Send_Request_send__final_;
		handle->stateConfVectorPosition = 1;
	} 
}

/* The reactions of state null. */
static void sMC_react_main_region_On_r1_Running_running_main_Send_Request_send__final_0(SMC* handle) {
	/* The reactions of state null. */
}


