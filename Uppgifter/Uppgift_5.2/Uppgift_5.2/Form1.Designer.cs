namespace Uppgift_5._2
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
            this.lblEtikett = new System.Windows.Forms.Label();
            this.txbTusental = new System.Windows.Forms.TextBox();
            this.btnAvrunda = new System.Windows.Forms.Button();
            this.lblFel = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEtikett
            // 
            this.lblEtikett.AutoSize = true;
            this.lblEtikett.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtikett.Location = new System.Drawing.Point(27, 35);
            this.lblEtikett.Name = "lblEtikett";
            this.lblEtikett.Size = new System.Drawing.Size(595, 20);
            this.lblEtikett.TabIndex = 0;
            this.lblEtikett.Text = "Mata in ett tusental (utan komma eller punkt) och klicka på avrunda knappen nedan" +
    "";
            // 
            // txbTusental
            // 
            this.txbTusental.Location = new System.Drawing.Point(154, 81);
            this.txbTusental.Name = "txbTusental";
            this.txbTusental.Size = new System.Drawing.Size(140, 20);
            this.txbTusental.TabIndex = 1;
            this.txbTusental.TextChanged += new System.EventHandler(this.txbTusental_TextChanged);
            // 
            // btnAvrunda
            // 
            this.btnAvrunda.Location = new System.Drawing.Point(322, 79);
            this.btnAvrunda.Name = "btnAvrunda";
            this.btnAvrunda.Size = new System.Drawing.Size(168, 23);
            this.btnAvrunda.TabIndex = 2;
            this.btnAvrunda.Text = "Avrunda till  hela tusental";
            this.btnAvrunda.UseVisualStyleBackColor = true;
            this.btnAvrunda.Click += new System.EventHandler(this.btnAvrunda_Click);
            // 
            // lblFel
            // 
            this.lblFel.AutoSize = true;
            this.lblFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFel.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFel.Location = new System.Drawing.Point(154, 118);
            this.lblFel.Name = "lblFel";
            this.lblFel.Size = new System.Drawing.Size(0, 17);
            this.lblFel.TabIndex = 3;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSvar.Location = new System.Drawing.Point(221, 118);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 17);
            this.lblSvar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 200);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblFel);
            this.Controls.Add(this.btnAvrunda);
            this.Controls.Add(this.txbTusental);
            this.Controls.Add(this.lblEtikett);
            this.Name = "Form1";
            this.Text = "Avrunda tusentalet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtikett;
        private System.Windows.Forms.TextBox txbTusental;
        private System.Windows.Forms.Button btnAvrunda;
        private System.Windows.Forms.Label lblFel;
        private System.Windows.Forms.Label lblSvar;
    }
}

