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
            this.btnOef03 = new System.Windows.Forms.Button();
            this.btnOef04 = new System.Windows.Forms.Button();
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
            this.btnOef02.Location = new System.Drawing.Point(139, 37);
            this.btnOef02.Name = "btnOef02";
            this.btnOef02.Size = new System.Drawing.Size(100, 100);
            this.btnOef02.TabIndex = 1;
            this.btnOef02.Text = "reeks 1 oef 2";
            this.btnOef02.UseVisualStyleBackColor = true;
            this.btnOef02.Click += new System.EventHandler(this.btnOef02_Click);
            // 
            // btnOef03
            // 
            this.btnOef03.Location = new System.Drawing.Point(33, 143);
            this.btnOef03.Name = "btnOef03";
            this.btnOef03.Size = new System.Drawing.Size(100, 100);
            this.btnOef03.TabIndex = 2;
            this.btnOef03.Text = "reeks 1 oef 3";
            this.btnOef03.UseVisualStyleBackColor = true;
            this.btnOef03.Click += new System.EventHandler(this.btnOef03_Click);
            // 
            // btnOef04
            // 
            this.btnOef04.Location = new System.Drawing.Point(139, 143);
            this.btnOef04.Name = "btnOef04";
            this.btnOef04.Size = new System.Drawing.Size(100, 100);
            this.btnOef04.TabIndex = 3;
            this.btnOef04.Text = "reeks 1 oef 4";
            this.btnOef04.UseVisualStyleBackColor = true;
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 278);
            this.Controls.Add(this.btnOef04);
            this.Controls.Add(this.btnOef03);
            this.Controls.Add(this.btnOef02);
            this.Controls.Add(this.btnOef1);
            this.Name = "fMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOef1;
        private System.Windows.Forms.Button btnOef02;
        private System.Windows.Forms.Button btnOef03;
        private System.Windows.Forms.Button btnOef04;
    }
}

