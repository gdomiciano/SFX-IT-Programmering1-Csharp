namespace Uppgift_5._3
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
            this.lblTexten = new System.Windows.Forms.Label();
            this.lblTäljare = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOmvandla = new System.Windows.Forms.Button();
            this.txbTäljare = new System.Windows.Forms.TextBox();
            this.txbNämnare = new System.Windows.Forms.TextBox();
            this.lblFel = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexten
            // 
            this.lblTexten.AutoSize = true;
            this.lblTexten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexten.Location = new System.Drawing.Point(171, 47);
            this.lblTexten.Name = "lblTexten";
            this.lblTexten.Size = new System.Drawing.Size(417, 20);
            this.lblTexten.TabIndex = 0;
            this.lblTexten.Text = "Mata in täljare och nämare för att få bråktals blandad form";
            // 
            // lblTäljare
            // 
            this.lblTäljare.AutoSize = true;
            this.lblTäljare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTäljare.Location = new System.Drawing.Point(308, 93);
            this.lblTäljare.Name = "lblTäljare";
            this.lblTäljare.Size = new System.Drawing.Size(56, 17);
            this.lblTäljare.TabIndex = 1;
            this.lblTäljare.Text = "Täljare:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nämnare:";
            // 
            // btnOmvandla
            // 
            this.btnOmvandla.Location = new System.Drawing.Point(331, 173);
            this.btnOmvandla.Name = "btnOmvandla";
            this.btnOmvandla.Size = new System.Drawing.Size(75, 23);
            this.btnOmvandla.TabIndex = 3;
            this.btnOmvandla.Text = "Omvandla";
            this.btnOmvandla.UseVisualStyleBackColor = true;
            this.btnOmvandla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbTäljare
            // 
            this.txbTäljare.Location = new System.Drawing.Point(371, 93);
            this.txbTäljare.Name = "txbTäljare";
            this.txbTäljare.Size = new System.Drawing.Size(100, 20);
            this.txbTäljare.TabIndex = 4;
            this.txbTäljare.TextChanged += new System.EventHandler(this.klaraTexter);
            // 
            // txbNämnare
            // 
            this.txbNämnare.Location = new System.Drawing.Point(371, 130);
            this.txbNämnare.Name = "txbNämnare";
            this.txbNämnare.Size = new System.Drawing.Size(100, 20);
            this.txbNämnare.TabIndex = 5;
            this.txbNämnare.TextChanged += new System.EventHandler(this.klaraTexter);
            // 
            // lblFel
            // 
            this.lblFel.AutoSize = true;
            this.lblFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFel.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFel.Location = new System.Drawing.Point(272, 206);
            this.lblFel.Name = "lblFel";
            this.lblFel.Size = new System.Drawing.Size(0, 17);
            this.lblFel.TabIndex = 6;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSvar.Location = new System.Drawing.Point(256, 206);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 17);
            this.lblSvar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblFel);
            this.Controls.Add(this.txbNämnare);
            this.Controls.Add(this.txbTäljare);
            this.Controls.Add(this.btnOmvandla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTäljare);
            this.Controls.Add(this.lblTexten);
            this.Name = "Form1";
            this.Text = "Bråktal till blandad form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexten;
        private System.Windows.Forms.Label lblTäljare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOmvandla;
        private System.Windows.Forms.TextBox txbTäljare;
        private System.Windows.Forms.TextBox txbNämnare;
        private System.Windows.Forms.Label lblFel;
        private System.Windows.Forms.Label lblSvar;
    }
}

