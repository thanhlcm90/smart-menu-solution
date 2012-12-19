#ifndef SMC_H_
#define SMC_H_

#include "sc_types.h"

#ifdef __cplusplus
extern "C" { 
#endif 

/*! \file Header of the state machine 'SMC'.
*/

//! enumeration of all states 
typedef enum {
	SMC_main_region_On ,
	SMC_main_region_On_r1_Init ,
	SMC_main_region_On_r1_Running ,
	SMC_main_region_On_r1_Running_keypad_CheckKey ,
	SMC_main_region_On_r1_Running_keypad_CheckKeyDown ,
	SMC_main_region_On_r1_Running_running_main_WaitingForRequest ,
	SMC_main_region_On_r1_Running_running_main_CheckKeyPress ,
	SMC_main_region_On_r1_Running_running_main_FinishDish ,
	SMC_main_region_On_r1_Running_running_main_CancelDish ,
	SMC_main_region_On_r1_Running_running_main_Send_Request ,
	SMC_main_region_On_r1_Running_running_main_Send_Request_send_Send ,
	SMC_main_region_On_r1_Running_running_main_Send_Request_send_Check ,
	SMC_main_region_On_r1_Running_running_main_Send_Request_send_SendFail ,
	SMC_main_region_On_r1_Running_running_main_Send_Request_send_ResetResult ,
	SMC_main_region_On_r1_Running_running_main_Send_Request_send__final_ ,
	SMC_main_region_On_r1_Running_running_main_CheckKeyPress1 ,
	SMC_last_state
} SMCStates;

//! Type definition of the data structure for the SMCIfaceLCD interface scope.
typedef struct {
} SMCIfaceLCD;

//! Type definition of the data structure for the SMCIfaceKEYPAD interface scope.
typedef struct {
	sc_integer  key;
	sc_integer  lastkey;
	sc_boolean  key_down;
	sc_boolean key_pressed_raised;
} SMCIfaceKEYPAD;

//! Type definition of the data structure for the SMCIfaceUART interface scope.
typedef struct {
	sc_string  data;
	sc_string  lastdata;
	sc_boolean DataRecieved_raised;
} SMCIfaceUART;

//! Type definition of the data structure for the SMCIfaceRF interface scope.
typedef struct {
	sc_string  data;
	sc_string  lastdata;
	sc_boolean  result;
	sc_boolean  resultCheck;
	sc_integer  retry;
	sc_integer  retryCheck;
	sc_integer  ID;
	sc_boolean DataRecieved_raised;
} SMCIfaceRF;

//! Type definition of the data structure for the SMCIfaceDISH interface scope.
typedef struct {
	sc_integer  ID;
	sc_integer  amount;
	sc_integer  pos;
} SMCIfaceDISH;

//! Type definition of the data structure for the SMCIface interface scope.
typedef struct {
	sc_boolean  lightOn;
	sc_integer  menuId;
	sc_integer  tableId;
	sc_integer  requestId;
	sc_integer  listId;
	sc_boolean switchOff_raised;
	sc_boolean switchOn_raised;
} SMCIface;

//! Type definition of the data structure for the SMCTimeEvents interface scope.
typedef struct {
	sc_boolean SendFail_time_event_0_raised;
} SMCTimeEvents;


//! the maximum number of orthogonal states defines the dimension of the state configuration vector.
#define SMC_MAX_ORTHOGONAL_STATES 2

/*! Type definition of the data structure for the SMC state machine.
This data structure has to be allocated by the client code. */
typedef struct {
	SMCStates stateConfVector[SMC_MAX_ORTHOGONAL_STATES];
	sc_ushort stateConfVectorPosition; 
	
	SMCIfaceLCD ifaceLCD;
	SMCIfaceKEYPAD ifaceKEYPAD;
	SMCIfaceUART ifaceUART;
	SMCIfaceRF ifaceRF;
	SMCIfaceDISH ifaceDISH;
	SMCIface iface;
	SMCTimeEvents timeEvents;
} SMC;

/*! Initializes the SMC state machine data structures. Must be called before first usage.*/
extern void sMC_init(SMC* handle);

/*! Activates the state machine */
extern void sMC_enter(SMC* handle);

/*! Deactivates the state machine */
extern void sMC_exit(SMC* handle);

/*! Performs a 'run to completion' step. */
extern void sMC_runCycle(SMC* handle);

/*! Raises a time event. */
extern void sMC_raiseTimeEvent(SMC* handle, sc_eventid evid);


/*! Gets the value of the variable 'key' that is defined in the interface scope 'KEYPAD'. */ 
extern sc_integer sMCIfaceKEYPAD_get_key(SMC* handle);
/*! Sets the value of the variable 'key' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMCIfaceKEYPAD_set_key(SMC* handle, sc_integer value);
/*! Gets the value of the variable 'lastkey' that is defined in the interface scope 'KEYPAD'. */ 
extern sc_integer sMCIfaceKEYPAD_get_lastkey(SMC* handle);
/*! Sets the value of the variable 'lastkey' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMCIfaceKEYPAD_set_lastkey(SMC* handle, sc_integer value);
/*! Gets the value of the variable 'key_down' that is defined in the interface scope 'KEYPAD'. */ 
extern sc_boolean sMCIfaceKEYPAD_get_key_down(SMC* handle);
/*! Sets the value of the variable 'key_down' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMCIfaceKEYPAD_set_key_down(SMC* handle, sc_boolean value);
/*! Raises the in event 'key_pressed' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMCIfaceKEYPAD_raise_key_pressed(SMC* handle);


/*! Gets the value of the variable 'data' that is defined in the interface scope 'UART'. */ 
extern sc_string sMCIfaceUART_get_data(SMC* handle);
/*! Sets the value of the variable 'data' that is defined in the interface scope 'UART'. */ 
extern void sMCIfaceUART_set_data(SMC* handle, sc_string value);
/*! Gets the value of the variable 'lastdata' that is defined in the interface scope 'UART'. */ 
extern sc_string sMCIfaceUART_get_lastdata(SMC* handle);
/*! Sets the value of the variable 'lastdata' that is defined in the interface scope 'UART'. */ 
extern void sMCIfaceUART_set_lastdata(SMC* handle, sc_string value);
/*! Raises the in event 'DataRecieved' that is defined in the interface scope 'UART'. */ 
extern void sMCIfaceUART_raise_dataRecieved(SMC* handle);


/*! Gets the value of the variable 'data' that is defined in the interface scope 'RF'. */ 
extern sc_string sMCIfaceRF_get_data(SMC* handle);
/*! Sets the value of the variable 'data' that is defined in the interface scope 'RF'. */ 
extern void sMCIfaceRF_set_data(SMC* handle, sc_string value);
/*! Gets the value of the variable 'lastdata' that is defined in the interface scope 'RF'. */ 
extern sc_string sMCIfaceRF_get_lastdata(SMC* handle);
/*! Sets the value of the variable 'lastdata' that is defined in the interface scope 'RF'. */ 
extern void sMCIfaceRF_set_lastdata(SMC* handle, sc_string value);
/*! Gets the value of the variable 'result' that is defined in the interface scope 'RF'. */ 
extern sc_boolean sMCIfaceRF_get_result(SMC* handle);
/*! Sets the value of the variable 'result' that is defined in the interface scope 'RF'. */ 
extern void sMCIfaceRF_set_result(SMC* handle, sc_boolean value);
/*! Gets the value of the variable 'resultCheck' that is defined in the interface scope 'RF'. */ 
extern sc_boolean sMCIfaceRF_get_resultCheck(SMC* handle);
/*! Sets the value of the variable 'resultCheck' that is defined in the interface scope 'RF'. */ 
extern void sMCIfaceRF_set_resultCheck(SMC* handle, sc_boolean value);
/*! Gets the value of the variable 'retry' that is defined in the interface scope 'RF'. */ 
extern sc_integer sMCIfaceRF_get_retry(SMC* handle);
/*! Sets the value of the variable 'retry' that is defined in the interface scope 'RF'. */ 
extern void sMCIfaceRF_set_retry(SMC* handle, sc_integer value);
/*! Gets the value of the variable 'retryCheck' that is defined in the interface scope 'RF'. */ 
extern sc_integer sMCIfaceRF_get_retryCheck(SMC* handle);
/*! Sets the value of the variable 'retryCheck' that is defined in the interface scope 'RF'. */ 
extern void sMCIfaceRF_set_retryCheck(SMC* handle, sc_integer value);
/*! Gets the value of the variable 'ID' that is defined in the interface scope 'RF'. */ 
extern sc_integer sMCIfaceRF_get_iD(SMC* handle);
/*! Sets the value of the variable 'ID' that is defined in the interface scope 'RF'. */ 
extern void sMCIfaceRF_set_iD(SMC* handle, sc_integer value);
/*! Raises the in event 'DataRecieved' that is defined in the interface scope 'RF'. */ 
extern void sMCIfaceRF_raise_dataRecieved(SMC* handle);


/*! Gets the value of the variable 'ID' that is defined in the interface scope 'DISH'. */ 
extern sc_integer sMCIfaceDISH_get_iD(SMC* handle);
/*! Sets the value of the variable 'ID' that is defined in the interface scope 'DISH'. */ 
extern void sMCIfaceDISH_set_iD(SMC* handle, sc_integer value);
/*! Gets the value of the variable 'amount' that is defined in the interface scope 'DISH'. */ 
extern sc_integer sMCIfaceDISH_get_amount(SMC* handle);
/*! Sets the value of the variable 'amount' that is defined in the interface scope 'DISH'. */ 
extern void sMCIfaceDISH_set_amount(SMC* handle, sc_integer value);
/*! Gets the value of the variable 'pos' that is defined in the interface scope 'DISH'. */ 
extern sc_integer sMCIfaceDISH_get_pos(SMC* handle);
/*! Sets the value of the variable 'pos' that is defined in the interface scope 'DISH'. */ 
extern void sMCIfaceDISH_set_pos(SMC* handle, sc_integer value);

/*! Gets the value of the variable 'lightOn' that is defined in the default interface scope. */ 
extern sc_boolean sMCIface_get_lightOn(SMC* handle);
/*! Sets the value of the variable 'lightOn' that is defined in the default interface scope. */ 
extern void sMCIface_set_lightOn(SMC* handle, sc_boolean value);
/*! Gets the value of the variable 'menuId' that is defined in the default interface scope. */ 
extern sc_integer sMCIface_get_menuId(SMC* handle);
/*! Sets the value of the variable 'menuId' that is defined in the default interface scope. */ 
extern void sMCIface_set_menuId(SMC* handle, sc_integer value);
/*! Gets the value of the variable 'tableId' that is defined in the default interface scope. */ 
extern sc_integer sMCIface_get_tableId(SMC* handle);
/*! Sets the value of the variable 'tableId' that is defined in the default interface scope. */ 
extern void sMCIface_set_tableId(SMC* handle, sc_integer value);
/*! Gets the value of the variable 'requestId' that is defined in the default interface scope. */ 
extern sc_integer sMCIface_get_requestId(SMC* handle);
/*! Sets the value of the variable 'requestId' that is defined in the default interface scope. */ 
extern void sMCIface_set_requestId(SMC* handle, sc_integer value);
/*! Gets the value of the variable 'listId' that is defined in the default interface scope. */ 
extern sc_integer sMCIface_get_listId(SMC* handle);
/*! Sets the value of the variable 'listId' that is defined in the default interface scope. */ 
extern void sMCIface_set_listId(SMC* handle, sc_integer value);
/*! Raises the in event 'switchOff' that is defined in the default interface scope. */ 
extern void sMCIface_raise_switchOff(SMC* handle);

/*! Raises the in event 'switchOn' that is defined in the default interface scope. */ 
extern void sMCIface_raise_switchOn(SMC* handle);



/*! Checks if the specified state is active. */
extern sc_boolean sMC_isActive(SMC* handle, SMCStates state);

#ifdef __cplusplus
}
#endif 

#endif /* SMC_H_ */
