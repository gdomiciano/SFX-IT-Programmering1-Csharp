namespace Uppgift_5._4
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
            this.lblTExten = new System.Windows.Forms.Label();
            this.txbSekunder = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblFel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTExten
            // 
            this.lblTExten.AutoSize = true;
            this.lblTExten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTExten.Location = new System.Drawing.Point(93, 55);
            this.lblTExten.Name = "lblTExten";
            this.lblTExten.Size = new System.Drawing.Size(604, 20);
            this.lblTExten.TabIndex = 0;
            this.lblTExten.Text = "Mata in tid i sekunder och klicka och klicka på knappen nedan för att se det i ti" +
    "dsform";
            // 
            // txbSekunder
            // 
            this.txbSekunder.Location = new System.Drawing.Point(278, 128);
            this.txbSekunder.Name = "txbSekunder";
            this.txbSekunder.Size = new System.Drawing.Size(100, 20);
            this.txbSekunder.TabIndex = 1;
            this.txbSekunder.TextChanged += new System.EventHandler(this.txbSekunder_TextChanged);
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(384, 126);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(107, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Visa i tidsform";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSvar.Location = new System.Drawing.Point(250, 183);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 17);
            this.lblSvar.TabIndex = 3;
            // 
            // lblFel
            // 
            this.lblFel.AutoSize = true;
            this.lblFel.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFel.Location = new System.Drawing.Point(250, 200);
            this.lblFel.Name = "lblFel";
            this.lblFel.Size = new System.Drawing.Size(0, 13);
            this.lblFel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 259);
            this.Controls.Add(this.lblFel);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.txbSekunder);
            this.Controls.Add(this.lblTExten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTExten;
        private System.Windows.Forms.TextBox txbSekunder;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblFel;
    }
}

