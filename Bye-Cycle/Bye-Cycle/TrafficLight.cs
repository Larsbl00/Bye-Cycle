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
        private bool timeAdded = false;
        private List<TrafficLightData> trafficLightData;

        /// <summary>
        /// Returns how many bikes were prioritised
        /// </summary>
        public long BikesPrioritised { get => trafficLightData.Count; }

        public List<TrafficLightData> TrafficLightData { get => new List<TrafficLightData>(trafficLightData); }

        [NonSerialized]
        private Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// Creates a new instance of TrafficLight
        /// </summary>
        /// <param name="currentDay"></param>
        /// <param name="name"></param>
        public TrafficLight(DateTime currentDay, string name) : base (currentDay, name)
        {
            trafficLightData = new List<TrafficLightData>();
        }


        /// <summary>
        /// Calculates for how long it has been raining
        /// </summary>
        /// <param name="isRaining">Turns the timer on or off</param>
        public void CalculateTimeRain(bool isRaining)
        {
            if (isRaining)
            {
                if (!stopwatch.IsRunning)
                {
                    timeAdded = false;
                    stopwatch.Reset();
                    stopwatch.Start();
                }
            }
            else
            {
                if (stopwatch.IsRunning && timeAdded == false)
                {
                    trafficLightData.Add(new TrafficLightData(stopwatch.ElapsedMilliseconds));
                    base.LastTimeActive = DateTime.Now;
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
