using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Int32 = System.Int32;

namespace Bye_Cycle
{
    class CommunicationArduino
    {
        private string[] parsedString;
        private char[] parseChars = {'%', '#'};
        private string message;
        public string DeviceName { get; private set; }

        private SerialPort mySerialPort = new SerialPort();
        private SerialPort spL;

        public CommunicationArduino(int baudRate, string comPort, string name)
        {
            DeviceName = name;
            mySerialPort.PortName = comPort;
            mySerialPort.BaudRate = baudRate;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.ReceivedBytesThreshold = 6;
            mySerialPort.DtrEnable = false;
            mySerialPort.RtsEnable = false;
        }

        public string ReadMessage()
        {   
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Close();
            }
            mySerialPort.Open();

            message = mySerialPort.ReadLine();
            mySerialPort.Close();


            if (message != null)
            {
                parsedString = message.Split(parseChars);
                return parsedString[1];
            }
            else
            {
                return null;
            }
        }

        public void SendMessage(string message)
        {
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Close();
            }
            mySerialPort.Open();
            mySerialPort.WriteLine("%" + message + "#");
            mySerialPort.Close();
        }
    }
}

