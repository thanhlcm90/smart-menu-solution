using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace SMS_Management
{
    /// <summary>
    /// Control to connect COM PORT
    /// Write by Lê Cao Minh Thành
    /// </summary>
    public partial class COMConnection : UserControl
    {

        // Create the serial port with basic settings
        private SerialPort port;

        private string portName="COM5";
        private int baudRate=9600;
        private Parity parity=Parity.None ;
        private int dataBits=8;
        private StopBits stopBits=StopBits.One ;

        public delegate void DataReceivedEventHandler(string data);
        [Category("Action")]
        [Description("Fires when the data is sent")]
        public event DataReceivedEventHandler DataReceived;

        public string PortName
        {
            get { return portName; }
            set { portName = value; }
        }
        public int PortBaudRate
        {
            get { return baudRate; }
            set { baudRate = value; }
        }
        public Parity PortParity
        {
            get { return parity; }
            set { parity = value; }
        }
        public int PortDataBits
        {
            get { return dataBits; }
            set { dataBits = value; }
        }
        public StopBits PortStopBits
        {
            get { return stopBits; }
            set { stopBits = value; }
        }

        public COMConnection()
        {
            InitializeComponent();
        }   

        public void PortOpen() {
            try
            {
                port = new SerialPort(PortName , PortBaudRate, PortParity , PortDataBits, PortStopBits );
                // Tạo handle event
                port.NewLine = "\0";
                port.DataReceived += new
                  SerialDataReceivedEventHandler(port_DataReceived);
                // Mở port
                if (!port.IsOpen) port.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PortClose()
        {
            try
            {
                if (port.IsOpen) port.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SendData(string data)
        {
            //data += "\0";
            port.WriteLine(data);
        }

        private void port_DataReceived(object sender,
          SerialDataReceivedEventArgs e)
        {
            DataReceived (port.ReadLine());
        }
    }
}
