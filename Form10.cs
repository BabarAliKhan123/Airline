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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirlinesDataContext db = new AirlinesDataContext();
            var emp = from em in db.Mazdoors
                      select em;
            dataGridView1.DataSource = emp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Name is missing");
            }
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Contact No is missing");
            }
            else if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Post is missing");
            }
            else
            {
                AirlinesDataContext db = new AirlinesDataContext();
                EmployeeSalary emps = new EmployeeSalary()
                {
                    Name = textBox1.Text,
                    Contact_No = textBox2.Text,
                    Post = textBox3.Text
                };
                db.EmployeeSalaries.InsertOnSubmit(emps);
                db.SubmitChanges();
                MessageBox.Show("salary added");
                textBox1.Text = textBox2.Text = textBox3.Text =textBox4.Text= "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AL ai = new AL();
            ai.Show();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowindex];
            textBox1.Text = selectedRow.Cells[1].Value.ToString();
            textBox2.Text = selectedRow.Cells[3].Value.ToString();
            textBox3.Text = selectedRow.Cells[4].Value.ToString();


        }
    }
}