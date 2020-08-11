using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsForms2
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void btnOef1_Click(object sender, EventArgs e)
        {
            fOef01 oef01 = new fOef01();
            oef01.Show();
        }

        private void btnOef02_Click(object sender, EventArgs e)
        {
            fOef02 oef02 = new fOef02();
            oef02.Show();
        }

        private void btnOef03_Click(object sender, EventArgs e)
        {
            fOef03 oef03 = new fOef03();
            oef03.Show();
        }
    }
}
