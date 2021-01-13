using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;



namespace Airline_management_system
{
    public partial class Form5 : Form
    {

        public static string name = "";
        
        public Form5()
        {
            InitializeComponent();
        }

        public object Session { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            

                if (IsvalidUser(textBox1.Text, textBox2.Text))

                {
                name = textBox1.Text;
                
                    

                    

                    Form6 F6 = new Form6();

                    F6.Show();
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

            var q = from p in context.AamAdmis

                        where p.Name == textBox1.Text

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

 //   internal class Session
  //  {
   // }
}







   




        
    

