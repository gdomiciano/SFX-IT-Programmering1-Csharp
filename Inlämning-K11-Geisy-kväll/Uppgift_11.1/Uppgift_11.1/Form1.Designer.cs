namespace Uppgift_11._1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.btnLägg = new System.Windows.Forms.Button();
            this.tbxKontakter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(90, 12);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxFörnamn.TabIndex = 4;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(306, 12);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(100, 20);
            this.tbxEfternamn.TabIndex = 5;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(90, 57);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefon.TabIndex = 6;
            // 
            // btnLägg
            // 
            this.btnLägg.Location = new System.Drawing.Point(231, 53);
            this.btnLägg.Name = "btnLägg";
            this.btnLägg.Size = new System.Drawing.Size(175, 23);
            this.btnLägg.TabIndex = 7;
            this.btnLägg.Text = "button1";
            this.btnLägg.UseVisualStyleBackColor = true;
            // 
            // tbxKontakter
            // 
            this.tbxKontakter.Location = new System.Drawing.Point(13, 108);
            this.tbxKontakter.Multiline = true;
            this.tbxKontakter.Name = "tbxKontakter";
            this.tbxKontakter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxKontakter.Size = new System.Drawing.Size(393, 195);
            this.tbxKontakter.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 322);
            this.Controls.Add(this.tbxKontakter);
            this.Controls.Add(this.btnLägg);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.Button btnLägg;
        private System.Windows.Forms.TextBox tbxKontakter;
    }
}

