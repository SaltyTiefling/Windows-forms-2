namespace WindowsFormsApp1
{
    partial class fOef04
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
            this.lblNotitieboekje = new System.Windows.Forms.Label();
            this.lbxNotitieboekje = new System.Windows.Forms.ListBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnScheurUit = new System.Windows.Forms.Button();
            this.lblNotitie = new System.Windows.Forms.Label();
            this.tbxNotitie = new System.Windows.Forms.TextBox();
            this.lblBijschrijven = new System.Windows.Forms.Label();
            this.tbxBijschrijven = new System.Windows.Forms.TextBox();
            this.btnBijschrijven = new System.Windows.Forms.Button();
            this.btnLamineren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotitieboekje
            // 
            this.lblNotitieboekje.AutoSize = true;
            this.lblNotitieboekje.Location = new System.Drawing.Point(12, 9);
            this.lblNotitieboekje.Name = "lblNotitieboekje";
            this.lblNotitieboekje.Size = new System.Drawing.Size(69, 13);
            this.lblNotitieboekje.TabIndex = 0;
            this.lblNotitieboekje.Text = "Notitieboekje";
            // 
            // lbxNotitieboekje
            // 
            this.lbxNotitieboekje.FormattingEnabled = true;
            this.lbxNotitieboekje.Location = new System.Drawing.Point(15, 26);
            this.lbxNotitieboekje.Name = "lbxNotitieboekje";
            this.lbxNotitieboekje.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxNotitieboekje.Size = new System.Drawing.Size(120, 199);
            this.lbxNotitieboekje.TabIndex = 1;
            this.lbxNotitieboekje.SelectedIndexChanged += new System.EventHandler(this.lbxNotitieboekje_SelectedIndexChanged);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(15, 245);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(120, 23);
            this.btnToevoegen.TabIndex = 0;
            this.btnToevoegen.Text = "Voeg notitie toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnScheurUit
            // 
            this.btnScheurUit.Location = new System.Drawing.Point(15, 274);
            this.btnScheurUit.Name = "btnScheurUit";
            this.btnScheurUit.Size = new System.Drawing.Size(120, 23);
            this.btnScheurUit.TabIndex = 2;
            this.btnScheurUit.Text = "Scheur notitie uit";
            this.btnScheurUit.UseVisualStyleBackColor = true;
            this.btnScheurUit.Click += new System.EventHandler(this.btnScheurUit_Click);
            // 
            // lblNotitie
            // 
            this.lblNotitie.AutoSize = true;
            this.lblNotitie.Location = new System.Drawing.Point(141, 9);
            this.lblNotitie.Name = "lblNotitie";
            this.lblNotitie.Size = new System.Drawing.Size(37, 13);
            this.lblNotitie.TabIndex = 3;
            this.lblNotitie.Text = "Notitie";
            // 
            // tbxNotitie
            // 
            this.tbxNotitie.Location = new System.Drawing.Point(141, 26);
            this.tbxNotitie.Multiline = true;
            this.tbxNotitie.Name = "tbxNotitie";
            this.tbxNotitie.ReadOnly = true;
            this.tbxNotitie.Size = new System.Drawing.Size(226, 199);
            this.tbxNotitie.TabIndex = 4;
            // 
            // lblBijschrijven
            // 
            this.lblBijschrijven.AutoSize = true;
            this.lblBijschrijven.Location = new System.Drawing.Point(141, 232);
            this.lblBijschrijven.Name = "lblBijschrijven";
            this.lblBijschrijven.Size = new System.Drawing.Size(60, 13);
            this.lblBijschrijven.TabIndex = 5;
            this.lblBijschrijven.Text = "Bijschrijven";
            // 
            // tbxBijschrijven
            // 
            this.tbxBijschrijven.Location = new System.Drawing.Point(141, 248);
            this.tbxBijschrijven.Name = "tbxBijschrijven";
            this.tbxBijschrijven.Size = new System.Drawing.Size(187, 20);
            this.tbxBijschrijven.TabIndex = 6;
            this.tbxBijschrijven.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxBijschrijven_KeyDown);
            // 
            // btnBijschrijven
            // 
            this.btnBijschrijven.Location = new System.Drawing.Point(334, 248);
            this.btnBijschrijven.Name = "btnBijschrijven";
            this.btnBijschrijven.Size = new System.Drawing.Size(33, 20);
            this.btnBijschrijven.TabIndex = 7;
            this.btnBijschrijven.Text = "->";
            this.btnBijschrijven.UseVisualStyleBackColor = true;
            this.btnBijschrijven.Click += new System.EventHandler(this.btnBijschrijven_Click);
            // 
            // btnLamineren
            // 
            this.btnLamineren.Location = new System.Drawing.Point(268, 280);
            this.btnLamineren.Name = "btnLamineren";
            this.btnLamineren.Size = new System.Drawing.Size(120, 23);
            this.btnLamineren.TabIndex = 8;
            this.btnLamineren.Text = "Lamineren";
            this.btnLamineren.UseVisualStyleBackColor = true;
            this.btnLamineren.Click += new System.EventHandler(this.btnLamineren_Click);
            // 
            // fOef04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 315);
            this.Controls.Add(this.btnLamineren);
            this.Controls.Add(this.btnBijschrijven);
            this.Controls.Add(this.tbxBijschrijven);
            this.Controls.Add(this.lblBijschrijven);
            this.Controls.Add(this.tbxNotitie);
            this.Controls.Add(this.lblNotitie);
            this.Controls.Add(this.btnScheurUit);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lbxNotitieboekje);
            this.Controls.Add(this.lblNotitieboekje);
            this.Name = "fOef04";
            this.Text = "Oef04";
            this.Load += new System.EventHandler(this.fOef04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotitieboekje;
        private System.Windows.Forms.ListBox lbxNotitieboekje;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnScheurUit;
        private System.Windows.Forms.Label lblNotitie;
        private System.Windows.Forms.TextBox tbxNotitie;
        private System.Windows.Forms.Label lblBijschrijven;
        private System.Windows.Forms.TextBox tbxBijschrijven;
        private System.Windows.Forms.Button btnBijschrijven;
        private System.Windows.Forms.Button btnLamineren;
    }
}