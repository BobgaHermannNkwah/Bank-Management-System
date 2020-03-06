using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public partial class DashBoard1 : UserControl
    {
        public DashBoard1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            CreateNewAccount test = new CreateNewAccount();
            this.Controls.Add(test);
            test.BringToFront();
        }
    }
}
