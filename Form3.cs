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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (IsvalidUser(txt1.Text, tXT2.Text))

            {

                this.Hide();
                AL al = new AL();
                al.Show();
               this.Hide();
                MessageBox.Show("Verification Successful");
            }
            else
            {
                MessageBox.Show(" You are not an Admin");
            }





        }



        private bool IsvalidUser(string userName, string password)

        {



            AirlinesDataContext context = new AirlinesDataContext();

            var q = from p in context.codes

                    where p.Airport_code == txt1.Text && p.Airport_logo_type==tXT2.Text

                   

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



