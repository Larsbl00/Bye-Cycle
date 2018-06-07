using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    public enum Side
    {
       Unknown,
       Left,
       Right
    }

    [Serializable]
    public class FollowSystem : Device
    {
        public List<FollowSystemData> FollowSystemData { get; private set; }

        /// <summary>
        /// Returns how many people have passed
        /// </summary>
        public int HowManyBikesOnLane { get => FollowSystemData.Count; }

        /// <summary>
        /// Returns the most common direction of the cyclers
        /// </summary>
        public Side PreferedSide { get => preferedSide(); }


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
        public FollowSystem(DateTime buildYear, string name) : base (buildYear, name)
        {
            FollowSystemData = new List<FollowSystemData>();
        }

        /// <summary>
        /// Adds data to FollowSystemData
        /// </summary>
        /// <param name="timeOn"></param>
        /// <param name="side"></param>
        public void AddData(long timeOn, Side side)
        {
            FollowSystemData.Add(new FollowSystemData(timeOn, side));
            base.LastTimeActive = DateTime.Now;
        }

        public override string ToString()
        {
            return base.ToString() + ", Amount of bike: " + HowManyBikesOnLane + ", Prefered side: " + PreferedSide;
        }

    }
}
