namespace Uppgift_10._4_b
{
    partial class Uppgift_10_4_b
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
            this.btnRita = new System.Windows.Forms.Button();
            this.tbxAntal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRita
            // 
            this.btnRita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRita.Location = new System.Drawing.Point(536, 49);
            this.btnRita.Name = "btnRita";
            this.btnRita.Size = new System.Drawing.Size(75, 23);
            this.btnRita.TabIndex = 5;
            this.btnRita.Text = "Rita";
            this.btnRita.UseVisualStyleBackColor = true;
            this.btnRita.Click += new System.EventHandler(this.btnRita_Click);
            // 
            // tbxAntal
            // 
            this.tbxAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAntal.Location = new System.Drawing.Point(430, 49);
            this.tbxAntal.Name = "tbxAntal";
            this.tbxAntal.Size = new System.Drawing.Size(100, 23);
            this.tbxAntal.TabIndex = 4;
            this.tbxAntal.TextChanged += new System.EventHandler(this.tbxAntal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Antal: ";
            // 
            // Uppgift_10_4_b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnRita);
            this.Controls.Add(this.tbxAntal);
            this.Controls.Add(this.label1);
            this.Name = "Uppgift_10_4_b";
            this.Text = "Uppgift 10.4 b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRita;
        private System.Windows.Forms.TextBox tbxAntal;
        private System.Windows.Forms.Label label1;
    }
}

