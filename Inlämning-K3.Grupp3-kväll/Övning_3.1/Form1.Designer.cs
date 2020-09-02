namespace Övning_3._1
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
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.txbHöjd = new System.Windows.Forms.TextBox();
            this.lblHöjd = new System.Windows.Forms.Label();
            this.lblBas = new System.Windows.Forms.Label();
            this.txbBas = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblTexten = new System.Windows.Forms.Label();
            this.lblFel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBeräkna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeräkna.Location = new System.Drawing.Point(357, 90);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(150, 50);
            this.btnBeräkna.TabIndex = 0;
            this.btnBeräkna.Text = "Beräkna!";
            this.btnBeräkna.UseVisualStyleBackColor = false;
            this.btnBeräkna.Click += new System.EventHandler(this.btnBeräknaArean_Click);
            // 
            // txbHöjd
            // 
            this.txbHöjd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHöjd.Location = new System.Drawing.Point(102, 104);
            this.txbHöjd.Name = "txbHöjd";
            this.txbHöjd.Size = new System.Drawing.Size(100, 23);
            this.txbHöjd.TabIndex = 1;
            // 
            // lblHöjd
            // 
            this.lblHöjd.AutoSize = true;
            this.lblHöjd.BackColor = System.Drawing.SystemColors.Control;
            this.lblHöjd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHöjd.Location = new System.Drawing.Point(99, 84);
            this.lblHöjd.Name = "lblHöjd";
            this.lblHöjd.Size = new System.Drawing.Size(41, 17);
            this.lblHöjd.TabIndex = 3;
            this.lblHöjd.Text = "Höjd:";
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBas.Location = new System.Drawing.Point(230, 84);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(32, 17);
            this.lblBas.TabIndex = 5;
            this.lblBas.Text = "Bas";
            // 
            // txbBas
            // 
            this.txbBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBas.Location = new System.Drawing.Point(233, 104);
            this.txbBas.Name = "txbBas";
            this.txbBas.Size = new System.Drawing.Size(100, 23);
            this.txbBas.TabIndex = 4;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.ForeColor = System.Drawing.Color.Green;
            this.lblSvar.Location = new System.Drawing.Point(99, 184);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 18);
            this.lblSvar.TabIndex = 6;
            // 
            // lblTexten
            // 
            this.lblTexten.AutoSize = true;
            this.lblTexten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexten.Location = new System.Drawing.Point(37, 42);
            this.lblTexten.Name = "lblTexten";
            this.lblTexten.Size = new System.Drawing.Size(547, 20);
            this.lblTexten.TabIndex = 7;
            this.lblTexten.Text = "Mata in bas och höjd och klicka på beräknaknappen för att få triangels arean";
            // 
            // lblFel
            // 
            this.lblFel.AutoSize = true;
            this.lblFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFel.Location = new System.Drawing.Point(93, 206);
            this.lblFel.Name = "lblFel";
            this.lblFel.Size = new System.Drawing.Size(0, 17);
            this.lblFel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 266);
            this.Controls.Add(this.lblFel);
            this.Controls.Add(this.lblTexten);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblBas);
            this.Controls.Add(this.txbBas);
            this.Controls.Add(this.lblHöjd);
            this.Controls.Add(this.txbHöjd);
            this.Controls.Add(this.btnBeräkna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeräkna;
        private System.Windows.Forms.TextBox txbHöjd;
        private System.Windows.Forms.Label lblHöjd;
        private System.Windows.Forms.Label lblBas;
        private System.Windows.Forms.TextBox txbBas;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblTexten;
        private System.Windows.Forms.Label lblFel;
    }
}

