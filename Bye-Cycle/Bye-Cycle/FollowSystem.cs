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
        private List<long> timeLightsOn = new List<long>();

        private Stopwatch stopwatch = new Stopwatch();
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
         */
        public void CalculatePreferredSide(bool side)
        {
            if (side == true)
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

        //This stores all the bikes of that day into the int HowManyBikes.
        public void CalculateAmountOfBikes(int bikes)
        {
            HowManyBikes = +bikes;
        }



    }
}
