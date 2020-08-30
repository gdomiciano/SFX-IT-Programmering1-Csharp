namespace Exempel102_02
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
            this.btnKlick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlick
            // 
            this.btnKlick.Location = new System.Drawing.Point(41, 71);
            this.btnKlick.Name = "btnKlick";
            this.btnKlick.Size = new System.Drawing.Size(102, 23);
            this.btnKlick.TabIndex = 0;
            this.btnKlick.Text = "klicka här!";
            this.btnKlick.UseVisualStyleBackColor = true;
            this.btnKlick.Click += new System.EventHandler(this.btnKlick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.btnKlick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlick;
    }
}

