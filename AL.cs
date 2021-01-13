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
    public partial class AL : Form
    {
        public static string shaks = "";
        public AL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shaks = textBox1.Text;
            if (IsvalidUser(textBox1.Text, textBox2.Text))

            {
               





                Form7 F7 = new Form7();

                F7.Show();
                this.Hide();

                MessageBox.Show("Succesfull login");
            }
            else
            {
                MessageBox.Show("invalid login");
            }


        }



        private bool IsvalidUser(string userName, string password)

        {



            AirlinesDataContext context = new AirlinesDataContext();

            var q = from p in context.Admins
                    where p.Admin_Name == textBox1.Text

                      && p.Password == textBox2.Text

                    select p;



            if (q.Any())

            {

                return true;

            }

            else

            {

                return false;





            }
        }
    }
}
