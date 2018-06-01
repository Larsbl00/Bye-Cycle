using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    [Serializable]
    public class FollowSystemData
    {
        public long TimeLightsOn { get; private set; }
        public Side Direction { get; private set; }


        public FollowSystemData(long timeLightsOn, Side direction)
        {
            TimeLightsOn = timeLightsOn;
            Direction = direction;
        }
    }
}
