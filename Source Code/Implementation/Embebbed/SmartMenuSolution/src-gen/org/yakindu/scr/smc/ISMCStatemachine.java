
package org.yakindu.scr.smc;

import org.yakindu.scr.IStatemachine;
	import org.yakindu.scr.ITimedStatemachine;

public interface ISMCStatemachine extends ITimedStatemachine,IStatemachine {
	
	
	public interface SCILCD{
		
		
		
		public void setSCILCDOperationCallback(SCILCDOperationCallback operationCallback);
	}
	
		public interface SCILCDOperationCallback {
		
			
	public void Clear(
);

		
			
	public void WriteString(
			String 
				chr
);

		
			
	public void WriteStringXY(
			String 
				chr
				,
			int 
				x
				,
			int 
				y
);

		
			
	public void WriteNumberXY(
			int 
				num
				,
			int 
				x
				,
			int 
				y
				,
			int 
				l
);

		
			
	public void Init(
);

		
		}
	
	public interface SCIKEYPAD{
			
				public void raiseKey_pressed();
		
			public int getKey();
				public void setKey(int value);	
			public int getLastkey();
				public void setLastkey(int value);	
			public boolean getKey_down();
				public void setKey_down(boolean value);	
		
		
		public void setSCIKEYPADOperationCallback(SCIKEYPADOperationCallback operationCallback);
	}
	
		public interface SCIKEYPADOperationCallback {
		
			
	public int Checkpress(
);

		
			
	public void Init(
);

		
		}
	
	public interface SCIUART{
			
				public void raiseDataRecieved();
		
			public String getData();
				public void setData(String value);	
			public String getLastdata();
				public void setLastdata(String value);	
		
		
		public void setSCIUARTOperationCallback(SCIUARTOperationCallback operationCallback);
	}
	
		public interface SCIUARTOperationCallback {
		
			
	public void Init(
);

		
			
	public //null SendData(
			String 
				msg
);

		
			
	public void SendTemp(
);

		
			
	public String GetData(
);

		
		}
	
	public interface SCIRF{
			
				public void raiseDataRecieved();
		
			public String getData();
				public void setData(String value);	
			public String getLastdata();
				public void setLastdata(String value);	
			public boolean getResult();
				public void setResult(boolean value);	
			public int getRetry();
				public void setRetry(int value);	
			public int getID();
				public void setID(int value);	
		
		
		public void setSCIRFOperationCallback(SCIRFOperationCallback operationCallback);
	}
	
		public interface SCIRFOperationCallback {
		
			
	public void Init(
);

		
			
	public boolean SendRequest(
			int 
				cmd
				,
			int 
				id
);

		
			
	public boolean SendMsg(
			String 
				msg
);

		
			
	public boolean SendCheck(
);

		
			
	public boolean GetCheck(
);

		
			
	public String GetData(
);

		
		}
	
	public interface SCIDISH{
		
			public int getID();
				public void setID(int value);	
			public int getAmount();
				public void setAmount(int value);	
			public int getPos();
				public void setPos(int value);	
		
		
	}
	
	
	public interface SCIDefault{
			
				public void raiseSwitchOff();
			
				public void raiseSwitchOn();
		
			public boolean getLightOn();
				public void setLightOn(boolean value);	
			public int getRequestId();
				public void setRequestId(int value);	
			public int getListId();
				public void setListId(int value);	
		
		
		public void setSCIDefaultOperationCallback(SCIDefaultOperationCallback operationCallback);
	}
	
		public interface SCIDefaultOperationCallback {
		
			
	public //null ConvertNumber(
			int 
				num
				,
			int 
				pos
);

		
		}
	
	
	
	public SCILCD getSCILCD();
	
	public SCIKEYPAD getSCIKEYPAD();
	
	public SCIUART getSCIUART();
	
	public SCIRF getSCIRF();
	
	public SCIDISH getSCIDISH();
	
	public SCIDefault getSCIDefault();
	
	
	
}
