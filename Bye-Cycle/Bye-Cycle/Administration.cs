using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Bye_Cycle
{
    class Administration
    {

        private List<Data> data;
        private CommunicationArduino communicationArduino;
        public Administration()
        {
            data  = new List<Data>();
            communicationArduino = new CommunicationArduino();

        }

        public string readMessage()
        {
            return communicationArduino.ReadMessage();
        }































        public Data AddData()
        {
            return null;
        }

        public Data Getdata(DateTime data)
        {
            return null;
        }

        public void Save()
        {
            
        }

        public void Delete()
        {
            
        }

        public void Backup()
        {
           
        }

        public void Change()
        {
            
        }
    }
}
