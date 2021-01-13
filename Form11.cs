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
    public partial class Form11 : Form
    {
        public static string name = "";
        public static string Address = "";
        public static string contact = "";
        public static string Cnic = "";
        public static string Age = "";
        public static string Flight_No = "";
        public static string Departure_Date = "";
        public static string Arrival_Date = "";
        public static string Passport_No = "";
        public static string Passport_Type = "";
        






        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AirlinesDataContext db = new AirlinesDataContext();
            var fd = from f in db.FlightInfos
                     select f;
            dataGridView1.DataSource = fd;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            Address = textBox2.Text;
            contact = textBox3.Text;
            Cnic = maskedTextBox2.Text;
            Age = textBox4.Text;
            Flight_No = textBox5.Text;
            Departure_Date = dateTimePicker1.Text;
            Arrival_Date = dateTimePicker2.Text;
            Passport_No = maskedTextBox1.Text;
            Passport_Type = listBox1.ValueMember;



            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please write your Name");

            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please write your Address");

            }
            else if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Please write your Contact No");

            }
            else if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Please write your Age");

            }
            else if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Please write your Flight No");

            }
            else
            {
                AirlinesDataContext db = new AirlinesDataContext();
                TICKETBOOKDETAIL tbt = new TICKETBOOKDETAIL()
                {
                    Name = textBox1.Text,
                    Address = textBox2.Text,
                    Contact = textBox3.Text,
                    Cnic = maskedTextBox2.Text,
                    Age = int.Parse(textBox4.Text),
                    Flight_No = int.Parse(textBox5.Text),
                    Departure_Date = dateTimePicker1.Value,
                    Arrival_Date = dateTimePicker2.Value,
                    Passport_No = maskedTextBox1.Text,
                    Passport_Type = listBox1.ValueMember

                };
                db.TICKETBOOKDETAILs.InsertOnSubmit(tbt);
                db.SubmitChanges();
                MessageBox.Show("Your Ticket Booked successfully");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = maskedTextBox1.Text = maskedTextBox2.Text = "";
                Form12 f12 = new Form12();
                f12.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Hide();


            Form5 f5 = new Form5();
            f5.Show();
           // Form6 f6 = new Form6();
           // f6.Hide();
 


        }
    }
    }
