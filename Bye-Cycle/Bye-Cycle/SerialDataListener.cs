using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    public class SerialDataListener
    {
        public SerialMessenger SerialMessenger { get; private set; }
        private MessageBuilder messageBuilder;
        private DeviceDetector detecter;
        public SerialDataListener()
        {
            detecter = new DeviceDetector();
            if (detecter.DetectArduinos())
            {
                messageBuilder = new MessageBuilder('%', '#');
                SerialMessenger = new SerialMessenger(detecter.Devices[0].Port, 115200, messageBuilder);
            }
            else
            {
                messageBuilder = new MessageBuilder('%', '#');
                SerialMessenger = new SerialMessenger("COM10", 115200, messageBuilder);
            }

        }
        public string[] ReadMessagesFromArduino()
        {
            return SerialMessenger.ReadMessages();
        }
        public string SignListening(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }
            if (message == "")
            {
                throw new ArgumentOutOfRangeException("message");
            }
            string[] bord = MessageDivider(message);
            return bord[2];
        }

        public bool DistListening(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }
            if (message == "")
            {
                throw new ArgumentOutOfRangeException("message");
            }

            int afstand;
            if (Int32.TryParse(MessageDivider(message)[3], out afstand))
            {
                if (afstand >= 50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            ///
            else
            {
                throw new ArgumentException();
            }
        }
        public string GPSListening(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }
            if (message == "")
            {
                throw new ArgumentOutOfRangeException("message");
            }

            string[] loc = MessageDivider(message);

            return loc[0] + "," + loc[1];
        }
        public string[] MessageDivider(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }
            if (message == "")
            {
                throw new ArgumentOutOfRangeException("message");
            }

            if (message[0] == 'B')
            {
                message = message.Remove(0, 1);
            }

            string[] newMessage = message.Split('!');
            return newMessage;
        }
    }
}
