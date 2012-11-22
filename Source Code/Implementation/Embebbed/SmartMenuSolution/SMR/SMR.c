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
static void sMR_react_main_region_on_r1_running_RF_Ready(SMR* handle);
static void sMR_react_main_region_on_r1_running_RF_GetData(SMR* handle);
static void sMR_react_main_region_on_r1_running_RF_DataRecieved(SMR* handle);
static void sMR_react_main_region_on_r1_running_RF_SendSuccess(SMR* handle);
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
	sMRIfaceRF_init();
	sMRIfaceUART_init();
	sMRIfaceLCD_clear();
	sMRIfaceLCD_writeString("Waitting...");
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
		case SMR_main_region_on_r1_running_RF_Ready : {
			/* Default exit sequence for state Ready */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		case SMR_main_region_on_r1_running_RF_GetData : {
			/* Default exit sequence for state GetData */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		case SMR_main_region_on_r1_running_RF_DataRecieved : {
			/* Default exit sequence for state DataRecieved */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
			break;
		}
		case SMR_main_region_on_r1_running_RF_SendSuccess : {
			/* Default exit sequence for state SendSuccess */
			handle->stateConfVector[0] = SMR_last_state;
			handle->stateConfVectorPosition = 0;
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
		case SMR_main_region_on_r1_running_RF_Ready : {
			sMR_react_main_region_on_r1_running_RF_Ready(handle);
			break;
		}
		case SMR_main_region_on_r1_running_RF_GetData : {
			sMR_react_main_region_on_r1_running_RF_GetData(handle);
			break;
		}
		case SMR_main_region_on_r1_running_RF_DataRecieved : {
			sMR_react_main_region_on_r1_running_RF_DataRecieved(handle);
			break;
		}
		case SMR_main_region_on_r1_running_RF_SendSuccess : {
			sMR_react_main_region_on_r1_running_RF_SendSuccess(handle);
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
				&& handle->stateConfVector[0] <= SMR_main_region_on_r1_running_RF_SendSuccess);
		case SMR_main_region_on_r1_Init : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_Init
			);
		case SMR_main_region_on_r1_running : 
			return (sc_boolean) (handle->stateConfVector[0] >= SMR_main_region_on_r1_running
				&& handle->stateConfVector[0] <= SMR_main_region_on_r1_running_RF_SendSuccess);
		case SMR_main_region_on_r1_running_RF_Ready : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_running_RF_Ready
			);
		case SMR_main_region_on_r1_running_RF_GetData : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_running_RF_GetData
			);
		case SMR_main_region_on_r1_running_RF_DataRecieved : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_running_RF_DataRecieved
			);
		case SMR_main_region_on_r1_running_RF_SendSuccess : 
			return (sc_boolean) (handle->stateConfVector[0] == SMR_main_region_on_r1_running_RF_SendSuccess
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
		/* Default enter sequence for state Ready */
		/* Entry action for state 'Ready'. */
		sMRIfaceLCD_clear();
		sMRIfaceLCD_writeString("Waiting for data");
		handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_Ready;
		handle->stateConfVectorPosition = 0;
	} 
}

/* The reactions of state Ready. */
static void sMR_react_main_region_on_r1_running_RF_Ready(SMR* handle) {
	/* The reactions of state Ready. */
	if (bool_true) { 
		/* Default exit sequence for state Ready */
		handle->stateConfVector[0] = SMR_last_state;
		handle->stateConfVectorPosition = 0;
		/* Default enter sequence for state GetData */
		/* Entry action for state 'GetData'. */
		handle->ifaceRF.data = sMRIfaceRF_getData();
		handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_GetData;
		handle->stateConfVectorPosition = 0;
	} 
}

/* The reactions of state GetData. */
static void sMR_react_main_region_on_r1_running_RF_GetData(SMR* handle) {
	/* The reactions of state GetData. */
	if ((strcmp(handle->ifaceRF.data, "") != 0)
	) { 
		/* Default exit sequence for state GetData */
		handle->stateConfVector[0] = SMR_last_state;
		handle->stateConfVectorPosition = 0;
		handle->ifaceRF.lastdata = handle->ifaceRF.data;
		/* Default enter sequence for state DataRecieved */
		/* Entry action for state 'DataRecieved'. */
		sMRIfaceLCD_clear();
		sMRIfaceLCD_writeString(handle->ifaceRF.lastdata);
		sMRIfaceUART_sendData(handle->ifaceRF.lastdata);
		handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_DataRecieved;
		handle->stateConfVectorPosition = 0;
	}  else {
		if ((strcmp(handle->ifaceRF.data, "") == 0)
		) { 
			/* Default enter sequence for state GetData */
			/* Entry action for state 'GetData'. */
			handle->ifaceRF.data = sMRIfaceRF_getData();
			handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_GetData;
			handle->stateConfVectorPosition = 0;
		} 
	}
}

/* The reactions of state DataRecieved. */
static void sMR_react_main_region_on_r1_running_RF_DataRecieved(SMR* handle) {
	/* The reactions of state DataRecieved. */
	if (bool_true) { 
		/* Default exit sequence for state DataRecieved */
		handle->stateConfVector[0] = SMR_last_state;
		handle->stateConfVectorPosition = 0;
		/* Default enter sequence for state SendSuccess */
		/* Entry action for state 'SendSuccess'. */
		handle->ifaceRF.result = sMRIfaceRF_sendCheck();
		handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_SendSuccess;
		handle->stateConfVectorPosition = 0;
	} 
}

/* The reactions of state SendSuccess. */
static void sMR_react_main_region_on_r1_running_RF_SendSuccess(SMR* handle) {
	/* The reactions of state SendSuccess. */
	if (handle->ifaceRF.result == bool_true) { 
		/* Default exit sequence for state SendSuccess */
		handle->stateConfVector[0] = SMR_last_state;
		handle->stateConfVectorPosition = 0;
		/* Default enter sequence for state GetData */
		/* Entry action for state 'GetData'. */
		handle->ifaceRF.data = sMRIfaceRF_getData();
		handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_GetData;
		handle->stateConfVectorPosition = 0;
	}  else {
		if (handle->ifaceRF.result == bool_false) { 
			/* Default enter sequence for state SendSuccess */
			/* Entry action for state 'SendSuccess'. */
			handle->ifaceRF.result = sMRIfaceRF_sendCheck();
			handle->stateConfVector[0] = SMR_main_region_on_r1_running_RF_SendSuccess;
			handle->stateConfVectorPosition = 0;
		} 
	}
}


