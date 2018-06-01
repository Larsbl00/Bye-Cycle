using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    class Parser
    {
        private string message;
        private string[] parsedCommand;
        private string[] finishedCommand;
        private char[] parseChars = { ':', '-' };
        private string MessageFromLastDevice;
        private enum commands { direction  }

        private List<CommunicationArduino> Devices;


        
        public Parser()
        {
            MessageFromLastDevice = "FollowSystem";
            Devices = new List<CommunicationArduino>();
            Devices.Add(new CommunicationArduino(38400, "COM6", "FollowSystem"));
            Devices.Add(new CommunicationArduino(9600, "COM4", "TrafficLight"));

            finishedCommand = new string[2];
            parsedCommand = new string[3];
        }
        public string[] ParseArduinoData()
        {
            foreach (CommunicationArduino Device in Devices)
            {
                return StringSplitter(Device.ReadMessage());
            }
            return null;
        }

        private string[] StringSplitter(string messageToSplit)
        {
            if (messageToSplit != null)
            {
                parsedCommand = messageToSplit.Split(parseChars);
                if (parsedCommand[0] == "D" && parsedCommand.Length == 3)
                {
                    finishedCommand[0] = parsedCommand[1];
                    finishedCommand[1] = Convert.ToString(parsedCommand[2]);
                }

                return finishedCommand;
            }
            else
            {
                return null;
            }
        }

        public void SendMessageToArduino(string message)
        {
            foreach (CommunicationArduino Device in Devices)
            {
                if (Device.DeviceName == "FollowSystem")
                {
                    Device.SendMessage(message);
                }
            }
        }
    }
}
