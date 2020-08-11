using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fOef05 : Form
    {
        public fOef05()
        {
            InitializeComponent();
        }

        private void fOef05_Load(object sender, EventArgs e)
        {
            if (!File.Exists("test.txt"))
            {
                File.Create("test.txt").Dispose();
            }
            UpdateFilelijst();

        }
        public void UpdateFilelijst()
        {
            lbxFiles.Items.Clear();
            foreach (var item in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt"))
            {
                lbxFiles.Items.Add(item.Replace(Directory.GetCurrentDirectory() + "\\", "").Replace(".txt", ""));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateFilelijst();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtNewFilename + ".txt"))
            {
                File.Create(txtNewFilename.Text.ToString() + ".txt").Dispose();
            }
            UpdateFilelijst();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in lbxFiles.SelectedItems)
            {
                File.Delete(item.ToString() + ".txt");
            }
            UpdateFilelijst();
        }

        private void btnWriteToDirectory_Click(object sender, EventArgs e)
        {
            foreach (var item in lbxFiles.Items)
            {
                if (!File.Exists(txtNewFilename + ".txt"))
                {
                    File.Create(item + ".txt").Dispose();
                }
            }
            UpdateFilelijst();
        }
    }
}
