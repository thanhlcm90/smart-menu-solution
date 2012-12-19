package org.yakindu.scr.smc;

import org.yakindu.scr.TimeEvent;
import org.yakindu.scr.ITimerService;

public class SMCStatemachine implements ISMCStatemachine {

	private final TimeEvent sendFail2_time_event_0 = new TimeEvent(false, 0);

	private final boolean[] timeEvents = new boolean[1];

	private final class SCILCDImpl implements SCILCD {

		private SCILCDOperationCallback operationCallback;

		public void setSCILCDOperationCallback(
				SCILCDOperationCallback operationCallback) {
			this.operationCallback = operationCallback;
		}

	}

	private SCILCDImpl sCILCD;

	private final class SCIKEYPADImpl implements SCIKEYPAD {

		private SCIKEYPADOperationCallback operationCallback;

		public void setSCIKEYPADOperationCallback(
				SCIKEYPADOperationCallback operationCallback) {
			this.operationCallback = operationCallback;
		}

		private boolean key_pressed;

		public void raiseKey_pressed() {
			key_pressed = true;
		}

		private int key;

		public int getKey() {
			return key;
		}

		public void setKey(int value) {
			this.key = value;
		}

		private int lastkey;

		public int getLastkey() {
			return lastkey;
		}

		public void setLastkey(int value) {
			this.lastkey = value;
		}

		private boolean key_down;

		public boolean getKey_down() {
			return key_down;
		}

		public void setKey_down(boolean value) {
			this.key_down = value;
		}

		public void clearEvents() {
			key_pressed = false;
		}

	}

	private SCIKEYPADImpl sCIKEYPAD;

	private final class SCIUARTImpl implements SCIUART {

		private SCIUARTOperationCallback operationCallback;

		public void setSCIUARTOperationCallback(
				SCIUARTOperationCallback operationCallback) {
			this.operationCallback = operationCallback;
		}

		private boolean dataRecieved;

		public void raiseDataRecieved() {
			dataRecieved = true;
		}

		private String data;

		public String getData() {
			return data;
		}

		public void setData(String value) {
			this.data = value;
		}

		private String lastdata;

		public String getLastdata() {
			return lastdata;
		}

		public void setLastdata(String value) {
			this.lastdata = value;
		}

		public void clearEvents() {
			dataRecieved = false;
		}

	}

	private SCIUARTImpl sCIUART;

	private final class SCIRFImpl implements SCIRF {

		private SCIRFOperationCallback operationCallback;

		public void setSCIRFOperationCallback(
				SCIRFOperationCallback operationCallback) {
			this.operationCallback = operationCallback;
		}

		private boolean dataRecieved;

		public void raiseDataRecieved() {
			dataRecieved = true;
		}

		private String data;

		public String getData() {
			return data;
		}

		public void setData(String value) {
			this.data = value;
		}

		private String lastdata;

		public String getLastdata() {
			return lastdata;
		}

		public void setLastdata(String value) {
			this.lastdata = value;
		}

		private boolean result;

		public boolean getResult() {
			return result;
		}

		public void setResult(boolean value) {
			this.result = value;
		}

		private int retry;

		public int getRetry() {
			return retry;
		}

		public void setRetry(int value) {
			this.retry = value;
		}

		private int iD;

		public int getID() {
			return iD;
		}

		public void setID(int value) {
			this.iD = value;
		}

		public void clearEvents() {
			dataRecieved = false;
		}

	}

	private SCIRFImpl sCIRF;

	private final class SCIDISHImpl implements SCIDISH {

		private int iD;

		public int getID() {
			return iD;
		}

		public void setID(int value) {
			this.iD = value;
		}

		private int amount;

		public int getAmount() {
			return amount;
		}

		public void setAmount(int value) {
			this.amount = value;
		}

		private int pos;

		public int getPos() {
			return pos;
		}

		public void setPos(int value) {
			this.pos = value;
		}

	}

	private SCIDISHImpl sCIDISH;

	private final class SCIDefaultImpl implements SCIDefault {

		private SCIDefaultOperationCallback operationCallback;

		public void setSCIDefaultOperationCallback(
				SCIDefaultOperationCallback operationCallback) {
			this.operationCallback = operationCallback;
		}

		private boolean switchOff;

		public void raiseSwitchOff() {
			switchOff = true;
		}

		private boolean switchOn;

		public void raiseSwitchOn() {
			switchOn = true;
		}

		private boolean lightOn;

		public boolean getLightOn() {
			return lightOn;
		}

		public void setLightOn(boolean value) {
			this.lightOn = value;
		}

		private int requestId;

		public int getRequestId() {
			return requestId;
		}

		public void setRequestId(int value) {
			this.requestId = value;
		}

		private int listId;

		public int getListId() {
			return listId;
		}

		public void setListId(int value) {
			this.listId = value;
		}

		public void clearEvents() {
			switchOff = false;
			switchOn = false;
		}

	}

	private SCIDefaultImpl sCIDefault;

	public enum State {
		Main_region_On, Main_region_On_r1_Init, Main_region_On_r1_Running, Main_region_On_r1_Running_keypad_CheckKey, Main_region_On_r1_Running_keypad_CheckKeyDown, Main_region_On_r1_Running_running_main_WaitingForRequest, Main_region_On_r1_Running_running_main_CheckKeyPress, Main_region_On_r1_Running_running_main_FinishDish, Main_region_On_r1_Running_running_main_CancelDish, Main_region_On_r1_Running_running_main_EnterData, Main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish, Main_region_On_r1_Running_running_main_EnterData_r1__final_, Main_region_On_r1_Running_running_main_EnterData_r1_Clear, Main_region_On_r1_Running_running_main_Send_Request, Main_region_On_r1_Running_running_main_Send_Request_send_Send, Main_region_On_r1_Running_running_main_Send_Request_send_Check, Main_region_On_r1_Running_running_main_Send_Request_send_SendFail2, Main_region_On_r1_Running_running_main_Send_Request_send_ResetResult, Main_region_On_r1_Running_running_main_Send_Request_send__final_, $NullState$
	};

	private final State[] stateVector = new State[2];

	private int nextStateIndex;

	private ITimerService timerService;

	private long cycleStartTime;

	public SMCStatemachine() {

		sCILCD = new SCILCDImpl();
		sCIKEYPAD = new SCIKEYPADImpl();
		sCIUART = new SCIUARTImpl();
		sCIRF = new SCIRFImpl();
		sCIDISH = new SCIDISHImpl();
		sCIDefault = new SCIDefaultImpl();

		sendFail2_time_event_0.setStatemachine(this);

	}

	public void init() {
		if (timerService == null) {
			throw new IllegalStateException("TimerService not set.");
		}
		for (int i = 0; i < 2; i++) {
			stateVector[i] = State.$NullState$;
		}

		clearEvents();
		clearOutEvents();
	}

	protected void clearEvents() {
		sCIKEYPAD.clearEvents();
		sCIUART.clearEvents();
		sCIRF.clearEvents();
		sCIDefault.clearEvents();

		for (int i = 0; i < timeEvents.length; i++) {
			timeEvents[i] = false;
		}
	}

	protected void clearOutEvents() {
	}

	public boolean isStateActive(State state) {
		for (int i = 0; i < stateVector.length; i++) {
			if (stateVector[i] == state) {
				return true;
			}
		}
		return false;
	}

	public void setTimerService(ITimerService timerService) {
		this.timerService = timerService;
	}

	public ITimerService getTimerService() {
		return timerService;
	}

	public void onTimeEventRaised(TimeEvent timeEvent) {
		timeEvents[timeEvent.getIndex()] = true;
	}

	public SCILCD getSCILCD() {
		return sCILCD;
	}
	public SCIKEYPAD getSCIKEYPAD() {
		return sCIKEYPAD;
	}
	public SCIUART getSCIUART() {
		return sCIUART;
	}
	public SCIRF getSCIRF() {
		return sCIRF;
	}
	public SCIDISH getSCIDISH() {
		return sCIDISH;
	}
	public SCIDefault getSCIDefault() {
		return sCIDefault;
	}

	public void raiseSwitchOff() {
		sCIDefault.raiseSwitchOff();
	}

	public void raiseSwitchOn() {
		sCIDefault.raiseSwitchOn();
	}

	public boolean getLightOn() {
		return sCIDefault.getLightOn();
	}

	public void setLightOn(boolean value) {
		sCIDefault.setLightOn(value);
	}
	public int getRequestId() {
		return sCIDefault.getRequestId();
	}

	public void setRequestId(int value) {
		sCIDefault.setRequestId(value);
	}
	public int getListId() {
		return sCIDefault.getListId();
	}

	public void setListId(int value) {
		sCIDefault.setListId(value);
	}

	public void enter() {
			if (timerService == null) {
				throw new IllegalStateException("TimerService not set.");
			}
			cycleStartTime = System.currentTimeMillis();
	entryActionSMC();
		sCIDefault.lightOn = true;
	


		sCIRF.operationCallback.Init;
		sCIUART.operationCallback.Init;


	nextStateIndex = 0;
	stateVector[0] = State.Main_region_On_r1_Init;






		}
	public void exit() {
		//Handle exit of all possible states (of main region) at position 0...
		switch (stateVector[0]) {

			case Main_region_On_r1_Init :
				stateVector[0] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_keypad_CheckKey :
				stateVector[0] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_keypad_CheckKeyDown :
				stateVector[0] = State.$NullState$;

				break;

			default :
				break;
		}
		//Handle exit of all possible states (of main region) at position 1...
		switch (stateVector[1]) {

			case Main_region_On_r1_Running_running_main_WaitingForRequest :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_CheckKeyPress :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_FinishDish :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_CancelDish :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_EnterData_r1__final_ :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_EnterData_r1_Clear :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_Send_Request_send_Send :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_Send_Request_send_Check :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_Send_Request_send_SendFail2 :
				stateVector[1] = State.$NullState$;
				getTimerService().resetTimer(sendFail2_time_event_0);

				break;

			case Main_region_On_r1_Running_running_main_Send_Request_send_ResetResult :
				stateVector[1] = State.$NullState$;

				break;

			case Main_region_On_r1_Running_running_main_Send_Request_send__final_ :
				stateVector[1] = State.$NullState$;

				break;

			default :
				break;
		}

		exitActionSMC();
	}

	private void entryActionSMC() {

	}

	private void exitActionSMC() {

	}

	private void reactMain_region_On() {
	}
	private void reactMain_region_On_r1_Init() {
		if (true) {
			stateVector[0] = State.$NullState$;

			sCIKEYPAD.key = sCIKEYPAD.operationCallback.Checkpress;

			sCIKEYPAD.key_down = false;

			nextStateIndex = 0;
			stateVector[0] = State.Main_region_On_r1_Running_keypad_CheckKey;

			sCIDefault.requestId = 0;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_WaitingForRequest;

		}

	}
	private void reactMain_region_On_r1_Running() {
	}
	private void reactMain_region_On_r1_Running_keypad_CheckKey() {
		if ((sCIKEYPAD.key != 0)) {
			stateVector[0] = State.$NullState$;

			sCIKEYPAD.lastkey = sCIKEYPAD.key;

			sCIKEYPAD.key = sCIKEYPAD.operationCallback.Checkpress;

			sCIKEYPAD.key_down = true;

			nextStateIndex = 0;
			stateVector[0] = State.Main_region_On_r1_Running_keypad_CheckKeyDown;

		} else {
			if ((sCIKEYPAD.key == 0)) {
				sCIKEYPAD.key = sCIKEYPAD.operationCallback.Checkpress;

				sCIKEYPAD.key_down = false;

				nextStateIndex = 0;
				stateVector[0] = State.Main_region_On_r1_Running_keypad_CheckKey;

			}
		}

	}
	private void reactMain_region_On_r1_Running_keypad_CheckKeyDown() {
		if ((sCIKEYPAD.key == 0)) {
			stateVector[0] = State.$NullState$;

			sCIKEYPAD.raiseKey_pressed();

			sCIKEYPAD.key = sCIKEYPAD.operationCallback.Checkpress;

			sCIKEYPAD.key_down = false;

			nextStateIndex = 0;
			stateVector[0] = State.Main_region_On_r1_Running_keypad_CheckKey;

		} else {
			if ((sCIKEYPAD.key != 0)) {
				sCIKEYPAD.key = sCIKEYPAD.operationCallback.Checkpress;

				sCIKEYPAD.key_down = true;

				nextStateIndex = 0;
				stateVector[0] = State.Main_region_On_r1_Running_keypad_CheckKeyDown;

			}
		}

	}
	private void reactMain_region_On_r1_Running_running_main_WaitingForRequest() {
		if (true) {
			stateVector[1] = State.$NullState$;

			sCIKEYPAD.lastkey = 0;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_CheckKeyPress;

		}
	}
	private void reactMain_region_On_r1_Running_running_main_CheckKeyPress() {
		if ((sCIKEYPAD.key_pressed && (sCIKEYPAD.lastkey == 13))) {
			stateVector[1] = State.$NullState$;

			sCIDefault.requestId = 5;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_FinishDish;

		} else {
			if ((sCIKEYPAD.key_pressed && (sCIKEYPAD.lastkey == 14))) {
				stateVector[1] = State.$NullState$;

				sCIDefault.requestId = 6;

				nextStateIndex = 1;
				stateVector[1] = State.Main_region_On_r1_Running_running_main_CancelDish;

			}
		}
	}
	private void reactMain_region_On_r1_Running_running_main_FinishDish() {
		if (true) {
			stateVector[1] = State.$NullState$;

			sCIDefault.listId = 0;

			sCIKEYPAD.lastkey = 0;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_EnterData_r1_Clear;

		}
	}
	private void reactMain_region_On_r1_Running_running_main_CancelDish() {
		if (true) {
			stateVector[1] = State.$NullState$;

			sCIDefault.listId = 0;

			sCIKEYPAD.lastkey = 0;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_EnterData_r1_Clear;

		}
	}
	private void reactMain_region_On_r1_Running_running_main_EnterData() {
	}
	private void reactMain_region_On_r1_Running_running_main_EnterData_r1_ChooseDish() {
		if ((sCIDefault.requestId == 0)) {
			//Handle exit of all possible states (of r1) at position 1...
			switch (stateVector[1]) {

				case Main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish :
					stateVector[1] = State.$NullState$;

					break;

				case Main_region_On_r1_Running_running_main_EnterData_r1__final_ :
					stateVector[1] = State.$NullState$;

					break;

				case Main_region_On_r1_Running_running_main_EnterData_r1_Clear :
					stateVector[1] = State.$NullState$;

					break;

				default :
					break;
			}

			sCIDefault.requestId = 0;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_WaitingForRequest;

		} else {
			if (true) {
				stateVector[1] = State.$NullState$;

				sCIDefault.requestId = 0;

				nextStateIndex = 1;
				stateVector[1] = State.Main_region_On_r1_Running_running_main_EnterData_r1__final_;

			} else {
				if (true) {
					//Handle exit of all possible states (of r1) at position 1...
					switch (stateVector[1]) {

						case Main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish :
							stateVector[1] = State.$NullState$;

							break;

						case Main_region_On_r1_Running_running_main_EnterData_r1__final_ :
							stateVector[1] = State.$NullState$;

							break;

						case Main_region_On_r1_Running_running_main_EnterData_r1_Clear :
							stateVector[1] = State.$NullState$;

							break;

						default :
							break;
					}

					sCIRF.result = false;

					sCIRF.retry = 0;

					sCIRF.retry += 1;

					sCIRF.result = sCIRF.operationCallback.SendRequest;

					nextStateIndex = 1;
					stateVector[1] = State.Main_region_On_r1_Running_running_main_Send_Request_send_Send;

				}
			}

		}
	}
	private void reactMain_region_On_r1_Running_running_main_EnterData_r1__final_() {
		if ((sCIDefault.requestId == 0)) {
			//Handle exit of all possible states (of r1) at position 1...
			switch (stateVector[1]) {

				case Main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish :
					stateVector[1] = State.$NullState$;

					break;

				case Main_region_On_r1_Running_running_main_EnterData_r1__final_ :
					stateVector[1] = State.$NullState$;

					break;

				case Main_region_On_r1_Running_running_main_EnterData_r1_Clear :
					stateVector[1] = State.$NullState$;

					break;

				default :
					break;
			}

			sCIDefault.requestId = 0;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_WaitingForRequest;

		} else {

		}
	}
	private void reactMain_region_On_r1_Running_running_main_EnterData_r1_Clear() {
		if ((sCIDefault.requestId == 0)) {
			//Handle exit of all possible states (of r1) at position 1...
			switch (stateVector[1]) {

				case Main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish :
					stateVector[1] = State.$NullState$;

					break;

				case Main_region_On_r1_Running_running_main_EnterData_r1__final_ :
					stateVector[1] = State.$NullState$;

					break;

				case Main_region_On_r1_Running_running_main_EnterData_r1_Clear :
					stateVector[1] = State.$NullState$;

					break;

				default :
					break;
			}

			sCIDefault.requestId = 0;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_WaitingForRequest;

		} else {
			if ((sCIKEYPAD.key_pressed && ((sCIKEYPAD.lastkey >= 1) && (sCIKEYPAD.lastkey <= 10)))) {
				stateVector[1] = State.$NullState$;

				sCIDefault.listId = sCIKEYPAD.lastkey;

				nextStateIndex = 1;
				stateVector[1] = State.Main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish;

			}

		}
	}
	private void reactMain_region_On_r1_Running_running_main_Send_Request() {
	}
	private void reactMain_region_On_r1_Running_running_main_Send_Request_send_Send() {
if (  (sCIRF.result == true)  ) { 
	stateVector[1] = State.$NullState$;

		sCIRF.result = sCIRF.operationCallback.GetCheck;
	


	nextStateIndex = 1;
	stateVector[1] = State.Main_region_On_r1_Running_running_main_Send_Request_send_Check;


}
else {
if (  (sCIRF.result == false)  ) { 
	stateVector[1] = State.$NullState$;

getTimerService().setTimer(sendFail2_time_event_0, (2 * 1000), cycleStartTime);
		sCILCD.operationCallback.Clear;
		sCILCD.operationCallback.WriteString;


	nextStateIndex = 1;
	stateVector[1] = State.Main_region_On_r1_Running_running_main_Send_Request_send_SendFail2;


}
}


	}
	private void reactMain_region_On_r1_Running_running_main_Send_Request_send_Check() {
		if ((sCIRF.result == false)) {
			stateVector[1] = State.$NullState$;

			sCIRF.retry += 1;

			sCIRF.result = sCIRF.operationCallback.SendRequest;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_Send_Request_send_Send;

		} else {
			if (true) {
				stateVector[1] = State.$NullState$;

				sCIRF.result = true;

				sCIRF.retry = 0;

				nextStateIndex = 1;
				stateVector[1] = State.Main_region_On_r1_Running_running_main_Send_Request_send_ResetResult;

			}
		}

	}
	private void reactMain_region_On_r1_Running_running_main_Send_Request_send_SendFail2() {
		if (timeEvents[sendFail2_time_event_0.getIndex()]) {
			stateVector[1] = State.$NullState$;
			getTimerService().resetTimer(sendFail2_time_event_0);

			sCIRF.result = true;

			sCIRF.retry = 0;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_Send_Request_send_ResetResult;

		}

	}
	private void reactMain_region_On_r1_Running_running_main_Send_Request_send_ResetResult() {
		if (true) {
			stateVector[1] = State.$NullState$;

			nextStateIndex = 1;
			stateVector[1] = State.Main_region_On_r1_Running_running_main_Send_Request_send__final_;

		}

	}
	private void reactMain_region_On_r1_Running_running_main_Send_Request_send__final_() {

	}

	public void runCycle() {

		cycleStartTime = System.currentTimeMillis();

		clearOutEvents();

		for (nextStateIndex = 0; nextStateIndex < stateVector.length; nextStateIndex++) {

			switch (stateVector[nextStateIndex]) {
				case Main_region_On :
					reactMain_region_On();
					break;
				case Main_region_On_r1_Init :
					reactMain_region_On_r1_Init();
					break;
				case Main_region_On_r1_Running :
					reactMain_region_On_r1_Running();
					break;
				case Main_region_On_r1_Running_keypad_CheckKey :
					reactMain_region_On_r1_Running_keypad_CheckKey();
					break;
				case Main_region_On_r1_Running_keypad_CheckKeyDown :
					reactMain_region_On_r1_Running_keypad_CheckKeyDown();
					break;
				case Main_region_On_r1_Running_running_main_WaitingForRequest :
					reactMain_region_On_r1_Running_running_main_WaitingForRequest();
					break;
				case Main_region_On_r1_Running_running_main_CheckKeyPress :
					reactMain_region_On_r1_Running_running_main_CheckKeyPress();
					break;
				case Main_region_On_r1_Running_running_main_FinishDish :
					reactMain_region_On_r1_Running_running_main_FinishDish();
					break;
				case Main_region_On_r1_Running_running_main_CancelDish :
					reactMain_region_On_r1_Running_running_main_CancelDish();
					break;
				case Main_region_On_r1_Running_running_main_EnterData :
					reactMain_region_On_r1_Running_running_main_EnterData();
					break;
				case Main_region_On_r1_Running_running_main_EnterData_r1_ChooseDish :
					reactMain_region_On_r1_Running_running_main_EnterData_r1_ChooseDish();
					break;
				case Main_region_On_r1_Running_running_main_EnterData_r1__final_ :
					reactMain_region_On_r1_Running_running_main_EnterData_r1__final_();
					break;
				case Main_region_On_r1_Running_running_main_EnterData_r1_Clear :
					reactMain_region_On_r1_Running_running_main_EnterData_r1_Clear();
					break;
				case Main_region_On_r1_Running_running_main_Send_Request :
					reactMain_region_On_r1_Running_running_main_Send_Request();
					break;
				case Main_region_On_r1_Running_running_main_Send_Request_send_Send :
					reactMain_region_On_r1_Running_running_main_Send_Request_send_Send();
					break;
				case Main_region_On_r1_Running_running_main_Send_Request_send_Check :
					reactMain_region_On_r1_Running_running_main_Send_Request_send_Check();
					break;
				case Main_region_On_r1_Running_running_main_Send_Request_send_SendFail2 :
					reactMain_region_On_r1_Running_running_main_Send_Request_send_SendFail2();
					break;
				case Main_region_On_r1_Running_running_main_Send_Request_send_ResetResult :
					reactMain_region_On_r1_Running_running_main_Send_Request_send_ResetResult();
					break;
				case Main_region_On_r1_Running_running_main_Send_Request_send__final_ :
					reactMain_region_On_r1_Running_running_main_Send_Request_send__final_();
					break;
				default :
					// $NullState$
			}
		}

		clearEvents();
	}
}
