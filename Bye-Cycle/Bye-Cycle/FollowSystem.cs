using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    [Serializable]
    class FollowSystem : Data
    {
        [NonSerialized]
        private Stopwatch stopwatch = new Stopwatch();

        private List<string> timeLightsOn;

        private Side side;

        public List<string> TimeLightsOn
        {
            get { return new List<string>(timeLightsOn); }
        }

        public int HowManyBikesOnLane { get; private set; }

        private int PrefferedSide;
        public Side Side { get
            {
                if (PrefferedSide == 0)
                {
                    return Side.None;
                }
                else if(PrefferedSide < 0)
                {
                    return Side.Left;
                }
                else if (PrefferedSide > 0)
                {
                    return Side.Right;
                }
                return Side.None;
            }}


        public FollowSystem(DateTime currentDay, string name) : base(currentDay, name)
        {
            timeLightsOn = new List<string>();
        }

        /* This method culculates the the time the lights were on
         * this info is stored in a list, the index of the list is how many times the lights were on.
         */ 
        public void AddLightsOn(long lightsOn)
        {
            timeLightsOn.Add("Time=" + Math.Round((double)lightsOn/1000, 2) + "s" + ", Direction: " + side.ToString());
        }

        /*This method changes the prefferedside, the input is a bool True = left and false is right.
         * If prefferedside is above 0 prefferedside = left if its below 0 preffered side is right.
         * It also counts how many bikes there have been.
         */
        public void CalculatePreferredSide(bool side)
        {
            HowManyBikesOnLane++;
            if (side)
            {
                //If a bikes comes from the left.
                PrefferedSide ++;
                this.side = Side.Left;
            }
            else
            {
                //If a bikes comes from the right.
                PrefferedSide --;
                this.side = Side.Right;
            }
        }

        // This method turns off the followingsystem, this makes it so that the light are always on if it is dark.
        public void TurnOffFollowSystem()
        {
            
        }
    }
}
