using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace Bye_Cycle
{
    public enum Systems
    {
        FollowSystem,
        TrafficLight
    }

    public enum Side
    {
        Left,
        Right,
        None
        
    }

    class Administration
    {
        private List<Data> data;

        private List<Data> dataForChecks;
        public List<Data> CopyData
        {
            get { return new List<Data>(data); }
        }

        private long TimeLightsOn;
        private Parser parser;
        private string[] command;
        public Systems system { get; private set; }
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
                //MessageBox.Show(command[0] + command[1]);
                switch (command[0])
                {
                    case "direction":
                        checkIfDateExist(Systems.FollowSystem);
                        foreach (Data data in data)
                        {
                            FollowSystem Fdata = data as FollowSystem;
                            if (Fdata.Date == DateTime.Today)
                            {
                                if (command[1] == "114")
                                {
                                    Fdata.CalculatePreferredSide(true);
                                }
                                else
                                {
                                    Fdata.CalculatePreferredSide(false);
                                }
                            }
                        }
                        break;
                    case "timeActive":
                        checkIfDateExist(Systems.FollowSystem);
                        foreach (Data data in data)
                        {
                            FollowSystem Fdata = data as FollowSystem;
                            if (Fdata.Date == DateTime.Today)
                            {
                                if (Int64.TryParse(command[1], out TimeLightsOn))
                                {
                                    Fdata.AddLightsOn(TimeLightsOn);
                                }
                                else
                                {
                                    throw new ArgumentException("Input from arduino wrong");
                                }
                            }
                        }
                        break;
                    case "isRaining":
                        checkIfDateExist(Systems.TrafficLight);
                        foreach (Data data in data)
                        {
                            TrafficLight Tdata = data as TrafficLight;
                            if (Tdata.Date == DateTime.Today)
                            {
                                Tdata.CalculateTimeRain(Convert.ToBoolean(command[1]));
                                break;
                            }
                        }
                        break;
                }
            }          
        }

        private void checkIfDateExist(Systems system)
        {
            int count = 0;
            dataForChecks = new List<Data>(data);

            if (system == Systems.FollowSystem)
            {
                if (data.Count == 0)
                {
                    data.Add(new FollowSystem(DateTime.Today, Convert.ToString(DateTime.Today) + " F"));
                }
                else
                {
                    foreach (Data data in dataForChecks)
                    {
                        FollowSystem Fdata = data as FollowSystem;
                        if (Fdata != null)
                        {
                            if (Fdata.Name == Convert.ToString(DateTime.Today) + " F")
                            {
                                count ++;
                            }
                        }
                    }

                    if (count == 0)
                    {
                        this.data.Add(new FollowSystem(DateTime.Today, Convert.ToString(DateTime.Today) + " F"));
                    }

                }
                
            }
            else if ( system == Systems.TrafficLight)
            {
                if (data.Count == 0)
                {
                    data.Add(new TrafficLight(DateTime.Today, Convert.ToString(DateTime.Today) + " F"));
                }
                else
                {
                    foreach (Data data in dataForChecks)
                    {
                        TrafficLight Fdata = data as TrafficLight;
                        if (Fdata != null)
                        {
                            if (Fdata.Name == Convert.ToString(DateTime.Today) + " F")
                            {
                                count++;
                            }
                        }
                    }

                    if (count == 0)
                    {
                        this.data.Add(new TrafficLight(DateTime.Today, Convert.ToString(DateTime.Today) + " F"));
                    }
                }
            }
        }
        

        public void SendOnOffMessageToFollowingSystem(bool onOff)
        {
            if(onOff == true)
            {
                parser.SendMessageToArduino("%F:followOff-1#");
            }
            else
            {
                parser.SendMessageToArduino("%F:followOff-0#");
            }
        }

        
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
                if(stream.Length != 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    data = formatter.Deserialize(stream) as List<Data>;
                }
            }
        }
        
        public void Save()
        {
            using (FileStream stream = File.Open(AppDomain.CurrentDomain.BaseDirectory + @" DataDoNotTouch.Bye", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this.data);
                stream.Close();
            }
        }
    }
}
