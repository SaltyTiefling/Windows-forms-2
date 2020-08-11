namespace WindowsForms2
{
    partial class fMenu
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
            this.btnOef1 = new System.Windows.Forms.Button();
            this.btnOef02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOef1
            // 
            this.btnOef1.Location = new System.Drawing.Point(33, 37);
            this.btnOef1.Name = "btnOef1";
            this.btnOef1.Size = new System.Drawing.Size(100, 100);
            this.btnOef1.TabIndex = 0;
            this.btnOef1.Text = "reeks 1 oef 1";
            this.btnOef1.UseVisualStyleBackColor = true;
            this.btnOef1.Click += new System.EventHandler(this.btnOef1_Click);
            // 
            // btnOef02
            // 
            this.btnOef02.Location = new System.Drawing.Point(33, 143);
            this.btnOef02.Name = "btnOef02";
            this.btnOef02.Size = new System.Drawing.Size(100, 100);
            this.btnOef02.TabIndex = 1;
            this.btnOef02.Text = "reeks 1 oef 2";
            this.btnOef02.UseVisualStyleBackColor = true;
            this.btnOef02.Click += new System.EventHandler(this.btnOef02_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOef02);
            this.Controls.Add(this.btnOef1);
            this.Name = "fMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOef1;
        private System.Windows.Forms.Button btnOef02;
    }
}

