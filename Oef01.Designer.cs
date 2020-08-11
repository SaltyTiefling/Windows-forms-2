namespace WindowsFormsApp1
{
    partial class fOef01
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
            this.tbxToevoegen = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lbxFirstList = new System.Windows.Forms.ListBox();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.btnToRight = new System.Windows.Forms.Button();
            this.lbxSecondList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxToevoegen
            // 
            this.tbxToevoegen.Location = new System.Drawing.Point(13, 13);
            this.tbxToevoegen.Name = "tbxToevoegen";
            this.tbxToevoegen.Size = new System.Drawing.Size(120, 20);
            this.tbxToevoegen.TabIndex = 0;
            this.tbxToevoegen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxToevoegen_KeyDown);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(139, 13);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(83, 20);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lbxFirstList
            // 
            this.lbxFirstList.FormattingEnabled = true;
            this.lbxFirstList.Location = new System.Drawing.Point(13, 39);
            this.lbxFirstList.Name = "lbxFirstList";
            this.lbxFirstList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxFirstList.Size = new System.Drawing.Size(120, 95);
            this.lbxFirstList.TabIndex = 2;
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(139, 57);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnToLeft.TabIndex = 3;
            this.btnToLeft.Text = "=>";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(139, 86);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(75, 23);
            this.btnToRight.TabIndex = 4;
            this.btnToRight.Text = "<=";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // lbxSecondList
            // 
            this.lbxSecondList.FormattingEnabled = true;
            this.lbxSecondList.Location = new System.Drawing.Point(220, 39);
            this.lbxSecondList.Name = "lbxSecondList";
            this.lbxSecondList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxSecondList.Size = new System.Drawing.Size(120, 95);
            this.lbxSecondList.TabIndex = 5;
            // 
            // fOef01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 183);
            this.Controls.Add(this.lbxSecondList);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.lbxFirstList);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.tbxToevoegen);
            this.Name = "fOef01";
            this.Text = "Reeks1 oef01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxToevoegen;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ListBox lbxFirstList;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.ListBox lbxSecondList;
    }
}