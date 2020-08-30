namespace Övning02_02
{
    partial class Övning
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
            this.Meddelande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Meddelande
            // 
            this.Meddelande.Location = new System.Drawing.Point(50, 69);
            this.Meddelande.Name = "Meddelande";
            this.Meddelande.Size = new System.Drawing.Size(75, 23);
            this.Meddelande.TabIndex = 0;
            this.Meddelande.Text = "Meddelande";
            this.Meddelande.UseVisualStyleBackColor = true;
            this.Meddelande.Click += new System.EventHandler(this.Meddelande_Click);
            // 
            // Övning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.Meddelande);
            this.Name = "Övning";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Meddelande;
    }
}

