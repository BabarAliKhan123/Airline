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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            if (textBox1.Text == "")
            {
                errorProvider2.SetError(textBox1, "Please enter the Name");
            }
           else if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "Please enter the Password");
            }
            else if (maskedTextBox1.Text == "")
            {
                errorProvider2.SetError(maskedTextBox1, "Please enter Your CNIC ");
            }
            else if (maskedTextBox2.Text == "")
            {
                errorProvider2.SetError(maskedTextBox2, "Please enter the Contact No");
            }
            else
            {
                AirlinesDataContext db = new AirlinesDataContext();
                Admin ad = new Admin()
                {
                    Admin_Name = textBox1.Text,
                    Admin_Cnic = maskedTextBox1.Text,
                    Password=textBox2.Text,
                    Admin_Contact_No=maskedTextBox2.Text
                    
                };
                db.Admins.InsertOnSubmit(ad);
                db.SubmitChanges();
                MessageBox.Show("Admin details has saved successfully");
                textBox1.Text = maskedTextBox1.Text = maskedTextBox2.Text =textBox2.Text= "";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = maskedTextBox1.Text = maskedTextBox2.Text =textBox2.Text= "";

        }
    }
}

