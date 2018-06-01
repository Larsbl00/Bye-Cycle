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

        private SerialPort mySerialPort = new SerialPort();
        private SerialPort spL;

        public CommunicationArduino()
        {
            mySerialPort.PortName = "COM3";
            mySerialPort.BaudRate = 38400;
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
    }
}

