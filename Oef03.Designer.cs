namespace WindowsFormsApp1
{
    partial class fOef03
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGeefDatum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnGeefDatum
            // 
            this.btnGeefDatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeefDatum.Location = new System.Drawing.Point(13, 148);
            this.btnGeefDatum.Name = "btnGeefDatum";
            this.btnGeefDatum.Size = new System.Drawing.Size(231, 45);
            this.btnGeefDatum.TabIndex = 1;
            this.btnGeefDatum.Text = "Geef datum";
            this.btnGeefDatum.UseVisualStyleBackColor = true;
            this.btnGeefDatum.Click += new System.EventHandler(this.btnGeefDatum_Click);
            // 
            // fOef03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 216);
            this.Controls.Add(this.btnGeefDatum);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "fOef03";
            this.Text = "Oef03";
            this.Load += new System.EventHandler(this.fOef03_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGeefDatum;
    }
}