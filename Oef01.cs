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
    public partial class fOef01 : Form
    {
        public fOef01()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            lbxFirstList.Items.Add(tbxToevoegen.Text);
            lbxFirstList.SelectedIndex = lbxFirstList.Items.Count - 1;
        }

        private void tbxToevoegen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnToevoegen_Click(sender, e);
            }
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            lbxSecondList.Items.Add(lbxFirstList.SelectedItem);
            lbxFirstList.Items.Remove(lbxFirstList.SelectedItem);
            lbxSecondList.SelectedIndex = lbxSecondList.Items.Count - 1;
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            lbxFirstList.Items.Add(lbxSecondList.SelectedItem);
            lbxSecondList.Items.Remove(lbxSecondList.SelectedItem);
            lbxFirstList.SelectedIndex = lbxFirstList.Items.Count - 1;
        }
    }
}
