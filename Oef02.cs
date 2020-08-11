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
    public partial class fOef02 : Form
    {
        public fOef02()
        {
            InitializeComponent();
        }

        private void btnIngeven_Click(object sender, EventArgs e)
        {
            string geslacht = gbGeslacht.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault().Text;
            if (geslacht.Equals(rbAndere.Text))
            {
                geslacht = tbxAnderGeslacht.Text;
            }

            MessageBox.Show(
                $"Naam: {tbxNaam.Text}\n" +
                $"Adress: {tbxAdress.Text}\n" +
                $"Leeftijd: {numLeeftijd.Value}\n" +
                $"Geslacht: {geslacht}\n" +
                $"provincie: {gbProvincie.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault().Text}");
        }
    }
}
