using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    [Serializable]
    public class Date : IDate
    {
        private DateTime date;
        
        public TrafficLight TrafficLight { get; private set; }

        public FollowSystem FollowSystem { get; private set; }

        /// <summary>
        /// Creates a new date instance, with the current date
        /// </summary>
        public Date()
        {
            date = DateTime.Now;
            TrafficLight = new TrafficLight(DateTime.Now, "TrafficLight");
            FollowSystem = new FollowSystem(DateTime.Now, "FollowSystem");
        }

        /// <summary>
        /// Gets the date of creation
        /// </summary>
        /// <returns>The date of creation</returns>
        public DateTime GetDate()
        {
            return date;
        }

    }
}
