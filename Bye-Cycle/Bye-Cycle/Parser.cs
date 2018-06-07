using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    public class Parser
    {
        private string message;
        private string[] parsedCommand;
        private string[] finishedCommand;
        private char[] parseChars = { ':', '-' };

        private long lastTimeActive = -1;

        private CommunicationArduino followSystem;
        private CommunicationArduino trafficLight;
        private List<CommunicationArduino> Devices;

        private bool parseArduinoData(Date date, CommunicationArduino arduino)
        {
            if (date == null || arduino == null) return false;
            string[] command = StringSplitter(arduino.ReadMessage());
            if (command == null) return false;
            switch (command[0])
            {
                case "direction":
                    if (followSystem == null) return false;
                    char direction;
                    Side side = 0;
                    if (int.TryParse(command[1], out int charAsInt))
                    {
                        direction = (char)charAsInt;
                        switch (direction)
                        {
                            case 'l':
                                side = Side.Left;
                                break;
                            case 'r':
                                side = Side.Right;
                                break;
                            default:
                                side = Side.Unknown;
                                break;
                        }
                        date.FollowSystem.AddData(lastTimeActive, side);
                        lastTimeActive = -1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "timeActive":
                    if (followSystem == null) return false;
                    if (long.TryParse(command[1], out lastTimeActive))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "IsRaining":
                    if (trafficLight == null) return false;
                    if (int.TryParse(command[1], out int value))
                    {
                        bool boolVal = false;
                        if (value > 0) boolVal = true;
                        date.TrafficLight.CalculateTimeRain(boolVal);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }

        public Parser()
        {
            Devices = new List<CommunicationArduino>();
            try
            {
                followSystem = new CommunicationArduino(38400, "COM6", "FollowSystem");
                Devices.Add(followSystem);
            }
            catch (System.IO.IOException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                trafficLight = new CommunicationArduino(9600, "COM3", "TrafficLight");
                Devices.Add(trafficLight);
            }
            catch (System.IO.IOException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finishedCommand = new string[2];
            parsedCommand = new string[3];
        }

        /// <summary>
        /// Parses the arduino data so it's ready for use
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Returns true if all devices parsed correctly</returns>
        public bool ParseArduinoData(Date date)
        {
            bool succes = true;
            foreach (CommunicationArduino com in Devices)
            {
                succes = parseArduinoData(date, com);
            }
            return succes;
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
            if (followSystem == null || message == null) return;
            followSystem.SendMessage(message);
        }
    }
}
