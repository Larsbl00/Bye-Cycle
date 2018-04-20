using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    class CommunicationArduino
    {


        public CommunicationArduino()
        {
            new Thread(delegate () {
                ReadMessage();
            }).Start();
        }

        public string ReadMessage()
        {
            SerialPort serialPort = new SerialPort();

            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;
            serialPort.Close();
            serialPort.Open();

            string message = serialPort.ReadLine();
            
            serialPort.Close();
            return message;
        }


    }
}
