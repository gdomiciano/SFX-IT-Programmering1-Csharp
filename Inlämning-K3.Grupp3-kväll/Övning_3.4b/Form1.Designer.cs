namespace Övning_3._4b
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
            this.lblFel = new System.Windows.Forms.Label();
            this.lblSvarFemHundra = new System.Windows.Forms.Label();
            this.btnVisa = new System.Windows.Forms.Button();
            this.txbBelopp = new System.Windows.Forms.TextBox();
            this.lblBelopp = new System.Windows.Forms.Label();
            this.lblTexten = new System.Windows.Forms.Label();
            this.lblSvarHundra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFel
            // 
            this.lblFel.AutoSize = true;
            this.lblFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFel.Location = new System.Drawing.Point(60, 230);
            this.lblFel.Name = "lblFel";
            this.lblFel.Size = new System.Drawing.Size(0, 17);
            this.lblFel.TabIndex = 13;
            // 
            // lblSvarFemHundra
            // 
            this.lblSvarFemHundra.AutoSize = true;
            this.lblSvarFemHundra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvarFemHundra.ForeColor = System.Drawing.Color.Green;
            this.lblSvarFemHundra.Location = new System.Drawing.Point(197, 135);
            this.lblSvarFemHundra.Name = "lblSvarFemHundra";
            this.lblSvarFemHundra.Size = new System.Drawing.Size(0, 17);
            this.lblSvarFemHundra.TabIndex = 12;
            // 
            // btnVisa
            // 
            this.btnVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisa.Location = new System.Drawing.Point(307, 66);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 43);
            this.btnVisa.TabIndex = 11;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // txbBelopp
            // 
            this.txbBelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBelopp.Location = new System.Drawing.Point(200, 86);
            this.txbBelopp.Name = "txbBelopp";
            this.txbBelopp.Size = new System.Drawing.Size(100, 23);
            this.txbBelopp.TabIndex = 10;
            this.txbBelopp.TextChanged += new System.EventHandler(this.txbBelopp_TextChanged);
            // 
            // lblBelopp
            // 
            this.lblBelopp.AutoSize = true;
            this.lblBelopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelopp.Location = new System.Drawing.Point(197, 66);
            this.lblBelopp.Name = "lblBelopp";
            this.lblBelopp.Size = new System.Drawing.Size(56, 17);
            this.lblBelopp.TabIndex = 9;
            this.lblBelopp.Text = "Belopp:";
            // 
            // lblTexten
            // 
            this.lblTexten.AutoSize = true;
            this.lblTexten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexten.Location = new System.Drawing.Point(81, 26);
            this.lblTexten.Name = "lblTexten";
            this.lblTexten.Size = new System.Drawing.Size(454, 20);
            this.lblTexten.TabIndex = 8;
            this.lblTexten.Text = "Skriv in ett belopp nedan för att se hur stort uttag kan du kan ta\r\n";
            // 
            // lblSvarHundra
            // 
            this.lblSvarHundra.AutoSize = true;
            this.lblSvarHundra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvarHundra.ForeColor = System.Drawing.Color.Green;
            this.lblSvarHundra.Location = new System.Drawing.Point(197, 170);
            this.lblSvarHundra.Name = "lblSvarHundra";
            this.lblSvarHundra.Size = new System.Drawing.Size(0, 17);
            this.lblSvarHundra.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.lblSvarHundra);
            this.Controls.Add(this.lblFel);
            this.Controls.Add(this.lblSvarFemHundra);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.txbBelopp);
            this.Controls.Add(this.lblBelopp);
            this.Controls.Add(this.lblTexten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFel;
        private System.Windows.Forms.Label lblSvarFemHundra;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.TextBox txbBelopp;
        private System.Windows.Forms.Label lblBelopp;
        private System.Windows.Forms.Label lblTexten;
        private System.Windows.Forms.Label lblSvarHundra;
    }
}

