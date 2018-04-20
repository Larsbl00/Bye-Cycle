using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bye_Cycle
{
    public partial class Form1 : Form
    {
        private Administration administration;
        public Form1()
        {
            InitializeComponent();
            administration = new Administration();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxData.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                listBoxData.Items.Add(administration.readMessage());
            }
            
        }
    }
}
