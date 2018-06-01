using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    enum Side
    {
       Unknown,
       Left,
       Right
    }

    [Serializable]
    class FollowSystem
    {
        [NonSerialized]
        private Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// Returns how many people have passed
        /// </summary>
        public int HowManyBikesOnLane { get => FollowSystemData.Count; }

        /// <summary>
        /// Returns the most common direction of the cyclers
        /// </summary>
        public Side PreferedSide { get => preferedSide(); }

        /// <summary>
        /// This is the list of all data revolving around the following system
        /// </summary>
        public List<FollowSystemData> FollowSystemData { get; private set; }

        private Side preferedSide()
        {
            if (FollowSystemData == null || FollowSystemData.Count == 0) return Side.Unknown;
            int sideCounter = 0;
            foreach (FollowSystemData data in FollowSystemData)
            {
                switch (data.Direction)
                {
                    case Side.Left:
                        sideCounter--;
                        break;
                    case Side.Right:
                        sideCounter++;
                        break;
                    default: break;
                }
            }
            if (sideCounter < 0)
            {
                return Side.Left;
            }
            else if (sideCounter > 0)
            {
                return Side.Right;
            }
            else
            {
                return Side.Unknown;
            }
        }

        /// <summary>
        /// Creates an instance of the FollowingSystem
        /// </summary>
        /// <param name="buildYear"></param>
        /// <param name="name"></param>
        /// <param name="lastTimeActive"></param>
        public FollowSystem(DateTime buildYear, string name, DateTime lastTimeActive)
        {
            FollowSystemData = new List<FollowSystemData>();
        }

    }
}
