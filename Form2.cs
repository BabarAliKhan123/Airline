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
    public partial class Form2 : Form
    {
        private object SelectedItem;

        public Form2()
        {
            InitializeComponent();
        }

        public object SelectedValue { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please Enter Your Name");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please Enter Your Address");
            }
            else if (maskedTextBox1.Text == "")
            {
                errorProvider1.SetError(maskedTextBox1, "Please Enter Your Phone #");
            }
            else if (maskedTextBox2.Text == "")
            {
                errorProvider1.SetError(maskedTextBox2, "Please Enter Your CNIC #");
            }
            else if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Please Enter Your Age");
            }
            else if (textBox6.Text == "")
            {
                errorProvider1.SetError(textBox6, "Please Enter Your Password");
            }
            else
            {
                
                    AirlinesDataContext db = new AirlinesDataContext();
                    AamAdmi am = new AamAdmi()
                    {
                        Name = textBox1.Text,
                        Address = textBox2.Text,
                        Contact_No = maskedTextBox1.Text,
                        Cnic = maskedTextBox2.Text,
                        Age = int.Parse(textBox5.Text),
                        Password = textBox6.Text,
                        Gender = listBox1.ValueMember,
                        Reg_Date = dateTimePicker1.Value

                    };
                    db.AamAdmis.InsertOnSubmit(am);
                    db.SubmitChanges();
                    MessageBox.Show("Mubarak ho ap as a user registerd ho chuke hain");
                    textBox1.Text = textBox2.Text = maskedTextBox1.Text = maskedTextBox2.Text = textBox5.Text = textBox6.Text = "";
                }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = maskedTextBox1.Text = maskedTextBox2.Text = textBox5.Text = textBox6.Text = "";
        }

 
    }
}