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
            SwitchLists(lbxFirstList, lbxSecondList);
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            SwitchLists(lbxSecondList, lbxFirstList);
        }
        public void SwitchLists(ListBox list1, ListBox list2)
        {
            foreach (var item in list1.SelectedItems)
            {
                list2.Items.Add(item);
            }
            for (int i = list1.SelectedItems.Count - 1; i >= 0; i--) list1.Items.Remove(list1.SelectedItems[i]);
        }
    }
}
