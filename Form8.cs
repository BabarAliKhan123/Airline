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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please enter Flight No");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please enter Airport Name");
            }
            else if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "This Field is required");
            }
            else if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "This Field is required");
            }
            else 
            {
                AirlinesDataContext db = new AirlinesDataContext();
                FlightInfo fi = new FlightInfo()
                {
                    Flight_No = int.Parse(textBox1.Text),
                    Airport = textBox2.Text,
                    From = textBox3.Text,
                    To = textBox4.Text,
                    Departure_Date = dateTimePicker1.Value,
                    Arrival_Date = dateTimePicker2.Value,

                };
                db.FlightInfos.InsertOnSubmit(fi);
                db.SubmitChanges();
                MessageBox.Show("Flight Details have been Submitted");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";

            }

 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AL ai = new AL();
            ai.Show();
        }
    }
}