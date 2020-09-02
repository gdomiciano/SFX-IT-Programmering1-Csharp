namespace Övning_3._3
{
    partial class DecimaltalTillHeltal
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
            this.txbDecimaltalet = new System.Windows.Forms.TextBox();
            this.btnAvrunda = new System.Windows.Forms.Button();
            this.lblTexten = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblFel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbDecimaltalet
            // 
            this.txbDecimaltalet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDecimaltalet.Location = new System.Drawing.Point(118, 85);
            this.txbDecimaltalet.Name = "txbDecimaltalet";
            this.txbDecimaltalet.Size = new System.Drawing.Size(100, 23);
            this.txbDecimaltalet.TabIndex = 0;
            this.txbDecimaltalet.TextChanged += new System.EventHandler(this.txbDecimaltalet_TextChanged);
            // 
            // btnAvrunda
            // 
            this.btnAvrunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvrunda.Location = new System.Drawing.Point(243, 85);
            this.btnAvrunda.Name = "btnAvrunda";
            this.btnAvrunda.Size = new System.Drawing.Size(75, 23);
            this.btnAvrunda.TabIndex = 1;
            this.btnAvrunda.Text = "Avrunda";
            this.btnAvrunda.UseVisualStyleBackColor = true;
            this.btnAvrunda.Click += new System.EventHandler(this.btnAvrunda_Click);
            // 
            // lblTexten
            // 
            this.lblTexten.AutoSize = true;
            this.lblTexten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexten.Location = new System.Drawing.Point(32, 39);
            this.lblTexten.Name = "lblTexten";
            this.lblTexten.Size = new System.Drawing.Size(376, 20);
            this.lblTexten.TabIndex = 2;
            this.lblTexten.Text = "Mata in ett decimaltal för att avrunda det till ett heltal";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.ForeColor = System.Drawing.Color.Green;
            this.lblSvar.Location = new System.Drawing.Point(36, 138);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 17);
            this.lblSvar.TabIndex = 3;
            // 
            // lblFel
            // 
            this.lblFel.AutoSize = true;
            this.lblFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFel.Location = new System.Drawing.Point(39, 174);
            this.lblFel.Name = "lblFel";
            this.lblFel.Size = new System.Drawing.Size(0, 17);
            this.lblFel.TabIndex = 4;
            // 
            // DecimaltalTillHeltal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 210);
            this.Controls.Add(this.lblFel);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblTexten);
            this.Controls.Add(this.btnAvrunda);
            this.Controls.Add(this.txbDecimaltalet);
            this.Name = "DecimaltalTillHeltal";
            this.Text = "Decimaltal till heltal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDecimaltalet;
        private System.Windows.Forms.Button btnAvrunda;
        private System.Windows.Forms.Label lblTexten;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblFel;
    }
}

