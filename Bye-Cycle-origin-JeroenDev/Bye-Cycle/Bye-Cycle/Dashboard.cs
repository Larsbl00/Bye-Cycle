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
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                administration.ReadMessage();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            listBoxData.Items.Clear();
            try
            {
                foreach (string command in administration.Test)
                {
                    if (command != null)
                    {
                        listBoxData.Items.Add(command);
                    }
                }
            }
            catch (InvalidOperationException e)
            {

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
