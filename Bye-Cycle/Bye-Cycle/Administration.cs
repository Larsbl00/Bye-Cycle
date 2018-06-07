using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Bye_Cycle
{
    [Serializable]
    public class Administration
    {
        private string[] command;  

        /// <summary>
        /// The parser to parse incoming data
        /// </summary>
        public Parser Parser { get; private set; }

        /// <summary>
        /// A list of Date classes
        /// </summary>
        public List<Date> Dates { get; private set; } = new List<Date>();

        /// <summary>
        /// Creates a new administration
        /// </summary>
        public Administration()
        {
            Dates = new List<Date>();
            Parser = new Parser();
        }

        /// <summary>
        /// Adds a new date to the list of dates, and auto sorts it
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Returns true if the operation was succesful</returns>
        public bool Add(Date date)
        {
            if (date == null) return false;
            Dates.Add(date);
            Dates.Sort();
            return true;
        }

        /// <summary>
        /// Returns the Date of a given dateTime
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Returns null if the date was not found or date == null, otherwise it'll return the found date</returns>
        public Date GetDate(DateTime date)
        {
            if (date == null) return null;
            Date foundDate = null;
            foreach (Date dateInList in Dates)
            {
                if (dateInList.GetDate().Year == date.Year &&
                    dateInList.GetDate().Month == date.Month &&
                    dateInList.GetDate().Day == date.Day)
                {
                    foundDate = dateInList;
                    break;
                }
            }
            return foundDate;
        }

        /// <summary>
        /// Exports the data to a given path
        /// </summary>
        /// <param name="name">This is the path</param>
        public void Export(string name)
        {
            using (FileStream stream = File.Open(name, FileMode.Create))
            {
            BinaryFormatter formatter = new BinaryFormatter();
            Dates.Sort();
            formatter.Serialize(stream, Dates);
            }
        }

        /// <summary>
        /// Reads a message from the Arduino and adds data accordingly;
        /// </summary>
        /// <param name="system"></param>
        public void ReadMessage(Date date)
        {
            Parser.ParseArduinoData(date);
        }

        /// <summary>
        /// Loads a file from a given path
        /// </summary>
        /// <param name="path"></param>
        public void Import(string path)
        {
            using (FileStream stream = File.Open(path, FileMode.OpenOrCreate))
            {
                if (stream.Length == 0) return;
                BinaryFormatter formatter = new BinaryFormatter();
                this.Dates.Clear();
                Dates = formatter.Deserialize(stream) as List<Date>;
                Dates.Sort();
            }
        }

        /// <summary>
        /// Saves the data to a static path
        /// </summary>
        public void Save()
        {
            using (FileStream stream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "DataDoNotTouch.Bye", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Dates.Sort();
                formatter.Serialize(stream, this.Dates);
                stream.Close();
            }
        }

        /// <summary>
        /// Removes a Date from the list
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool Remove(Date date)
        {
            if (date == null) return false;
            bool returnValue = this.Dates.Remove(date);
            Dates.Sort();
            return returnValue;
        }

        public void SendMessage(bool onOff)
        {
            if(onOff == true)
            {
                Parser.SendMessageToArduino("%F:followOff-1#");
            }
            else
            {
                Parser.SendMessageToArduino("%F:followOff-0#");
            }
        }
    }
}
