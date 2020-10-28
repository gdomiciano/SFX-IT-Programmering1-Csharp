namespace Uppgift_13._2
{
    partial class Uppgift_13_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxParentesFöljd = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnKontrolera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parentesföljd:";
            // 
            // tbxParentesFöljd
            // 
            this.tbxParentesFöljd.Location = new System.Drawing.Point(176, 34);
            this.tbxParentesFöljd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxParentesFöljd.Name = "tbxParentesFöljd";
            this.tbxParentesFöljd.Size = new System.Drawing.Size(194, 29);
            this.tbxParentesFöljd.TabIndex = 1;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(29, 96);
            this.lblResultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultat.MinimumSize = new System.Drawing.Size(344, 30);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(344, 30);
            this.lblResultat.TabIndex = 2;
            // 
            // btnKontrolera
            // 
            this.btnKontrolera.Location = new System.Drawing.Point(124, 160);
            this.btnKontrolera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKontrolera.Name = "btnKontrolera";
            this.btnKontrolera.Size = new System.Drawing.Size(146, 45);
            this.btnKontrolera.TabIndex = 3;
            this.btnKontrolera.Text = "Kontrolera";
            this.btnKontrolera.UseVisualStyleBackColor = true;
            this.btnKontrolera.Click += new System.EventHandler(this.btnKontrolera_Click);
            // 
            // Uppgift_13_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 224);
            this.Controls.Add(this.btnKontrolera);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.tbxParentesFöljd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Uppgift_13_2";
            this.Text = "Uppgift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxParentesFöljd;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnKontrolera;
    }
}

