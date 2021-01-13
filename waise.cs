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
    public partial class waise : Form
    {
        public waise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirlinesDataContext db = new AirlinesDataContext();
            code cd = new code()
            {
                Airport_code = textBox1.Text,
                Airport_logo_type = textBox2.Text
            };
            db.codes.InsertOnSubmit(cd);
            db.SubmitChanges();
            MessageBox.Show("inserted");

        }
    }
}
