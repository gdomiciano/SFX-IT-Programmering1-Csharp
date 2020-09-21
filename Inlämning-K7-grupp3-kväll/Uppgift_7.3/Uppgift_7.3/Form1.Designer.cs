namespace Uppgift_7._3
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
            this.lblLängd = new System.Windows.Forms.Label();
            this.lblWindstyrka = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxLängd = new System.Windows.Forms.TextBox();
            this.txbWindstyrka = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLängd
            // 
            this.lblLängd.AutoSize = true;
            this.lblLängd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLängd.Location = new System.Drawing.Point(71, 35);
            this.lblLängd.Name = "lblLängd";
            this.lblLängd.Size = new System.Drawing.Size(77, 17);
            this.lblLängd.TabIndex = 0;
            this.lblLängd.Text = "Längd (m):";
            // 
            // lblWindstyrka
            // 
            this.lblWindstyrka.AutoSize = true;
            this.lblWindstyrka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindstyrka.Location = new System.Drawing.Point(29, 72);
            this.lblWindstyrka.Name = "lblWindstyrka";
            this.lblWindstyrka.Size = new System.Drawing.Size(118, 17);
            this.lblWindstyrka.TabIndex = 1;
            this.lblWindstyrka.Text = "Windstyrka (m/s):";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.Location = new System.Drawing.Point(63, 128);
            this.lblSvar.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(200, 19);
            this.lblSvar.TabIndex = 2;
            // 
            // tbxLängd
            // 
            this.tbxLängd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLängd.Location = new System.Drawing.Point(163, 29);
            this.tbxLängd.Name = "tbxLängd";
            this.tbxLängd.Size = new System.Drawing.Size(100, 23);
            this.tbxLängd.TabIndex = 3;
            this.tbxLängd.TextChanged += new System.EventHandler(this.klaraSvar);
            // 
            // txbWindstyrka
            // 
            this.txbWindstyrka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWindstyrka.Location = new System.Drawing.Point(163, 69);
            this.txbWindstyrka.Name = "txbWindstyrka";
            this.txbWindstyrka.Size = new System.Drawing.Size(100, 23);
            this.txbWindstyrka.TabIndex = 4;
            this.txbWindstyrka.TextChanged += new System.EventHandler(this.klaraSvar);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(121, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 239);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbWindstyrka);
            this.Controls.Add(this.tbxLängd);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblWindstyrka);
            this.Controls.Add(this.lblLängd);
            this.Name = "Form1";
            this.Text = "Uppgift_7.4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLängd;
        private System.Windows.Forms.Label lblWindstyrka;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxLängd;
        private System.Windows.Forms.TextBox txbWindstyrka;
        private System.Windows.Forms.Button btnOk;
    }
}

