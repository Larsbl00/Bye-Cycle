using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Bye_Cycle
{
    public enum Systems
    {
        FollowSystem,
        TrafficLight
    }

    class Administration
    {
        private List<Data> data;
        public List<Data> Data
        {
            get { return new List<Data>(data); }
        }
   
        private Parser parser;
        private string[] command;
        private Systems systems;
        public Administration()
        {
            data  = new List<Data>();
            parser = new Parser();
        }

        public void ReadMessage()
        {

            command = parser.ParseArduinoData();
                        
            if (command != null)
            {
                switch (command[0])
                {
                    case "direction":
                        checkIfDateExist(Systems.FollowSystem);
                        foreach (FollowSystem data in data)
                        {
                            if(data.Date == DateTime.Today)
                            {
                                AddDirectionFollowLight(command[1]);
                            }
                        }
                        break;
                    case "timeActive":
                        break;
                    
                }
            }          
        }

        private void checkIfDateExist(Systems system)
        {
            switch (system)
            {
                case Systems.FollowSystem:

                    if(data.Count == 0) data.Add(new FollowSystem(DateTime.Today, Convert.ToString(DateTime.Today) + " F"));
                    foreach (FollowSystem date in data)
                    {
                        if (date.Name != Convert.ToString(DateTime.Today)+ " F")
                        {
                            data.Add(new FollowSystem(DateTime.Today, Convert.ToString(DateTime.Today) + " F"));
                        }
                    }
                    break;
                case Systems.TrafficLight:
                    if(data.Count == 0) data.Add(new TrafficLight(DateTime.Today, Convert.ToString(DateTime.Today) + " T"));
                    foreach (TrafficLight date in data)
                    {
                        if (date.Name != Convert.ToString(DateTime.Today) + " T")
                        {
                            data.Add(new TrafficLight(DateTime.Today, Convert.ToString(DateTime.Today) + " T"));
                        }
                    }
                    break;
            }            
        }


        //This method adds the preffered side, and counts how many cyclist used the followingsystem
        //True = Right False is Left
        public void AddDirectionFollowLight(string direction)
        {
            foreach (FollowSystem followSystem in data)
            {
                if (followSystem.Date == DateTime.Today)
                {
                    if (direction == "114")
                    {
                        followSystem.CalculatePreferredSide(true);
                    }
                    else
                    {
                        followSystem.CalculatePreferredSide(false);
                    }                
                }
            }
        }

        public void SendOnOffMessageToFollowingSystem(bool onOff)
        {
            if(onOff == true)
            {
                parser.SendMessageToFollowingSystem("%T:followOff-1#");
            }
            else
            {
                parser.SendMessageToFollowingSystem("%T:followOff-0#");
            }
        }

        /*
        public void DeleteData(string date)
        {
            if(date != null)
            {
                for (int i = 0; i < this.data.Count; i++)
                {
                    if (date == this.data[i].Date.ToString("dd/MM/yyyy"))
                    {
                        data.Remove(data[i]);
                    }
                }
            }
        }
        */

        public void Export(string name)
        {
            using (FileStream stream = File.Open(name, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this.data);
            }
        }

        public void Import(string path)
        {
            if (this.data.Count > 0) data.Clear();
            using (FileStream stream = File.OpenRead(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                data = formatter.Deserialize(stream) as List<Data>;
            }
        }

        public void Save()
        {
            using (FileStream stream = File.Open(AppDomain.CurrentDomain.BaseDirectory + @" DataDoNotTouch.Bye", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this.data);
            }
        }
    }
}
