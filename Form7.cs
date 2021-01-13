using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_management_system
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                Form8 f8 = new Form8();
                f8.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label2.Text = AL.shaks;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AL ai = new AL();
            ai.Show();
        }
    }
}
