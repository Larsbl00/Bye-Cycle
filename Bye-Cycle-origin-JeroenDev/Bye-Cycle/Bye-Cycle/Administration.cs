using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Bye_Cycle
{
    class Administration
    {

        public List<Data> data { get; private set; }
        public List<string> Test { get; private set; }
        private Parser parser;
        private string[] command;
        public Administration()
        {
            data  = new List<Data>();
            parser = new Parser();
            Test = new List<string>();
        }

        public void ReadMessage()
        {
            command = parser.ParseArduinoData();

            if(command != null)
            {
                Test.Add(command[0]);

                checkIfDateExist();
            }




            /*
            if (command[0] != null)
            {
                return command;
            }
            else
            {
                return "Nothing found";
            }
            switch (command[0])
            {
                case "direction":
                    checkIfDateExist();
                    AddDirectionFollowLight(command[1]);
                    break;
                case "timeActive":
                    break;
            }
            */
        }

        private void checkIfDateExist()
        {
            foreach (Data date in data)
            {
                if (date.Date != DateTime.Today)
                {
                    data.Add(new FollowSystem(DateTime.Today));
                    data.Add(new TrafficLight(DateTime.Today));
                }
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





























        public Data AddData()
        {
            return null;
        }

        public Data Getdata(DateTime data)
        {
            return null;
        }

        public void Save()
        {
            
        }

        public void Delete()
        {
            
        }

        public void Backup()
        {
           
        }

        public void Change()
        {
            
        }
    }
}
