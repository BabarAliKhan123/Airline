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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            label13.Text = Form11.name;
            label14.Text = Form11.Address;
            label15.Text = Form11.contact;
            label16.Text = Form11.Cnic;
            label17.Text = Form11.Age;
            label18.Text = Form11.Flight_No;
            label19.Text = Form11.Departure_Date;
            label20.Text = Form11.Arrival_Date;
            label21.Text = Form11.Passport_No;
            label22.Text = Form11.Passport_Type;
            



        }
    }
}
