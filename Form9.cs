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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "NAME IS MISSING");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Address is missing");
            }
            else if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Contact No is missing");
            }
            else if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Mention your post");
            }
            else { 
            AirlinesDataContext db = new AirlinesDataContext();

            Mazdoor mz = new Mazdoor()
            {
                NAME = textBox1.Text,
                ADDRESS = textBox2.Text,
            
 
               CONTACT_NO = textBox3.Text,
                POST = textBox4.Text

            };
            db.Mazdoors.InsertOnSubmit(mz);
            db.SubmitChanges();
            MessageBox.Show("You have Registered yourself");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text="";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
