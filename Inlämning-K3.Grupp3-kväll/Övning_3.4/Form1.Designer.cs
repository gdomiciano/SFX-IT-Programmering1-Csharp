namespace Övning_3._4
{
    partial class Uttgsautomat
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
            this.lblBelopp = new System.Windows.Forms.Label();
            this.txbBelopp = new System.Windows.Forms.TextBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblFel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexten
            // 
            this.lblTexten.AutoSize = true;
            this.lblTexten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexten.Location = new System.Drawing.Point(110, 26);
            this.lblTexten.Name = "lblTexten";
            this.lblTexten.Size = new System.Drawing.Size(454, 20);
            this.lblTexten.TabIndex = 0;
            this.lblTexten.Text = "Skriv in ett belopp nedan för att se hur stort uttag kan du kan ta";
            // 
            // lblBelopp
            // 
            this.lblBelopp.AutoSize = true;
            this.lblBelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelopp.Location = new System.Drawing.Point(257, 70);
            this.lblBelopp.Name = "lblBelopp";
            this.lblBelopp.Size = new System.Drawing.Size(56, 17);
            this.lblBelopp.TabIndex = 1;
            this.lblBelopp.Text = "Belopp:";
            // 
            // txbBelopp
            // 
            this.txbBelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBelopp.Location = new System.Drawing.Point(260, 90);
            this.txbBelopp.Name = "txbBelopp";
            this.txbBelopp.Size = new System.Drawing.Size(100, 23);
            this.txbBelopp.TabIndex = 2;
            this.txbBelopp.TextChanged += new System.EventHandler(this.txbBelopp_TextChanged);
            // 
            // btnVisa
            // 
            this.btnVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisa.Location = new System.Drawing.Point(367, 70);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 43);
            this.btnVisa.TabIndex = 3;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.ForeColor = System.Drawing.Color.Green;
            this.lblSvar.Location = new System.Drawing.Point(257, 139);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 17);
            this.lblSvar.TabIndex = 4;
            // 
            // lblFel
            // 
            this.lblFel.AutoSize = true;
            this.lblFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFel.Location = new System.Drawing.Point(111, 165);
            this.lblFel.Name = "lblFel";
            this.lblFel.Size = new System.Drawing.Size(0, 17);
            this.lblFel.TabIndex = 5;
            // 
            // Uttgsautomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 203);
            this.Controls.Add(this.lblFel);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.txbBelopp);
            this.Controls.Add(this.lblBelopp);
            this.Controls.Add(this.lblTexten);
            this.Name = "Uttgsautomat";
            this.Text = "Uttagsautomat";
            this.Load += new System.EventHandler(this.Uttgsautomat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexten;
        private System.Windows.Forms.Label lblBelopp;
        private System.Windows.Forms.TextBox txbBelopp;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblFel;
    }
}

