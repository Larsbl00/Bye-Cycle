using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bye_Cycle
{
    [Serializable]
    public class TrafficLight : Device
    {
        /// <summary>
        /// Returns the list of all saved data of the trafficlight
        /// </summary>
        public List<TrafficLightData> TrafficLightData { get; private set; }

        /// <summary>
        /// Returns how many bikes were prioritised
        /// </summary>
        public long BikesPrioritised { get => TrafficLightData.Count; }

        [NonSerialized]
        private Stopwatch stopwatch;

        /// <summary>
        /// Creates a new instance of TrafficLight
        /// </summary>
        /// <param name="currentDay"></param>
        /// <param name="name"></param>
        public TrafficLight(DateTime currentDay, string name) : base (currentDay, name)
        {
            TrafficLightData = new List<TrafficLightData>();
            stopwatch  = new Stopwatch();
        }


        /// <summary>
        /// Calculates for how long it has been raining
        /// </summary>
        /// <param name="isRaining">Turns the timer on or off</param>
        public void CalculateTimeRain(bool isRaining)
        {
            if (stopwatch == null) return;
            if (isRaining)
            {
                if (!stopwatch.IsRunning)
                {
                    stopwatch.Reset();
                    stopwatch.Start();
                }
            }
            else
            {
                if (stopwatch.IsRunning)
                {
                    if (stopwatch.ElapsedMilliseconds > 1000)
                    {
                        TrafficLightData.Add(new TrafficLightData(stopwatch.ElapsedMilliseconds));
                        base.LastTimeActive = DateTime.Now;
                    }
                    stopwatch.Stop();
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", Prioritised: " + BikesPrioritised;
        }



    }
}
