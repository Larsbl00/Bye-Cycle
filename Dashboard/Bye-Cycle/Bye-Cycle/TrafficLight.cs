using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bye_Cycle
{
    class TrafficLight : Data
    {
        List<int> totalTimeRain = new List<int>();
        public int HowManyBicyclesPrioritised { get; private set}

        public TrafficLight()
        {
            
        }
    }
}
