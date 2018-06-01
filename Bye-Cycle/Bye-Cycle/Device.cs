using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    [Serializable]
    public class Device
    {
        /// <summary>
        /// Construction year of the device
        /// </summary>
        public DateTime BuildYear { get; private set; }

        /// <summary>
        /// Name of the device
        /// </summary>
        public String Name { get; private set; }

        /// <summary>
        /// Last time the device was activated
        /// </summary>
        public DateTime LastTimeActive { get; protected set; }


        public Device(DateTime buildYear, string name)
        {
            this.BuildYear = buildYear;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name.ToString() + ": Construction year:" + BuildYear.ToString() + ", Last Time Active: " + LastTimeActive.ToString();
        }
    }
}
