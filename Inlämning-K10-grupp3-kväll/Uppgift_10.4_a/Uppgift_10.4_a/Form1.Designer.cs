﻿namespace Uppgift_10._4_a
{
    partial class Uppgift_10_4_a
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAntal = new System.Windows.Forms.TextBox();
            this.btnRita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antal: ";
            // 
            // tbxAntal
            // 
            this.tbxAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAntal.Location = new System.Drawing.Point(421, 31);
            this.tbxAntal.Name = "tbxAntal";
            this.tbxAntal.Size = new System.Drawing.Size(100, 23);
            this.tbxAntal.TabIndex = 1;
            // 
            // btnRita
            // 
            this.btnRita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRita.Location = new System.Drawing.Point(527, 31);
            this.btnRita.Name = "btnRita";
            this.btnRita.Size = new System.Drawing.Size(75, 23);
            this.btnRita.TabIndex = 2;
            this.btnRita.Text = "Rita";
            this.btnRita.UseVisualStyleBackColor = true;
            // 
            // Uppgift_10_4_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 261);
            this.Controls.Add(this.btnRita);
            this.Controls.Add(this.tbxAntal);
            this.Controls.Add(this.label1);
            this.Name = "Uppgift_10_4_a";
            this.Text = "Uppgift 10.4 a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAntal;
        private System.Windows.Forms.Button btnRita;
    }
}

