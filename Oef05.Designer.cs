namespace WindowsFormsApp1
{
    partial class fOef05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.txtNewFilename = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.btnLoadFromDirectory = new System.Windows.Forms.Button();
            this.btnWriteToDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxFiles
            // 
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.Location = new System.Drawing.Point(31, 25);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxFiles.Size = new System.Drawing.Size(129, 95);
            this.lbxFiles.TabIndex = 0;
            // 
            // txtNewFilename
            // 
            this.txtNewFilename.Location = new System.Drawing.Point(166, 25);
            this.txtNewFilename.Name = "txtNewFilename";
            this.txtNewFilename.Size = new System.Drawing.Size(100, 20);
            this.txtNewFilename.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(167, 81);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(99, 23);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnLoadFromDirectory
            // 
            this.btnLoadFromDirectory.Location = new System.Drawing.Point(31, 155);
            this.btnLoadFromDirectory.Name = "btnLoadFromDirectory";
            this.btnLoadFromDirectory.Size = new System.Drawing.Size(129, 23);
            this.btnLoadFromDirectory.TabIndex = 5;
            this.btnLoadFromDirectory.Text = "Load from directory";
            this.btnLoadFromDirectory.UseVisualStyleBackColor = true;
            this.btnLoadFromDirectory.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWriteToDirectory
            // 
            this.btnWriteToDirectory.Location = new System.Drawing.Point(31, 126);
            this.btnWriteToDirectory.Name = "btnWriteToDirectory";
            this.btnWriteToDirectory.Size = new System.Drawing.Size(129, 23);
            this.btnWriteToDirectory.TabIndex = 4;
            this.btnWriteToDirectory.Text = "Write to directory";
            this.btnWriteToDirectory.UseVisualStyleBackColor = true;
            this.btnWriteToDirectory.Click += new System.EventHandler(this.btnWriteToDirectory_Click);
            // 
            // fOef05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 466);
            this.Controls.Add(this.btnLoadFromDirectory);
            this.Controls.Add(this.btnWriteToDirectory);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewFilename);
            this.Controls.Add(this.lbxFiles);
            this.Name = "fOef05";
            this.Text = "Oef05";
            this.Load += new System.EventHandler(this.fOef05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.TextBox txtNewFilename;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button btnLoadFromDirectory;
        private System.Windows.Forms.Button btnWriteToDirectory;
    }
}