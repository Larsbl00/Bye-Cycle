using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    [Serializable]
    public class TrafficLightData
    {
        /// <summary>
        /// Returns for how long it has been raining
        /// </summary>
        public long TotalTimeRain { get; private set; }

        /// <summary>
        /// Creates a new instance of TrafficLightData
        /// </summary>
        /// <param name="totalTimeRain"></param>
        public TrafficLightData(long totalTimeRain)
        {
            this.TotalTimeRain = totalTimeRain;
        }
    }
}
