#ifndef SMR_H_
#define SMR_H_

#include "sc_types.h"

#ifdef __cplusplus
extern "C" { 
#endif 

/*! \file Header of the state machine 'SMR'.
*/

//! enumeration of all states 
typedef enum {
	SMR_main_region_on ,
	SMR_main_region_on_r1_Init ,
	SMR_main_region_on_r1_running ,
	SMR_main_region_on_r1_running_RF_GetReady ,
	SMR_main_region_on_r1_running_RF_GetData ,
	SMR_main_region_on_r1_running_RF__final_ ,
	SMR_main_region_on_r1_running_RF_SendSuccessful ,
	SMR_main_region_on_r1_running_RF_DataReceicved ,
	SMR_main_region_on_r1_running_keypad_CheckKey ,
	SMR_main_region_on_r1_running_keypad_CheckKeyDown ,
	SMR_main_region_on_r1_running_UART_ShowMsg ,
	SMR_main_region_on_r1_running_UART_ShowNumber ,
	SMR_main_region_on_r1_running_UART_SendUART ,
	SMR_main_region_on_r1_running_UART_CheckKey ,
	SMR_last_state
} SMRStates;

//! Type definition of the data structure for the SMRIfaceLCD interface scope.
typedef struct {
} SMRIfaceLCD;

//! Type definition of the data structure for the SMRIfaceKEYPAD interface scope.
typedef struct {
	sc_integer  key;
	sc_integer  lastkey;
	sc_boolean  key_down;
	sc_boolean key_pressed_raised;
} SMRIfaceKEYPAD;

//! Type definition of the data structure for the SMRIfaceUART interface scope.
typedef struct {
	sc_string  data;
	sc_string  lastdata;
	sc_boolean DataRecieved_raised;
} SMRIfaceUART;

//! Type definition of the data structure for the SMRIfaceRF interface scope.
typedef struct {
	sc_string  data;
	sc_string  lastdata;
	sc_boolean  result;
	sc_integer  retry;
	sc_integer  ID;
	sc_boolean DataRecieved_raised;
} SMRIfaceRF;

//! Type definition of the data structure for the SMRIfaceDISH interface scope.
typedef struct {
	sc_integer  ID;
	sc_integer  amount;
	sc_integer  pos;
} SMRIfaceDISH;

//! Type definition of the data structure for the SMRIface interface scope.
typedef struct {
	sc_boolean  lightOn;
	sc_integer  menuId;
	sc_integer  tableId;
	sc_boolean switchOff_raised;
	sc_boolean switchOn_raised;
} SMRIface;

//! Type definition of the data structure for the SMRTimeEvents interface scope.
typedef struct {
	sc_boolean Init_time_event_0_raised;
} SMRTimeEvents;


//! the maximum number of orthogonal states defines the dimension of the state configuration vector.
#define SMR_MAX_ORTHOGONAL_STATES 3

/*! Type definition of the data structure for the SMR state machine.
This data structure has to be allocated by the client code. */
typedef struct {
	SMRStates stateConfVector[SMR_MAX_ORTHOGONAL_STATES];
	sc_ushort stateConfVectorPosition; 
	
	SMRIfaceLCD ifaceLCD;
	SMRIfaceKEYPAD ifaceKEYPAD;
	SMRIfaceUART ifaceUART;
	SMRIfaceRF ifaceRF;
	SMRIfaceDISH ifaceDISH;
	SMRIface iface;
	SMRTimeEvents timeEvents;
} SMR;

/*! Initializes the SMR state machine data structures. Must be called before first usage.*/
extern void sMR_init(SMR* handle);

/*! Activates the state machine */
extern void sMR_enter(SMR* handle);

/*! Deactivates the state machine */
extern void sMR_exit(SMR* handle);

/*! Performs a 'run to completion' step. */
extern void sMR_runCycle(SMR* handle);

/*! Raises a time event. */
extern void sMR_raiseTimeEvent(SMR* handle, sc_eventid evid);


/*! Gets the value of the variable 'key' that is defined in the interface scope 'KEYPAD'. */ 
extern sc_integer sMRIfaceKEYPAD_get_key(SMR* handle);
/*! Sets the value of the variable 'key' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMRIfaceKEYPAD_set_key(SMR* handle, sc_integer value);
/*! Gets the value of the variable 'lastkey' that is defined in the interface scope 'KEYPAD'. */ 
extern sc_integer sMRIfaceKEYPAD_get_lastkey(SMR* handle);
/*! Sets the value of the variable 'lastkey' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMRIfaceKEYPAD_set_lastkey(SMR* handle, sc_integer value);
/*! Gets the value of the variable 'key_down' that is defined in the interface scope 'KEYPAD'. */ 
extern sc_boolean sMRIfaceKEYPAD_get_key_down(SMR* handle);
/*! Sets the value of the variable 'key_down' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMRIfaceKEYPAD_set_key_down(SMR* handle, sc_boolean value);
/*! Raises the in event 'key_pressed' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMRIfaceKEYPAD_raise_key_pressed(SMR* handle);


/*! Gets the value of the variable 'data' that is defined in the interface scope 'UART'. */ 
extern sc_string sMRIfaceUART_get_data(SMR* handle);
/*! Sets the value of the variable 'data' that is defined in the interface scope 'UART'. */ 
extern void sMRIfaceUART_set_data(SMR* handle, sc_string value);
/*! Gets the value of the variable 'lastdata' that is defined in the interface scope 'UART'. */ 
extern sc_string sMRIfaceUART_get_lastdata(SMR* handle);
/*! Sets the value of the variable 'lastdata' that is defined in the interface scope 'UART'. */ 
extern void sMRIfaceUART_set_lastdata(SMR* handle, sc_string value);
/*! Raises the in event 'DataRecieved' that is defined in the interface scope 'UART'. */ 
extern void sMRIfaceUART_raise_dataRecieved(SMR* handle);


/*! Gets the value of the variable 'data' that is defined in the interface scope 'RF'. */ 
extern sc_string sMRIfaceRF_get_data(SMR* handle);
/*! Sets the value of the variable 'data' that is defined in the interface scope 'RF'. */ 
extern void sMRIfaceRF_set_data(SMR* handle, sc_string value);
/*! Gets the value of the variable 'lastdata' that is defined in the interface scope 'RF'. */ 
extern sc_string sMRIfaceRF_get_lastdata(SMR* handle);
/*! Sets the value of the variable 'lastdata' that is defined in the interface scope 'RF'. */ 
extern void sMRIfaceRF_set_lastdata(SMR* handle, sc_string value);
/*! Gets the value of the variable 'result' that is defined in the interface scope 'RF'. */ 
extern sc_boolean sMRIfaceRF_get_result(SMR* handle);
/*! Sets the value of the variable 'result' that is defined in the interface scope 'RF'. */ 
extern void sMRIfaceRF_set_result(SMR* handle, sc_boolean value);
/*! Gets the value of the variable 'retry' that is defined in the interface scope 'RF'. */ 
extern sc_integer sMRIfaceRF_get_retry(SMR* handle);
/*! Sets the value of the variable 'retry' that is defined in the interface scope 'RF'. */ 
extern void sMRIfaceRF_set_retry(SMR* handle, sc_integer value);
/*! Gets the value of the variable 'ID' that is defined in the interface scope 'RF'. */ 
extern sc_integer sMRIfaceRF_get_iD(SMR* handle);
/*! Sets the value of the variable 'ID' that is defined in the interface scope 'RF'. */ 
extern void sMRIfaceRF_set_iD(SMR* handle, sc_integer value);
/*! Raises the in event 'DataRecieved' that is defined in the interface scope 'RF'. */ 
extern void sMRIfaceRF_raise_dataRecieved(SMR* handle);


/*! Gets the value of the variable 'ID' that is defined in the interface scope 'DISH'. */ 
extern sc_integer sMRIfaceDISH_get_iD(SMR* handle);
/*! Sets the value of the variable 'ID' that is defined in the interface scope 'DISH'. */ 
extern void sMRIfaceDISH_set_iD(SMR* handle, sc_integer value);
/*! Gets the value of the variable 'amount' that is defined in the interface scope 'DISH'. */ 
extern sc_integer sMRIfaceDISH_get_amount(SMR* handle);
/*! Sets the value of the variable 'amount' that is defined in the interface scope 'DISH'. */ 
extern void sMRIfaceDISH_set_amount(SMR* handle, sc_integer value);
/*! Gets the value of the variable 'pos' that is defined in the interface scope 'DISH'. */ 
extern sc_integer sMRIfaceDISH_get_pos(SMR* handle);
/*! Sets the value of the variable 'pos' that is defined in the interface scope 'DISH'. */ 
extern void sMRIfaceDISH_set_pos(SMR* handle, sc_integer value);

/*! Gets the value of the variable 'lightOn' that is defined in the default interface scope. */ 
extern sc_boolean sMRIface_get_lightOn(SMR* handle);
/*! Sets the value of the variable 'lightOn' that is defined in the default interface scope. */ 
extern void sMRIface_set_lightOn(SMR* handle, sc_boolean value);
/*! Gets the value of the variable 'menuId' that is defined in the default interface scope. */ 
extern sc_integer sMRIface_get_menuId(SMR* handle);
/*! Sets the value of the variable 'menuId' that is defined in the default interface scope. */ 
extern void sMRIface_set_menuId(SMR* handle, sc_integer value);
/*! Gets the value of the variable 'tableId' that is defined in the default interface scope. */ 
extern sc_integer sMRIface_get_tableId(SMR* handle);
/*! Sets the value of the variable 'tableId' that is defined in the default interface scope. */ 
extern void sMRIface_set_tableId(SMR* handle, sc_integer value);
/*! Raises the in event 'switchOff' that is defined in the default interface scope. */ 
extern void sMRIface_raise_switchOff(SMR* handle);

/*! Raises the in event 'switchOn' that is defined in the default interface scope. */ 
extern void sMRIface_raise_switchOn(SMR* handle);



/*! Checks if the specified state is active. */
extern sc_boolean sMR_isActive(SMR* handle, SMRStates state);

#ifdef __cplusplus
}
#endif 

#endif /* SMR_H_ */
