using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    [Serializable]
    public abstract class Data
    {
        public DateTime Date { get; private set; }
        public String Name { get; private set; }

        public Data(DateTime Date, string Name)
        {
            this.Name = Name;
            this.Date = Date;
        }
    }
}
