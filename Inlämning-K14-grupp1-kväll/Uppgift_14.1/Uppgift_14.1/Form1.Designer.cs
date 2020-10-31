namespace Uppgift_14._1
{
    partial class Uppgift_14_1
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
            this.tbxÅr = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnVisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antal år:";
            // 
            // tbxÅr
            // 
            this.tbxÅr.Location = new System.Drawing.Point(116, 22);
            this.tbxÅr.Name = "tbxÅr";
            this.tbxÅr.Size = new System.Drawing.Size(100, 22);
            this.tbxÅr.TabIndex = 1;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(16, 60);
            this.lblResultat.MinimumSize = new System.Drawing.Size(200, 20);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(200, 20);
            this.lblResultat.TabIndex = 2;
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(42, 99);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(156, 30);
            this.btnVisa.TabIndex = 3;
            this.btnVisa.Text = "Visa kapital";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // Uppgift_14_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 150);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.tbxÅr);
            this.Controls.Add(this.label1);
            this.Name = "Uppgift_14_1";
            this.Text = "Uppgift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxÅr;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnVisa;
    }
}

