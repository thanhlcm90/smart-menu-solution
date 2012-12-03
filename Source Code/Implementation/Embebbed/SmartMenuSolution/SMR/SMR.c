#include <stdlib.h>
#include <string.h>
#include "sc_types.h"
#include "SMR.h"
#include "SMRRequired.h"

/*! \file Implementation of the state machine 'SMR'
*/

// prototypes of all internal functions

static void sMR_entryaction(SMR* handle);
static void sMR_exitaction(SMR* handle);
static void sMR_react_main_region_on_r1_Init(SMR* handle);
static void sMR_react_main_region_on_r1_running_RF_GetData(SMR* handle);
static void sMR_react_main_region_on_r1_running_RF__final_0(SMR* handle);
static void sMR_react_main_region_on_r1_running_RF_SendSuccessful(SMR* handle);
static void sMR_react_main_region_on_r1_running_RF_DataReceicved(SMR* handle);
static void sMR_react_main_region_on_r1_running_keypad_CheckKey(SMR* handle);
static void sMR_react_main_region_on_r1_running_keypad_CheckKeyDown(SMR* handle);
static void sMR_react_main_region_on_r1_running_UART_ShowMsg(SMR* handle);
static void sMR_react_main_region_on_r1_running_UART_ShowNumber(SMR* handle);
static void sMR_react_main_region_on_r1_running_UART_SendUART(SMR* handle);
static void sMR_react_main_region_on_r1_running_UART_CheckKey(SMR* handle);
static void clearInEvents(SMR* handle);
static void clearOutEvents(SMR* handle);


void sMR_init(SMR* handle)
{
	int i;

	for (i = 0; i < SMR_MAX_ORTHOGONAL_STATES; ++i)
		handle->stateConfVector[i] = SMR_last_state;
	
	
	handle->stateConfVectorPosition = 0;

	// TODO: initialize all events ...
	// TODO: initialize all variables ... (set default values - here or inenter sequence ?!?)

}

void sMR_enter(SMR* handle)
{
	/* Default enter sequence for statechart SMR */
	sMR_entryaction(handle);
	/* Default enter sequence for region main region */
	/* Default react sequence for initial entry  */
	/* Default enter sequence for state on */
	/* Entry action for state 'on'. */
	handle->iface.lightOn = bool_true;
	/* Default enter sequence for region r1 */
	/* Default react sequence for initial entry  */
	/* Default enter sequence for state Init */
	/* Entry action for state 'Init'. */
	sMR_setTimer( (sc_eventid) &(handle->timeEvents.Init_time_event_0_raised) , 3 * 1000, bool_false);
	handle->iface.tableId = 1;
	sMRIfaceLCD_init();
	sMRIfaceKEYPAD_init();
	sMRIfaceRF_init();
	sMRIfaceUART_init();
	sMRIfaceLCD_clear();
	sMRIfaceLCD_writeString("STARTING...");
	handle->stateConfVector[0] = SMR_main_region_on_r1_Init;
	handle->stateConfVectorPosition = 0;
}

void sMR_exit(SMR* handle)
{
	/* Default exit sequence for statechart SMR */
	/* Default exit sequence for region main region */
	/* Handle exit of all possible states (of main region) at position 0... */
	switch(handle->stateConfVector[ 0 ]) {
		case SMR_main_region_on_r1_Init : {
			/* Default exit sequence for state Init */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			/* Exit action for state 'Init'. */
			sMR_unsetTimer( (sc_eventid) &(handle->timeEvents.Init_time_event_0_raised) );		
			break;
		}
		case SMR_main_region_on_r1_running_RF_GetData : {
			/* Default exit sequence for state GetData */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		case SMR_main_region_on_r1_running_RF__final_ : {
			/* Default exit sequence for final state. */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		case SMR_main_region_on_r1_running_RF_SendSuccessful : {
			/* Default exit sequence for state SendSuccessful */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		case SMR_main_region_on_r1_running_RF_DataReceicved : {
			/* Default exit sequence for state DataReceicved */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		default: break;
	}
	/* Handle exit of all possible states (of main region) at position 1... */
	switch(handle->stateConfVector[ 1 ]) {
		case SMR_main_region_on_r1_running_keypad_CheckKey : {
			/* Default exit sequence for state CheckKey */
			handle->stateConfVector[1] = SMR_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		case SMR_main_region_on_r1_running_keypad_CheckKeyDown : {
			/* Default exit sequence for state CheckKeyDown */
			handle->stateConfVector[1] = SMR_last_state;
			handle->stateConfVectorPosition = 1;
			break;
		}
		default: break;
	}
	/* Handle exit of all possible states (of main region) at position 2... */
	switch(handle->stateConfVector[ 2 ]) {
		case SMR_main_region_on_r1_running_UART_ShowMsg : {
			/* Default exit sequence for state ShowMsg */
			handle->stateConfVector[2] = SMR_last_state;
			handle->stateConfVectorPosition = 2;
			break;
		}
		case SMR_main_region_on_r1_running_UART_ShowNumber : {
			/* Default exit sequence for state ShowNumber */
			handle->stateConfVector[2] = SMR_last_state;
			handle->stateConfVectorPosition = 2;
			break;
		}
		case SMR_main_region_on_r1_running_UART_SendUART : {
			/* Default exit sequence for state SendUART */
			handle->stateConfVector[2] = SMR_last_state;
			handle->stateConfVectorPosition = 2;
			break;
		}
		case SMR_main_region_on_r1_running_UART_CheckKey : {
			/* Default exit sequence for state CheckKey */
			handle->stateConfVector[2] = SMR_last_state;
			handle->stateConfVectorPosition = 2;
			break;
		}
		default: break;
	}
	sMR_exitaction(handle);
}

static void clearInEvents(SMR* handle) {
	handle->ifaceKEYPAD.key_pressed_raised = bool_false;
	handle->ifaceUART.DataRecieved_raised = bool_false;
	handle->ifaceRF.DataRecieved_raised = bool_false;
	handle->iface.switchOff_raised = bool_false;
	handle->iface.switchOn_raised = bool_false;
}

static void clearOutEvents(SMR* handle) {
}

void sMR_runCycle(SMR* handle) {
	
	clearOutEvents(handle);
	
	for (handle->stateConfVectorPosition = 0;
		handle->stateConfVectorPosition < SMR_MAX_ORTHOGONAL_STATES;
		handle->stateConfVectorPosition++) {
			
		switch (handle->stateConfVector[handle->stateConfVectorPosition]) {
		case SMR_main_region_on_r1_Init : {
			sMR_react_main_region_on_r1_Init(handle);
			break;
		}
		case SMR_main_region_on_r1_running_RF_GetData : {
			sMR_react_main_region_on_r1_running_RF_GetData(handle);
			break;
		}
		case SMR_main_region_on_r1_running_RF__final_ : {
			sMR_react_main_region_on_r1_running_RF__final_0(handle);
			break;
		}
		case SMR_main_region_on_r1_running_RF_SendSuccessful : {
			sMR_react_main_region_on_r1_running_RF_SendSuccessful(handle);
			break;
		}
		case SMR_main_region_on_r1_running_RF_DataReceicved : {
			sMR_react_main_region_on_r1_running_RF_DataReceicved(handle);
			break;
		}
		case SMR_main_region_on_r1_running_keypad_CheckKey : {
			sMR_react_main_region_on_r1_running_keypad_CheckKey(handle);
			break;
		}
		case SMR_main_region_on_r1_running_keypad_CheckKeyDown : {
			sMR_react_main_region_on_r1_running_keypad_CheckKeyDown(handle);
			break;
		}
		case SMR_main_region_on_r1_running_UART_ShowMsg : {
			sMR_react_main_region_on_r1_running_UART_ShowMsg(handle);
			break;
		}
		case SMR_main_region_on_r1_running_UART_ShowNumber : {
			sMR_react_main_region_on_r1_running_UART_ShowNumber(handle);
			break;
		}
		case SMR_main_region_on_r1_running_UART_SendUART : {
			sMR_react_main_region_on_r1_running_UART_SendUART(handle);
			break;
		}
		case SMR_main_region_on_r1_running_UART_CheckKey : {
			sMR_react_main_region_on_r1_running_UART_CheckKey(handle);
			break;
		}
		default:
			break;
		}
	}
	
	clearInEvents(handle);
}

void sMR_raiseTimeEvent(SMR* handle, sc_eventid evid) {
	if ( ((intptr_t)evid) >= ((intptr_t)&(handle->timeEvents))
		&&  ((intptr_t)evid) < ((intptr_t)&(handle->timeEvents)) + sizeof(SMRTimeEvents)) {
		*(sc_boolean*)evid = bool_true;
	}		
}

sc_boolean sMR_isActive(SMR* handle, SMRStates state) {
	switch (state) {
		case SMR_main_region_on : 
			return (sc_boolean) (handle->stateConfVector[0] >= SMR_main_region_on
				&& handle->stateConfVector[0] <= SMR_main_region_on_r1_running_UART_CheckKey);
		case SMR_main_region_on_r1_Init : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_Init
			);
		case SMR_main_region_on_r1_running : 
			return (sc_boolean) (handle->stateConfVector[0] >= SMR_main_region_on_r1_running
				&& handle->stateConfVector[0] <= SMR_main_region_on_r1_running_UART_CheckKey);
		case SMR_main_region_on_r1_running_RF_GetData : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_running_RF_GetData
			);
		case SMR_main_region_on_r1_running_RF__final_ : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_running_RF__final_
			);
		case SMR_main_region_on_r1_running_RF_SendSuccessful : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_running_RF_SendSuccessful
			);
		case SMR_main_region_on_r1_running_RF_DataReceicved : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_running_RF_DataReceicved
			);
		case SMR_main_region_on_r1_running_keypad_CheckKey : 
			return (sc_boolean) (handle->stateConfVector[1] == SMR_main_region_on_r1_running_keypad_CheckKey
			);
		case SMR_main_region_on_r1_running_keypad_CheckKeyDown : 
			return (sc_boolean) (handle->stateConfVector[1] == SMR_main_region_on_r1_running_keypad_CheckKeyDown
			);
		case SMR_main_region_on_r1_running_UART_ShowMsg : 
			return (sc_boolean) (handle->stateConfVector[2] == SMR_main_region_on_r1_running_UART_ShowMsg
			);
		case SMR_main_region_on_r1_running_UART_ShowNumber : 
			return (sc_boolean) (handle->stateConfVector[2] == SMR_main_region_on_r1_running_UART_ShowNumber
			);
		case SMR_main_region_on_r1_running_UART_SendUART : 
			return (sc_boolean) (handle->stateConfVector[2] == SMR_main_region_on_r1_running_UART_SendUART
			);
		case SMR_main_region_on_r1_running_UART_CheckKey : 
			return (sc_boolean) (handle->stateConfVector[2] == SMR_main_region_on_r1_running_UART_CheckKey
			);
		default: return bool_false;
	}
}



void sMRIfaceKEYPAD_raise_key_pressed(SMR* handle) {
	handle->ifaceKEYPAD.key_pressed_raised = bool_true;
}


sc_integer sMRIfaceKEYPAD_get_key(SMR* handle) {
	return handle->ifaceKEYPAD.key;
}
void sMRIfaceKEYPAD_set_key(SMR* handle, sc_integer value) {
	handle->ifaceKEYPAD.key = value;
}
sc_integer sMRIfaceKEYPAD_get_lastkey(SMR* handle) {
	return handle->ifaceKEYPAD.lastkey;
}
void sMRIfaceKEYPAD_set_lastkey(SMR* handle, sc_integer value) {
	handle->ifaceKEYPAD.lastkey = value;
}
sc_boolean sMRIfaceKEYPAD_get_key_down(SMR* handle) {
	return handle->ifaceKEYPAD.key_down;
}
void sMRIfaceKEYPAD_set_key_down(SMR* handle, sc_boolean value) {
	handle->ifaceKEYPAD.key_down = value;
}
void sMRIfaceUART_raise_dataRecieved(SMR* handle) {
	handle->ifaceUART.DataRecieved_raised = bool_true;
}


sc_string sMRIfaceUART_get_data(SMR* handle) {
	return handle->ifaceUART.data;
}
void sMRIfaceUART_set_data(SMR* handle, sc_string value) {
	handle->ifaceUART.data = value;
}
sc_string sMRIfaceUART_get_lastdata(SMR* handle) {
	return handle->ifaceUART.lastdata;
}
void sMRIfaceUART_set_lastdata(SMR* handle, sc_string value) {
	handle->ifaceUART.lastdata = value;
}
void sMRIfaceRF_raise_dataRecieved(SMR* handle) {
	handle->ifaceRF.DataRecieved_raised = bool_true;
}


sc_string sMRIfaceRF_get_data(SMR* handle) {
	return handle->ifaceRF.data;
}
void sMRIfaceRF_set_data(SMR* handle, sc_string value) {
	handle->ifaceRF.data = value;
}
sc_string sMRIfaceRF_get_lastdata(SMR* handle) {
	return handle->ifaceRF.lastdata;
}
void sMRIfaceRF_set_lastdata(SMR* handle, sc_string value) {
	handle->ifaceRF.lastdata = value;
}
sc_boolean sMRIfaceRF_get_result(SMR* handle) {
	return handle->ifaceRF.result;
}
void sMRIfaceRF_set_result(SMR* handle, sc_boolean value) {
	handle->ifaceRF.result = value;
}
sc_integer sMRIfaceRF_get_retry(SMR* handle) {
	return handle->ifaceRF.retry;
}
void sMRIfaceRF_set_retry(SMR* handle, sc_integer value) {
	handle->ifaceRF.retry = value;
}
sc_integer sMRIfaceRF_get_iD(SMR* handle) {
	return handle->ifaceRF.ID;
}
void sMRIfaceRF_set_iD(SMR* handle, sc_integer value) {
	handle->ifaceRF.ID = value;
}


sc_integer sMRIfaceDISH_get_iD(SMR* handle) {
	return handle->ifaceDISH.ID;
}
void sMRIfaceDISH_set_iD(SMR* handle, sc_integer value) {
	handle->ifaceDISH.ID = value;
}
sc_integer sMRIfaceDISH_get_amount(SMR* handle) {
	return handle->ifaceDISH.amount;
}
void sMRIfaceDISH_set_amount(SMR* handle, sc_integer value) {
	handle->ifaceDISH.amount = value;
}
sc_integer sMRIfaceDISH_get_pos(SMR* handle) {
	return handle->ifaceDISH.pos;
}
void sMRIfaceDISH_set_pos(SMR* handle, sc_integer value) {
	handle->ifaceDISH.pos = value;
}
void sMRIface_raise_switchOff(SMR* handle) {
	handle->iface.switchOff_raised = bool_true;
}
void sMRIface_raise_switchOn(SMR* handle) {
	handle->iface.switchOn_raised = bool_true;
}


sc_boolean sMRIface_get_lightOn(SMR* handle) {
	return handle->iface.lightOn;
}
void sMRIface_set_lightOn(SMR* handle, sc_boolean value) {
	handle->iface.lightOn = value;
}
sc_integer sMRIface_get_menuId(SMR* handle) {
	return handle->iface.menuId;
}
void sMRIface_set_menuId(SMR* handle, sc_integer value) {
	handle->iface.menuId = value;
}
sc_integer sMRIface_get_tableId(SMR* handle) {
	return handle->iface.tableId;
}
void sMRIface_set_tableId(SMR* handle, sc_integer value) {
	handle->iface.tableId = value;
}
		
// implementations of all internal functions

/* Entry action for statechart 'SMR'. */
static void sMR_entryaction(SMR* handle) {
	/* Entry action for statechart 'SMR'. */
}

/* Exit action for state 'SMR'. */
static void sMR_exitaction(SMR* handle) {
	/* Exit action for state 'SMR'. */
}

/* The reactions of state Init. */
static void sMR_react_main_region_on_r1_Init(SMR* handle) {
	/* The reactions of state Init. */
	if (handle->timeEvents.Init_time_event_0_raised) { 
		/* Default exit sequence for state Init */
		handle->stateConfVector[0] = SMR_last_state;
		handle->stateConfVectorPosition = 0;
		/* Exit action for state 'Init'. */
		sMR_unsetTimer( (sc_eventid) &(handle->timeEvents.Init_time_event_0_raised) );		
		/* Default enter sequence for state running */
		/* Default enter sequence for region RF */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state GetData */
		/* Entry action for state 'GetData'. */
		handle->ifaceRF.data = sMRIfaceRF_getData();
		handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_GetData;
		handle->stateConfVectorPosition = 0;
		/* Default enter sequence for region keypad */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state CheckKey */
		/* Entry action for state 'CheckKey'. */
		handle->ifaceKEYPAD.key = sMRIfaceKEYPAD_checkpress();
		handle->ifaceKEYPAD.key_down = bool_false;
		handle->stateConfVector[1] = SMR_main_region_on_r1_running_keypad_CheckKey;
		handle->stateConfVectorPosition = 1;
		/* Default enter sequence for region UART */
		/* Default react sequence for initial entry  */
		/* Default enter sequence for state ShowMsg */
		/* Entry action for state 'ShowMsg'. */
		sMRIfaceLCD_clear();
		sMRIfaceLCD_writeString("_ _ _ _ _ _ _ _");
		handle->ifaceDISH.pos = 0;
		handle->stateConfVector[2] = SMR_main_region_on_r1_running_UART_ShowMsg;
		handle->stateConfVectorPosition = 2;
	} 
}

/* The reactions of state GetData. */
static void sMR_react_main_region_on_r1_running_RF_GetData(SMR* handle) {
	/* The reactions of state GetData. */
	if ((strcmp(handle->ifaceRF.data, "") == 0)
	) { 
		/* Default enter sequence for state GetData */
		/* Entry action for state 'GetData'. */
		handle->ifaceRF.data = sMRIfaceRF_getData();
		handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_GetData;
		handle->stateConfVectorPosition = 0;
	}  else {
		if ((strcmp(handle->ifaceRF.data, "") != 0)
		) { 
			/* Default exit sequence for state GetData */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			handle->ifaceRF.lastdata = handle->ifaceRF.data;
			/* Default enter sequence for state DataReceicved */
			/* Entry action for state 'DataReceicved'. */
			sMRIfaceLCD_clear();
			sMRIfaceLCD_writeString(handle->ifaceRF.lastdata);
			sMRIfaceUART_sendMsg(handle->ifaceRF.lastdata);
			handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_DataReceicved;
			handle->stateConfVectorPosition = 0;
		} 
	}
}

/* The reactions of state null. */
static void sMR_react_main_region_on_r1_running_RF__final_0(SMR* handle) {
	/* The reactions of state null. */
}

/* The reactions of state SendSuccessful. */
static void sMR_react_main_region_on_r1_running_RF_SendSuccessful(SMR* handle) {
	/* The reactions of state SendSuccessful. */
	if (handle->ifaceRF.result == bool_false) { 
		/* Default enter sequence for state SendSuccessful */
		/* Entry action for state 'SendSuccessful'. */
		handle->ifaceRF.result = sMRIfaceRF_sendCheck();
		handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_SendSuccessful;
		handle->stateConfVectorPosition = 0;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state SendSuccessful */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			/* Default enter sequence for state DataReceicved */
			/* Entry action for state 'DataReceicved'. */
			sMRIfaceLCD_clear();
			sMRIfaceLCD_writeString(handle->ifaceRF.lastdata);
			sMRIfaceUART_sendMsg(handle->ifaceRF.lastdata);
			handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_DataReceicved;
			handle->stateConfVectorPosition = 0;
		}  else {
			if (handle->ifaceRF.result == bool_true) { 
				/* Default exit sequence for state SendSuccessful */
				handle->stateConfVector[0] = SMR_last_state;
				handle->stateConfVectorPosition = 0;
				/* Default enter sequence for state GetData */
				/* Entry action for state 'GetData'. */
				handle->ifaceRF.data = sMRIfaceRF_getData();
				handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_GetData;
				handle->stateConfVectorPosition = 0;
			} 
		}
	}
}

/* The reactions of state DataReceicved. */
static void sMR_react_main_region_on_r1_running_RF_DataReceicved(SMR* handle) {
	/* The reactions of state DataReceicved. */
	if (bool_true) { 
		/* Default exit sequence for state DataReceicved */
		handle->stateConfVector[0] = SMR_last_state;
		handle->stateConfVectorPosition = 0;
		/* Default enter sequence for state null */
		handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF__final_;
		handle->stateConfVectorPosition = 0;
	}  else {
		if (bool_true) { 
			/* Default exit sequence for state DataReceicved */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			/* Default enter sequence for state SendUART */
			/* Entry action for state 'SendUART'. */
			sMRIfaceUART_sendTemp();
			handle->stateConfVector[2] = SMR_main_region_on_r1_running_UART_SendUART;
			handle->stateConfVectorPosition = 2;
		} 
	}
}

/* The reactions of state CheckKey. */
static void sMR_react_main_region_on_r1_running_keypad_CheckKey(SMR* handle) {
	/* The reactions of state CheckKey. */
	if (handle->ifaceKEYPAD.key != 0) { 
		/* Default exit sequence for state CheckKey */
		handle->stateConfVector[1] = SMR_last_state;
		handle->stateConfVectorPosition = 1;
		handle->ifaceKEYPAD.lastkey = handle->ifaceKEYPAD.key;
		/* Default enter sequence for state CheckKeyDown */
		/* Entry action for state 'CheckKeyDown'. */
		handle->ifaceKEYPAD.key = sMRIfaceKEYPAD_checkpress();
		handle->ifaceKEYPAD.key_down = bool_true;
		handle->stateConfVector[1] = SMR_main_region_on_r1_running_keypad_CheckKeyDown;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceKEYPAD.key == 0) { 
			/* Default enter sequence for state CheckKey */
			/* Entry action for state 'CheckKey'. */
			handle->ifaceKEYPAD.key = sMRIfaceKEYPAD_checkpress();
			handle->ifaceKEYPAD.key_down = bool_false;
			handle->stateConfVector[1] = SMR_main_region_on_r1_running_keypad_CheckKey;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state CheckKeyDown. */
static void sMR_react_main_region_on_r1_running_keypad_CheckKeyDown(SMR* handle) {
	/* The reactions of state CheckKeyDown. */
	if (handle->ifaceKEYPAD.key == 0) { 
		/* Default exit sequence for state CheckKeyDown */
		handle->stateConfVector[1] = SMR_last_state;
		handle->stateConfVectorPosition = 1;
		handle->ifaceKEYPAD.key_pressed_raised = bool_true;
		/* Default enter sequence for state CheckKey */
		/* Entry action for state 'CheckKey'. */
		handle->ifaceKEYPAD.key = sMRIfaceKEYPAD_checkpress();
		handle->ifaceKEYPAD.key_down = bool_false;
		handle->stateConfVector[1] = SMR_main_region_on_r1_running_keypad_CheckKey;
		handle->stateConfVectorPosition = 1;
	}  else {
		if (handle->ifaceKEYPAD.key != 0) { 
			/* Default enter sequence for state CheckKeyDown */
			/* Entry action for state 'CheckKeyDown'. */
			handle->ifaceKEYPAD.key = sMRIfaceKEYPAD_checkpress();
			handle->ifaceKEYPAD.key_down = bool_true;
			handle->stateConfVector[1] = SMR_main_region_on_r1_running_keypad_CheckKeyDown;
			handle->stateConfVectorPosition = 1;
		} 
	}
}

/* The reactions of state ShowMsg. */
static void sMR_react_main_region_on_r1_running_UART_ShowMsg(SMR* handle) {
	/* The reactions of state ShowMsg. */
	if (bool_true) { 
		/* Default exit sequence for state ShowMsg */
		handle->stateConfVector[2] = SMR_last_state;
		handle->stateConfVectorPosition = 2;
		/* Default enter sequence for state CheckKey */
		/* Entry action for state 'CheckKey'. */
		handle->ifaceKEYPAD.lastkey = 0;
		handle->stateConfVector[2] = SMR_main_region_on_r1_running_UART_CheckKey;
		handle->stateConfVectorPosition = 2;
	} 
}

/* The reactions of state ShowNumber. */
static void sMR_react_main_region_on_r1_running_UART_ShowNumber(SMR* handle) {
	/* The reactions of state ShowNumber. */
	if (bool_true) { 
		/* Default exit sequence for state ShowNumber */
		handle->stateConfVector[2] = SMR_last_state;
		handle->stateConfVectorPosition = 2;
		/* Default enter sequence for state CheckKey */
		/* Entry action for state 'CheckKey'. */
		handle->ifaceKEYPAD.lastkey = 0;
		handle->stateConfVector[2] = SMR_main_region_on_r1_running_UART_CheckKey;
		handle->stateConfVectorPosition = 2;
	} 
}

/* The reactions of state SendUART. */
static void sMR_react_main_region_on_r1_running_UART_SendUART(SMR* handle) {
	/* The reactions of state SendUART. */
	if (bool_true) { 
		/* Default exit sequence for state SendUART */
		handle->stateConfVector[2] = SMR_last_state;
		handle->stateConfVectorPosition = 2;
		/* Default enter sequence for state ShowMsg */
		/* Entry action for state 'ShowMsg'. */
		sMRIfaceLCD_clear();
		sMRIfaceLCD_writeString("_ _ _ _ _ _ _ _");
		handle->ifaceDISH.pos = 0;
		handle->stateConfVector[2] = SMR_main_region_on_r1_running_UART_ShowMsg;
		handle->stateConfVectorPosition = 2;
	} 
}

/* The reactions of state CheckKey. */
static void sMR_react_main_region_on_r1_running_UART_CheckKey(SMR* handle) {
	/* The reactions of state CheckKey. */
	if (handle->ifaceDISH.pos < 8 && handle->ifaceKEYPAD.lastkey == 10 && handle->ifaceKEYPAD.key_pressed_raised) { 
		/* Default exit sequence for state CheckKey */
		handle->stateConfVector[2] = SMR_last_state;
		handle->stateConfVectorPosition = 2;
		handle->ifaceKEYPAD.lastkey = 0;
		/* Default enter sequence for state ShowNumber */
		/* Entry action for state 'ShowNumber'. */
		sMRIfaceLCD_writeNumberXY(handle->ifaceKEYPAD.lastkey, handle->ifaceDISH.pos * 2, 0, 1);
		handle->ifaceDISH.pos += 1;
		sMRIface_convertNumber(handle->ifaceKEYPAD.lastkey, handle->ifaceDISH.pos);
		handle->stateConfVector[2] = SMR_main_region_on_r1_running_UART_ShowNumber;
		handle->stateConfVectorPosition = 2;
	}  else {
		if (handle->ifaceDISH.pos < 8 && handle->ifaceKEYPAD.lastkey <= 9 && handle->ifaceKEYPAD.lastkey >= 1 && handle->ifaceKEYPAD.key_pressed_raised) { 
			/* Default exit sequence for state CheckKey */
			handle->stateConfVector[2] = SMR_last_state;
			handle->stateConfVectorPosition = 2;
			/* Default enter sequence for state ShowNumber */
			/* Entry action for state 'ShowNumber'. */
			sMRIfaceLCD_writeNumberXY(handle->ifaceKEYPAD.lastkey, handle->ifaceDISH.pos * 2, 0, 1);
			handle->ifaceDISH.pos += 1;
			sMRIface_convertNumber(handle->ifaceKEYPAD.lastkey, handle->ifaceDISH.pos);
			handle->stateConfVector[2] = SMR_main_region_on_r1_running_UART_ShowNumber;
			handle->stateConfVectorPosition = 2;
		}  else {
			if (handle->ifaceKEYPAD.lastkey == 12 && handle->ifaceKEYPAD.key_pressed_raised) { 
				/* Default exit sequence for state CheckKey */
				handle->stateConfVector[2] = SMR_last_state;
				handle->stateConfVectorPosition = 2;
				/* Default enter sequence for state ShowMsg */
				/* Entry action for state 'ShowMsg'. */
				sMRIfaceLCD_clear();
				sMRIfaceLCD_writeString("_ _ _ _ _ _ _ _");
				handle->ifaceDISH.pos = 0;
				handle->stateConfVector[2] = SMR_main_region_on_r1_running_UART_ShowMsg;
				handle->stateConfVectorPosition = 2;
			}  else {
				if (handle->ifaceKEYPAD.lastkey == 11 && handle->ifaceKEYPAD.key_pressed_raised) { 
					/* Default exit sequence for state CheckKey */
					handle->stateConfVector[2] = SMR_last_state;
					handle->stateConfVectorPosition = 2;
					/* Default enter sequence for state SendUART */
					/* Entry action for state 'SendUART'. */
					sMRIfaceUART_sendTemp();
					handle->stateConfVector[2] = SMR_main_region_on_r1_running_UART_SendUART;
					handle->stateConfVectorPosition = 2;
				} 
			}
		}
	}
}


