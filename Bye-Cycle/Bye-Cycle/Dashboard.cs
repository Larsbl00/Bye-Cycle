using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bye_Cycle
{
    public partial class Dashboard : Form
    {
        Thread MainThread = null;
        private Administration administration;
        public Dashboard()
        {
            InitializeComponent();
            administration = new Administration();
            MainThread = Thread.CurrentThread;

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                this.Invoke(new MethodInvoker(delegate {
                    // Execute the following code on the GUI thread.
                    listBoxData.Items.Add(administration.ReadMessage());
                }));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();
            UpdateForm();
        }

        private void UpdateForm()
        {
            foreach (Data data in administration.data)
            {
                listBoxData.Items.Add(data.Date);
            }
        }


    }
}
