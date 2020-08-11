namespace WindowsFormsApp1
{
    partial class fOef02
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
            this.tbxNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.numLeeftijd = new System.Windows.Forms.NumericUpDown();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.tbxAnderGeslacht = new System.Windows.Forms.TextBox();
            this.rbAndere = new System.Windows.Forms.RadioButton();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.gbProvincie = new System.Windows.Forms.GroupBox();
            this.rbHenegouwen = new System.Windows.Forms.RadioButton();
            this.rbNamen = new System.Windows.Forms.RadioButton();
            this.rbLuxemburg = new System.Windows.Forms.RadioButton();
            this.rbLuik = new System.Windows.Forms.RadioButton();
            this.rbWaalsBrabant = new System.Windows.Forms.RadioButton();
            this.rbVlaamsBrabant = new System.Windows.Forms.RadioButton();
            this.rbWestVlaanderen = new System.Windows.Forms.RadioButton();
            this.rbOostVlaanderen = new System.Windows.Forms.RadioButton();
            this.rbLimburg = new System.Windows.Forms.RadioButton();
            this.rbAntwerpen = new System.Windows.Forms.RadioButton();
            this.btnIngeven = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).BeginInit();
            this.gbGeslacht.SuspendLayout();
            this.gbProvincie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNaam
            // 
            this.tbxNaam.Location = new System.Drawing.Point(57, 15);
            this.tbxNaam.Name = "tbxNaam";
            this.tbxNaam.Size = new System.Drawing.Size(150, 20);
            this.tbxNaam.TabIndex = 1;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(13, 18);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(13, 44);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(42, 13);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Adress:";
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(57, 41);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(150, 20);
            this.tbxAdress.TabIndex = 2;
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Location = new System.Drawing.Point(13, 70);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(44, 13);
            this.lblLeeftijd.TabIndex = 6;
            this.lblLeeftijd.Text = "Leeftijd:";
            // 
            // numLeeftijd
            // 
            this.numLeeftijd.Location = new System.Drawing.Point(57, 67);
            this.numLeeftijd.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numLeeftijd.Name = "numLeeftijd";
            this.numLeeftijd.Size = new System.Drawing.Size(150, 20);
            this.numLeeftijd.TabIndex = 3;
            this.numLeeftijd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbGeslacht.Controls.Add(this.tbxAnderGeslacht);
            this.gbGeslacht.Controls.Add(this.rbAndere);
            this.gbGeslacht.Controls.Add(this.rbVrouw);
            this.gbGeslacht.Controls.Add(this.rbMan);
            this.gbGeslacht.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbGeslacht.Location = new System.Drawing.Point(16, 93);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(200, 100);
            this.gbGeslacht.TabIndex = 4;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht:";
            // 
            // tbxAnderGeslacht
            // 
            this.tbxAnderGeslacht.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tbxAnderGeslacht.Location = new System.Drawing.Point(73, 68);
            this.tbxAnderGeslacht.Name = "tbxAnderGeslacht";
            this.tbxAnderGeslacht.Size = new System.Drawing.Size(100, 20);
            this.tbxAnderGeslacht.TabIndex = 4;
            // 
            // rbAndere
            // 
            this.rbAndere.AutoSize = true;
            this.rbAndere.Location = new System.Drawing.Point(7, 68);
            this.rbAndere.Name = "rbAndere";
            this.rbAndere.Size = new System.Drawing.Size(62, 17);
            this.rbAndere.TabIndex = 3;
            this.rbAndere.Text = "Andere:";
            this.rbAndere.UseVisualStyleBackColor = true;
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(7, 44);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rbVrouw.TabIndex = 2;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Checked = true;
            this.rbMan.Location = new System.Drawing.Point(7, 20);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 1;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // gbProvincie
            // 
            this.gbProvincie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbProvincie.Controls.Add(this.rbHenegouwen);
            this.gbProvincie.Controls.Add(this.rbNamen);
            this.gbProvincie.Controls.Add(this.rbLuxemburg);
            this.gbProvincie.Controls.Add(this.rbLuik);
            this.gbProvincie.Controls.Add(this.rbWaalsBrabant);
            this.gbProvincie.Controls.Add(this.rbVlaamsBrabant);
            this.gbProvincie.Controls.Add(this.rbWestVlaanderen);
            this.gbProvincie.Controls.Add(this.rbOostVlaanderen);
            this.gbProvincie.Controls.Add(this.rbLimburg);
            this.gbProvincie.Controls.Add(this.rbAntwerpen);
            this.gbProvincie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbProvincie.Location = new System.Drawing.Point(16, 199);
            this.gbProvincie.Name = "gbProvincie";
            this.gbProvincie.Size = new System.Drawing.Size(200, 133);
            this.gbProvincie.TabIndex = 5;
            this.gbProvincie.TabStop = false;
            this.gbProvincie.Text = "Provincie:";
            // 
            // rbHenegouwen
            // 
            this.rbHenegouwen.AutoSize = true;
            this.rbHenegouwen.Location = new System.Drawing.Point(89, 108);
            this.rbHenegouwen.Name = "rbHenegouwen";
            this.rbHenegouwen.Size = new System.Drawing.Size(89, 17);
            this.rbHenegouwen.TabIndex = 17;
            this.rbHenegouwen.Text = "Henegouwen";
            this.rbHenegouwen.UseVisualStyleBackColor = true;
            // 
            // rbNamen
            // 
            this.rbNamen.AutoSize = true;
            this.rbNamen.Location = new System.Drawing.Point(7, 108);
            this.rbNamen.Name = "rbNamen";
            this.rbNamen.Size = new System.Drawing.Size(59, 17);
            this.rbNamen.TabIndex = 12;
            this.rbNamen.Text = "Namen";
            this.rbNamen.UseVisualStyleBackColor = true;
            // 
            // rbLuxemburg
            // 
            this.rbLuxemburg.AutoSize = true;
            this.rbLuxemburg.Location = new System.Drawing.Point(7, 85);
            this.rbLuxemburg.Name = "rbLuxemburg";
            this.rbLuxemburg.Size = new System.Drawing.Size(77, 17);
            this.rbLuxemburg.TabIndex = 11;
            this.rbLuxemburg.Text = "Luxemburg";
            this.rbLuxemburg.UseVisualStyleBackColor = true;
            // 
            // rbLuik
            // 
            this.rbLuik.AutoSize = true;
            this.rbLuik.Location = new System.Drawing.Point(7, 62);
            this.rbLuik.Name = "rbLuik";
            this.rbLuik.Size = new System.Drawing.Size(45, 17);
            this.rbLuik.TabIndex = 10;
            this.rbLuik.Text = "Luik";
            this.rbLuik.UseVisualStyleBackColor = true;
            // 
            // rbWaalsBrabant
            // 
            this.rbWaalsBrabant.AutoSize = true;
            this.rbWaalsBrabant.Location = new System.Drawing.Point(89, 85);
            this.rbWaalsBrabant.Name = "rbWaalsBrabant";
            this.rbWaalsBrabant.Size = new System.Drawing.Size(94, 17);
            this.rbWaalsBrabant.TabIndex = 16;
            this.rbWaalsBrabant.Text = "Waals-brabant";
            this.rbWaalsBrabant.UseVisualStyleBackColor = true;
            // 
            // rbVlaamsBrabant
            // 
            this.rbVlaamsBrabant.AutoSize = true;
            this.rbVlaamsBrabant.Location = new System.Drawing.Point(89, 62);
            this.rbVlaamsBrabant.Name = "rbVlaamsBrabant";
            this.rbVlaamsBrabant.Size = new System.Drawing.Size(99, 17);
            this.rbVlaamsBrabant.TabIndex = 15;
            this.rbVlaamsBrabant.Text = "Vlaams-Brabant";
            this.rbVlaamsBrabant.UseVisualStyleBackColor = true;
            // 
            // rbWestVlaanderen
            // 
            this.rbWestVlaanderen.AutoSize = true;
            this.rbWestVlaanderen.Location = new System.Drawing.Point(89, 39);
            this.rbWestVlaanderen.Name = "rbWestVlaanderen";
            this.rbWestVlaanderen.Size = new System.Drawing.Size(112, 17);
            this.rbWestVlaanderen.TabIndex = 14;
            this.rbWestVlaanderen.Text = "Waals-Vlaanderen";
            this.rbWestVlaanderen.UseVisualStyleBackColor = true;
            // 
            // rbOostVlaanderen
            // 
            this.rbOostVlaanderen.AutoSize = true;
            this.rbOostVlaanderen.Location = new System.Drawing.Point(89, 16);
            this.rbOostVlaanderen.Name = "rbOostVlaanderen";
            this.rbOostVlaanderen.Size = new System.Drawing.Size(104, 17);
            this.rbOostVlaanderen.TabIndex = 13;
            this.rbOostVlaanderen.Text = "Oost-Vlaanderen";
            this.rbOostVlaanderen.UseVisualStyleBackColor = true;
            // 
            // rbLimburg
            // 
            this.rbLimburg.AutoSize = true;
            this.rbLimburg.Location = new System.Drawing.Point(7, 39);
            this.rbLimburg.Name = "rbLimburg";
            this.rbLimburg.Size = new System.Drawing.Size(62, 17);
            this.rbLimburg.TabIndex = 9;
            this.rbLimburg.Text = "Limburg";
            this.rbLimburg.UseVisualStyleBackColor = true;
            // 
            // rbAntwerpen
            // 
            this.rbAntwerpen.AutoSize = true;
            this.rbAntwerpen.Checked = true;
            this.rbAntwerpen.Location = new System.Drawing.Point(7, 16);
            this.rbAntwerpen.Name = "rbAntwerpen";
            this.rbAntwerpen.Size = new System.Drawing.Size(76, 17);
            this.rbAntwerpen.TabIndex = 8;
            this.rbAntwerpen.TabStop = true;
            this.rbAntwerpen.Text = "Antwerpen";
            this.rbAntwerpen.UseVisualStyleBackColor = true;
            // 
            // btnIngeven
            // 
            this.btnIngeven.Location = new System.Drawing.Point(16, 338);
            this.btnIngeven.Name = "btnIngeven";
            this.btnIngeven.Size = new System.Drawing.Size(201, 38);
            this.btnIngeven.TabIndex = 18;
            this.btnIngeven.Text = "Ingeven";
            this.btnIngeven.UseVisualStyleBackColor = true;
            this.btnIngeven.Click += new System.EventHandler(this.btnIngeven_Click);
            // 
            // fOef02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 393);
            this.Controls.Add(this.btnIngeven);
            this.Controls.Add(this.gbProvincie);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.numLeeftijd);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.tbxNaam);
            this.Name = "fOef02";
            this.Text = "Oef02";
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).EndInit();
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.gbProvincie.ResumeLayout(false);
            this.gbProvincie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.NumericUpDown numLeeftijd;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.TextBox tbxAnderGeslacht;
        private System.Windows.Forms.RadioButton rbAndere;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.GroupBox gbProvincie;
        private System.Windows.Forms.RadioButton rbHenegouwen;
        private System.Windows.Forms.RadioButton rbNamen;
        private System.Windows.Forms.RadioButton rbLuxemburg;
        private System.Windows.Forms.RadioButton rbLuik;
        private System.Windows.Forms.RadioButton rbWaalsBrabant;
        private System.Windows.Forms.RadioButton rbVlaamsBrabant;
        private System.Windows.Forms.RadioButton rbWestVlaanderen;
        private System.Windows.Forms.RadioButton rbOostVlaanderen;
        private System.Windows.Forms.RadioButton rbLimburg;
        private System.Windows.Forms.RadioButton rbAntwerpen;
        private System.Windows.Forms.Button btnIngeven;
    }
}