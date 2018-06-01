﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bye_Cycle
{
    class TrafficLight : Data
    {
        private List<long> totalTimeRain;
        public int HowManyBicyclesPrioritised { get; private set; }

        private bool isRaining;

        private Stopwatch stopwatch = new Stopwatch();

        public TrafficLight(DateTime currentDay) : base (currentDay)
        {
            totalTimeRain =  new List<long>();
        }


        /* this method calculates the time it has rained, and puts this data into a list,
         * the index of the list shows how many times it has rained
         */
        public void CalculateTimeRain()
        {
            if (isRaining)
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
                    totalTimeRain.Add(stopwatch.ElapsedMilliseconds / 1000);
                    stopwatch.Stop();
                }
            }
        }

        // This method Calculates how many bikes have been prioritised
        public void CalculateAmountOfBikesPrioritised(int bikesPrioritised)
        {
            try
            {
                HowManyBicyclesPrioritised = +bikesPrioritised;
            }
            catch (NullReferenceException)
            {
                HowManyBicyclesPrioritised = HowManyBicyclesPrioritised;
            }
            
        }
    }
}
