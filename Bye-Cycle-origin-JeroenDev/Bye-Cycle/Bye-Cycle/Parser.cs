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


        private CommunicationArduino communicationArduinoFollowSystem;
        private CommunicationArduino communicationArduinoTrafficLight;
        public Parser()
        {
            MessageFromLastDevice = "FollowSystem";
            Devices = new List<CommunicationArduino>();
            Devices.Add(new CommunicationArduino(38400, "COM3", "FollowSystem"));
            Devices.Add(new CommunicationArduino(9600, "COM4", "TrafficLight"));

            finishedCommand = new string[2];
            parsedCommand = new string[3];
        }
        public string[] ParseArduinoData()
        {


            switch (MessageFromLastDevice)
            {
                case "FollowSystem":
                    foreach (CommunicationArduino Device in Devices)
                    {
                        if (Device.DeviceName == "TrafficLight")
                        {
                            //message = Device.ReadMessage();
                        }
                    }
                    MessageFromLastDevice = "TrafficLight";
                    return StringSplitter(message);
                case "TrafficLight":
                    foreach (CommunicationArduino Device in Devices)
                    {
                        if (Device.DeviceName == "FollowSystem")
                        {
                            message = Device.ReadMessage();
                        }
                    }
                    MessageFromLastDevice = "FollowSystem";
                    return StringSplitter(message);
            }
            return null;
        }

        private string[] StringSplitter(string test)
        {
            if (test != null)
            {
                parsedCommand = test.Split(parseChars);
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

        public void SendMessageToFollowingSystem(string message)
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
