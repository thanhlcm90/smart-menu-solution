#ifndef SMO_H_
#define SMO_H_

#include "sc_types.h"

#ifdef __cplusplus
extern "C" { 
#endif 

/*! \file Header of the state machine 'SMO'.
*/

//! enumeration of all states 
typedef enum {
	SMO_main_region_on ,
	SMO_main_region_on_r1_Init ,
	SMO_main_region_on_r1_Running ,
	SMO_main_region_on_r1_Running_keypad_CheckKey ,
	SMO_main_region_on_r1_Running_keypad_CheckKeyDown ,
	SMO_main_region_on_r1_Running_running_main_ShowMenu ,
	SMO_main_region_on_r1_Running_running_main_EnterData ,
	SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowCode ,
	SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterCode ,
	SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress1 ,
	SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckCode0 ,
	SMO_main_region_on_r1_Running_running_main_EnterData_r1_ShowAmount ,
	SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckKeyPress2 ,
	SMO_main_region_on_r1_Running_running_main_EnterData_r1_CheckAmount0 ,
	SMO_main_region_on_r1_Running_running_main_EnterData_r1_EnterAmount ,
	SMO_main_region_on_r1_Running_running_main_EnterData_r1__final_ ,
	SMO_main_region_on_r1_Running_running_main_MenuA ,
	SMO_main_region_on_r1_Running_running_main_CheckKeyPress ,
	SMO_main_region_on_r1_Running_running_main_SendData ,
	SMO_main_region_on_r1_Running_running_main_SendData_r1_Send ,
	SMO_main_region_on_r1_Running_running_main_SendData_r1_Check ,
	SMO_main_region_on_r1_Running_running_main_SendData_r1__final_ ,
	SMO_main_region_on_r1_Running_running_main_SendData_r1_SendFail1 ,
	SMO_main_region_on_r1_Running_running_main_SendData_r1_ResetResult ,
	SMO_main_region_on_r1_Running_running_main_MenuB ,
	SMO_main_region_on_r1_Running_running_main_MenuC ,
	SMO_main_region_on_r1_Running_running_main_MenuD ,
	SMO_main_region_on_r1_Running_running_main_ConfirmRequest ,
	SMO_main_region_on_r1_Running_running_main_ConfirmRequest_r1_RequestConfirmation ,
	SMO_main_region_on_r1_Running_running_main_ConfirmRequest_r1_Confirm ,
	SMO_main_region_on_r1_Running_running_main_ConfirmRequest_r1_CheckKeyPress ,
	SMO_main_region_on_r1_Running_running_main_ConfirmRequest_r1__final_ ,
	SMO_main_region_on_r1_Running_running_main_SendRequest ,
	SMO_main_region_on_r1_Running_running_main_SendRequest_r1_Send ,
	SMO_main_region_on_r1_Running_running_main_SendRequest_r1_Check ,
	SMO_main_region_on_r1_Running_running_main_SendRequest_r1__final_ ,
	SMO_main_region_on_r1_Running_running_main_SendRequest_r1_SendFail2 ,
	SMO_main_region_on_r1_Running_running_main_SendRequest_r1_ResetResult ,
	SMO_last_state
} SMOStates;

//! Type definition of the data structure for the SMOIfaceLCD interface scope.
typedef struct {
} SMOIfaceLCD;

//! Type definition of the data structure for the SMOIfaceKEYPAD interface scope.
typedef struct {
	sc_integer  key;
	sc_integer  lastkey;
	sc_boolean  key_down;
	sc_boolean key_pressed_raised;
} SMOIfaceKEYPAD;

//! Type definition of the data structure for the SMOIfaceUART interface scope.
typedef struct {
	sc_string  data;
	sc_string  lastdata;
	sc_boolean DataRecieved_raised;
} SMOIfaceUART;

//! Type definition of the data structure for the SMOIfaceRF interface scope.
typedef struct {
	sc_string  data;
	sc_string  lastdata;
	sc_boolean  result;
	sc_integer  retry;
	sc_integer  ID;
	sc_boolean DataRecieved_raised;
} SMOIfaceRF;

//! Type definition of the data structure for the SMOIfaceDISH interface scope.
typedef struct {
	sc_integer  ID;
	sc_integer  amount;
	sc_integer  pos;
} SMOIfaceDISH;

//! Type definition of the data structure for the SMOIface interface scope.
typedef struct {
	sc_boolean  lightOn;
	sc_integer  menuId;
	sc_integer  tableId;
	sc_integer  confirmId;
	sc_boolean switchOff_raised;
	sc_boolean switchOn_raised;
} SMOIface;

//! Type definition of the data structure for the SMOTimeEvents interface scope.
typedef struct {
	sc_boolean Init_time_event_0_raised;
	sc_boolean SendFail1_time_event_0_raised;
	sc_boolean Confirm_time_event_0_raised;
	sc_boolean SendFail2_time_event_0_raised;
} SMOTimeEvents;


//! the maximum number of orthogonal states defines the dimension of the state configuration vector.
#define SMO_MAX_ORTHOGONAL_STATES 2

/*! Type definition of the data structure for the SMO state machine.
This data structure has to be allocated by the client code. */
typedef struct {
	SMOStates stateConfVector[SMO_MAX_ORTHOGONAL_STATES];
	sc_ushort stateConfVectorPosition; 
	
	SMOIfaceLCD ifaceLCD;
	SMOIfaceKEYPAD ifaceKEYPAD;
	SMOIfaceUART ifaceUART;
	SMOIfaceRF ifaceRF;
	SMOIfaceDISH ifaceDISH;
	SMOIface iface;
	SMOTimeEvents timeEvents;
} SMO;

/*! Initializes the SMO state machine data structures. Must be called before first usage.*/
extern void sMO_init(SMO* handle);

/*! Activates the state machine */
extern void sMO_enter(SMO* handle);

/*! Deactivates the state machine */
extern void sMO_exit(SMO* handle);

/*! Performs a 'run to completion' step. */
extern void sMO_runCycle(SMO* handle);

/*! Raises a time event. */
extern void sMO_raiseTimeEvent(SMO* handle, sc_eventid evid);


/*! Gets the value of the variable 'key' that is defined in the interface scope 'KEYPAD'. */ 
extern sc_integer sMOIfaceKEYPAD_get_key(SMO* handle);
/*! Sets the value of the variable 'key' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMOIfaceKEYPAD_set_key(SMO* handle, sc_integer value);
/*! Gets the value of the variable 'lastkey' that is defined in the interface scope 'KEYPAD'. */ 
extern sc_integer sMOIfaceKEYPAD_get_lastkey(SMO* handle);
/*! Sets the value of the variable 'lastkey' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMOIfaceKEYPAD_set_lastkey(SMO* handle, sc_integer value);
/*! Gets the value of the variable 'key_down' that is defined in the interface scope 'KEYPAD'. */ 
extern sc_boolean sMOIfaceKEYPAD_get_key_down(SMO* handle);
/*! Sets the value of the variable 'key_down' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMOIfaceKEYPAD_set_key_down(SMO* handle, sc_boolean value);
/*! Raises the in event 'key_pressed' that is defined in the interface scope 'KEYPAD'. */ 
extern void sMOIfaceKEYPAD_raise_key_pressed(SMO* handle);


/*! Gets the value of the variable 'data' that is defined in the interface scope 'UART'. */ 
extern sc_string sMOIfaceUART_get_data(SMO* handle);
/*! Sets the value of the variable 'data' that is defined in the interface scope 'UART'. */ 
extern void sMOIfaceUART_set_data(SMO* handle, sc_string value);
/*! Gets the value of the variable 'lastdata' that is defined in the interface scope 'UART'. */ 
extern sc_string sMOIfaceUART_get_lastdata(SMO* handle);
/*! Sets the value of the variable 'lastdata' that is defined in the interface scope 'UART'. */ 
extern void sMOIfaceUART_set_lastdata(SMO* handle, sc_string value);
/*! Raises the in event 'DataRecieved' that is defined in the interface scope 'UART'. */ 
extern void sMOIfaceUART_raise_dataRecieved(SMO* handle);


/*! Gets the value of the variable 'data' that is defined in the interface scope 'RF'. */ 
extern sc_string sMOIfaceRF_get_data(SMO* handle);
/*! Sets the value of the variable 'data' that is defined in the interface scope 'RF'. */ 
extern void sMOIfaceRF_set_data(SMO* handle, sc_string value);
/*! Gets the value of the variable 'lastdata' that is defined in the interface scope 'RF'. */ 
extern sc_string sMOIfaceRF_get_lastdata(SMO* handle);
/*! Sets the value of the variable 'lastdata' that is defined in the interface scope 'RF'. */ 
extern void sMOIfaceRF_set_lastdata(SMO* handle, sc_string value);
/*! Gets the value of the variable 'result' that is defined in the interface scope 'RF'. */ 
extern sc_boolean sMOIfaceRF_get_result(SMO* handle);
/*! Sets the value of the variable 'result' that is defined in the interface scope 'RF'. */ 
extern void sMOIfaceRF_set_result(SMO* handle, sc_boolean value);
/*! Gets the value of the variable 'retry' that is defined in the interface scope 'RF'. */ 
extern sc_integer sMOIfaceRF_get_retry(SMO* handle);
/*! Sets the value of the variable 'retry' that is defined in the interface scope 'RF'. */ 
extern void sMOIfaceRF_set_retry(SMO* handle, sc_integer value);
/*! Gets the value of the variable 'ID' that is defined in the interface scope 'RF'. */ 
extern sc_integer sMOIfaceRF_get_iD(SMO* handle);
/*! Sets the value of the variable 'ID' that is defined in the interface scope 'RF'. */ 
extern void sMOIfaceRF_set_iD(SMO* handle, sc_integer value);
/*! Raises the in event 'DataRecieved' that is defined in the interface scope 'RF'. */ 
extern void sMOIfaceRF_raise_dataRecieved(SMO* handle);


/*! Gets the value of the variable 'ID' that is defined in the interface scope 'DISH'. */ 
extern sc_integer sMOIfaceDISH_get_iD(SMO* handle);
/*! Sets the value of the variable 'ID' that is defined in the interface scope 'DISH'. */ 
extern void sMOIfaceDISH_set_iD(SMO* handle, sc_integer value);
/*! Gets the value of the variable 'amount' that is defined in the interface scope 'DISH'. */ 
extern sc_integer sMOIfaceDISH_get_amount(SMO* handle);
/*! Sets the value of the variable 'amount' that is defined in the interface scope 'DISH'. */ 
extern void sMOIfaceDISH_set_amount(SMO* handle, sc_integer value);
/*! Gets the value of the variable 'pos' that is defined in the interface scope 'DISH'. */ 
extern sc_integer sMOIfaceDISH_get_pos(SMO* handle);
/*! Sets the value of the variable 'pos' that is defined in the interface scope 'DISH'. */ 
extern void sMOIfaceDISH_set_pos(SMO* handle, sc_integer value);

/*! Gets the value of the variable 'lightOn' that is defined in the default interface scope. */ 
extern sc_boolean sMOIface_get_lightOn(SMO* handle);
/*! Sets the value of the variable 'lightOn' that is defined in the default interface scope. */ 
extern void sMOIface_set_lightOn(SMO* handle, sc_boolean value);
/*! Gets the value of the variable 'menuId' that is defined in the default interface scope. */ 
extern sc_integer sMOIface_get_menuId(SMO* handle);
/*! Sets the value of the variable 'menuId' that is defined in the default interface scope. */ 
extern void sMOIface_set_menuId(SMO* handle, sc_integer value);
/*! Gets the value of the variable 'tableId' that is defined in the default interface scope. */ 
extern sc_integer sMOIface_get_tableId(SMO* handle);
/*! Sets the value of the variable 'tableId' that is defined in the default interface scope. */ 
extern void sMOIface_set_tableId(SMO* handle, sc_integer value);
/*! Gets the value of the variable 'confirmId' that is defined in the default interface scope. */ 
extern sc_integer sMOIface_get_confirmId(SMO* handle);
/*! Sets the value of the variable 'confirmId' that is defined in the default interface scope. */ 
extern void sMOIface_set_confirmId(SMO* handle, sc_integer value);
/*! Raises the in event 'switchOff' that is defined in the default interface scope. */ 
extern void sMOIface_raise_switchOff(SMO* handle);

/*! Raises the in event 'switchOn' that is defined in the default interface scope. */ 
extern void sMOIface_raise_switchOn(SMO* handle);



/*! Checks if the specified state is active. */
extern sc_boolean sMO_isActive(SMO* handle, SMOStates state);

#ifdef __cplusplus
}
#endif 

#endif /* SMO_H_ */
