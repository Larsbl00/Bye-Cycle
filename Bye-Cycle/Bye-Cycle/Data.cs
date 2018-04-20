using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    class Data
    {
        public DateTime Date { get; private set; }

        public Data(DateTime Date)
        {
            this.Date = Date;
        }
    }
}
