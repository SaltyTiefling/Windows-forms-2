using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fOef03 : Form
    {
        public fOef03()
        {
            InitializeComponent();
        }

        private void fOef03_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
        }

        private void btnGeefDatum_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{dateTimePicker1.Value.ToString("hh/MM/ss")}");
        }
    }
}
