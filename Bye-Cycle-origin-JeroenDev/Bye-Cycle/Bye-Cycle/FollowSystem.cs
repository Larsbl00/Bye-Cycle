using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    class FollowSystem : Data
    {
        private Stopwatch stopwatch = new Stopwatch();

        private List<long> timeLightsOn = new List<long>();

        public int HowManyBikes { get; private set; }

        public int PrefferedSide { get; private set; }


        public FollowSystem(DateTime currentDay) : base (currentDay)
        {

        }

        /* This method culculates the the time the lights were on
         * this info is stored in a list, the index of the list is how many times the lights were on.
         */ 
        public void CalculateTimeLightsOn(bool lightsOn)
        {
            if (lightsOn)
            {  
                if (!stopwatch.IsRunning)
                {
                    stopwatch.Start();
                }
            }
            else
            {
                if (stopwatch.IsRunning)
                {
                    timeLightsOn.Add(stopwatch.ElapsedMilliseconds / 1000);
                    stopwatch.Stop();
                }
            }
        }

        /*This method changes the prefferedside, the input is a bool True = left and false is right.
         * If prefferedside is above 0 prefferedside = left if its below 0 preffered side is right.
         * It also counts how many bikes there have been.
         */
        public void CalculatePreferredSide(bool side)
        {
            HowManyBikes++;
            if (side)
            {
                //If a bikes comes from the left.
                PrefferedSide = +1;
            }
            else
            {
                //If a bikes comes from the right.
                PrefferedSide = -1;
            }
        }

        // This method turns off the followingsystem, this makes it so that the light are always on if it is dark.
        public void TurnOffFollowSystem()
        {
            
        }
    }
}
