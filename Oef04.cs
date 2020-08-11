using Oef01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms2.Properties;

namespace WindowsFormsApp1
{
    public partial class fOef04 : Form
    {
        Notitieboekje boekje = new Notitieboekje();
        public fOef04()
        {
            InitializeComponent();
        }

        private void fOef04_Load(object sender, EventArgs e)
        {


        }
        public void UpdateNotietielijst()
        {
            lbxNotitieboekje.Items.Clear();
            foreach (var item in boekje.BekijkNotities())
            {
                lbxNotitieboekje.Items.Add(item);
            }

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Inputbox input = new Inputbox();
            input.ShowDialog();
            boekje.Bijschrijven(input.answer, "");
            UpdateNotietielijst();
        }

        private void btnScheurUit_Click(object sender, EventArgs e)
        {
            foreach (var item in lbxNotitieboekje.SelectedItems)
            {
                boekje.Uitscheuren(item.ToString());
            }

            UpdateNotietielijst();
        }

        private void btnBijschrijven_Click(object sender, EventArgs e)
        {
            foreach (var item in lbxNotitieboekje.SelectedItems)
            {
                boekje.VulNotitieAan(item.ToString(), tbxBijschrijven.Text.ToString());
            }
            UpdateNotietielijst();
        }

        private void lbxNotitieboekje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxNotitieboekje.SelectedIndex >= 0)
            {
                tbxNotitie.Text = boekje.BekijkNotitie(lbxNotitieboekje.SelectedIndex).opschrift;
            }
        }


        private void tbxBijschrijven_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBijschrijven_Click(sender, e);
            }

        }

        private void btnLamineren_Click(object sender, EventArgs e)
        {
            foreach (var item in ActiveForm.Controls.OfType<Button>())
            {
                item.Enabled = false;
            }

            tbxBijschrijven.Enabled = false;

        }
    }
}
