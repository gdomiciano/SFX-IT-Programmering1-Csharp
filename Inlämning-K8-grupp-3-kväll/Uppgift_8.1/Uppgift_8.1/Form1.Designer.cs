namespace Uppgift_8._1
{
    partial class Uppgift_8_1
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
            this.btnFlyttaTillVänster = new System.Windows.Forms.Button();
            this.btnFlyttaTillHöger = new System.Windows.Forms.Button();
            this.btnFlyttaUpp = new System.Windows.Forms.Button();
            this.btnFlyttaNed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFlyttaTillVänster
            // 
            this.btnFlyttaTillVänster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlyttaTillVänster.Location = new System.Drawing.Point(524, 33);
            this.btnFlyttaTillVänster.Name = "btnFlyttaTillVänster";
            this.btnFlyttaTillVänster.Size = new System.Drawing.Size(99, 36);
            this.btnFlyttaTillVänster.TabIndex = 1;
            this.btnFlyttaTillVänster.Text = "← Vänster";
            this.btnFlyttaTillVänster.UseVisualStyleBackColor = true;
            this.btnFlyttaTillVänster.Click += new System.EventHandler(this.btnFlyttaTillVänster_Click);
            // 
            // btnFlyttaTillHöger
            // 
            this.btnFlyttaTillHöger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlyttaTillHöger.Location = new System.Drawing.Point(657, 33);
            this.btnFlyttaTillHöger.Name = "btnFlyttaTillHöger";
            this.btnFlyttaTillHöger.Size = new System.Drawing.Size(90, 36);
            this.btnFlyttaTillHöger.TabIndex = 2;
            this.btnFlyttaTillHöger.Text = "→ Höger";
            this.btnFlyttaTillHöger.UseVisualStyleBackColor = true;
            this.btnFlyttaTillHöger.Click += new System.EventHandler(this.btnFlyttaTillHöger_Click);
            // 
            // btnFlyttaUpp
            // 
            this.btnFlyttaUpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnFlyttaUpp.Location = new System.Drawing.Point(393, 34);
            this.btnFlyttaUpp.Name = "btnFlyttaUpp";
            this.btnFlyttaUpp.Size = new System.Drawing.Size(100, 35);
            this.btnFlyttaUpp.TabIndex = 0;
            this.btnFlyttaUpp.Text = "↑ Upp";
            this.btnFlyttaUpp.UseVisualStyleBackColor = true;
            this.btnFlyttaUpp.Click += new System.EventHandler(this.btnFlyttaUpp_Click);
            // 
            // btnFlyttaNed
            // 
            this.btnFlyttaNed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlyttaNed.Location = new System.Drawing.Point(781, 33);
            this.btnFlyttaNed.Name = "btnFlyttaNed";
            this.btnFlyttaNed.Size = new System.Drawing.Size(82, 36);
            this.btnFlyttaNed.TabIndex = 3;
            this.btnFlyttaNed.Text = "↓ Ned";
            this.btnFlyttaNed.UseVisualStyleBackColor = true;
            this.btnFlyttaNed.Click += new System.EventHandler(this.btnFlyttaNed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Klicka på knapparna för att flytta cirkels positionen";
            // 
            // Uppgift_8_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFlyttaNed);
            this.Controls.Add(this.btnFlyttaUpp);
            this.Controls.Add(this.btnFlyttaTillHöger);
            this.Controls.Add(this.btnFlyttaTillVänster);
            this.Name = "Uppgift_8_1";
            this.Text = "Uppgift 8.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlyttaTillVänster;
        private System.Windows.Forms.Button btnFlyttaTillHöger;
        private System.Windows.Forms.Button btnFlyttaUpp;
        private System.Windows.Forms.Button btnFlyttaNed;
        private System.Windows.Forms.Label label1;
    }
}

