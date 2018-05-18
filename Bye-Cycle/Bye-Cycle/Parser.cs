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
        }
        public string ParseArduinoData()
        {
            message = communicationArduino.ReadMessage();

            /*
            parsedCommand = message.Split(parseChars);

            
            if (parsedCommand[0] == "D")
            {
                switch (parsedCommand[1])
                {
                    case "direction":
                        finishedCommand[0] = parsedCommand[1];
                        finishedCommand[1] = parsedCommand[2];                      
                        break;
                    case "timeActive":
                        finishedCommand[0] = parsedCommand[1];
                        finishedCommand[1] = parsedCommand[2];
                        break;
                }
            }

            return finishedCommand;
            */
            return message;
        }
    }
}
