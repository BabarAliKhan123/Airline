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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            AirlinesDataContext db = new AirlinesDataContext();
            int LB = Convert.ToInt32(listBox1.SelectedValue);
          /*  var ma = from mz in db.Mazdoors
                         where mz.Id == LB
                         select mz;*/
            var MAZ = db.Mazdoors.First(c => c.Id == LB);
            textBox1.Text = MAZ.NAME;
            textBox2.Text = MAZ.ADDRESS;
            textBox3.Text = MAZ.CONTACT_NO;
            textBox4.Text = MAZ.POST;

        }

        private void babar()
        {
            AirlinesDataContext db = new AirlinesDataContext();
            listBox1.DataSource = db.Mazdoors;
            listBox1.DisplayMember = "NAME";
            listBox1.ValueMember = "Id";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Name is missing");
                
            }
           else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Address is missing");

            }
            else if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Contact # is missing");

            }
            else if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Post is missing");

            }
            AirlinesDataContext db = new AirlinesDataContext();
            int LB = Convert.ToInt32(listBox1.SelectedValue);
            var MAZ = db.Mazdoors.First(c => c.Id == LB);
            MAZ.NAME = textBox1.Text;
            MAZ.ADDRESS = textBox2.Text;
            MAZ.CONTACT_NO = textBox3.Text;
            MAZ.POST = textBox4.Text;
            MessageBox.Show("Employee's Records has been updated Successfully");
            db.SubmitChanges();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirlinesDataContext db = new AirlinesDataContext();
            int LB = Convert.ToInt32(listBox1.SelectedValue);
            var MAZ = db.Mazdoors.First(c => c.Id == LB);
            db.Mazdoors.DeleteOnSubmit(MAZ);
                    db.SubmitChanges();
            MessageBox.Show("Targeted Employee has been Deleted");
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            babar();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AL ai = new AL();
            ai.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            babar();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
