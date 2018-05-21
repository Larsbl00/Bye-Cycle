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
        private enum commands { direction  }


        private CommunicationArduino communicationArduino;
        public Parser()
        {
            communicationArduino = new CommunicationArduino();
            finishedCommand = new string[2];
            parsedCommand = new string[3];
        }
        public string[] ParseArduinoData()
        {
            message = communicationArduino.ReadMessage();
            if (message != null)
            {
                parsedCommand = message.Split(parseChars);
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
    }
}
