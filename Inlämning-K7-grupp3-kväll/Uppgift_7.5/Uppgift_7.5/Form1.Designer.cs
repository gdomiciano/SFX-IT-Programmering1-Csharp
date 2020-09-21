namespace Uppgift_7._5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnRätta = new System.Windows.Forms.Button();
            this.tbxFråga1 = new System.Windows.Forms.TextBox();
            this.tbxFråga2 = new System.Windows.Forms.TextBox();
            this.tbxFråga3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Vilket variabelnamn är inte tillåtet?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. tal1    X. 1tal    2. tal_2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. Vad blir 14%4?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "1. 3    X. 2    2. 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "3.Vad blir 14/5?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "1. 2    X. 3    2. 4";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.Location = new System.Drawing.Point(70, 256);
            this.lblSvar.MinimumSize = new System.Drawing.Size(300, 20);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(300, 20);
            this.lblSvar.TabIndex = 6;
            // 
            // btnRätta
            // 
            this.btnRätta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRätta.Location = new System.Drawing.Point(175, 309);
            this.btnRätta.Name = "btnRätta";
            this.btnRätta.Size = new System.Drawing.Size(75, 23);
            this.btnRätta.TabIndex = 7;
            this.btnRätta.Text = "Rätta";
            this.btnRätta.UseVisualStyleBackColor = true;
            this.btnRätta.Click += new System.EventHandler(this.btnRätta_Click);
            // 
            // tbxFråga1
            // 
            this.tbxFråga1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFråga1.Location = new System.Drawing.Point(288, 56);
            this.tbxFråga1.Name = "tbxFråga1";
            this.tbxFråga1.Size = new System.Drawing.Size(100, 23);
            this.tbxFråga1.TabIndex = 8;
            this.tbxFråga1.TextChanged += new System.EventHandler(this.klaraSvar);
            // 
            // tbxFråga2
            // 
            this.tbxFråga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFråga2.Location = new System.Drawing.Point(288, 120);
            this.tbxFråga2.Name = "tbxFråga2";
            this.tbxFråga2.Size = new System.Drawing.Size(100, 23);
            this.tbxFråga2.TabIndex = 9;
            this.tbxFråga2.TextChanged += new System.EventHandler(this.klaraSvar);
            // 
            // tbxFråga3
            // 
            this.tbxFråga3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFråga3.Location = new System.Drawing.Point(288, 183);
            this.tbxFråga3.Name = "tbxFråga3";
            this.tbxFråga3.Size = new System.Drawing.Size(100, 23);
            this.tbxFråga3.TabIndex = 10;
            this.tbxFråga3.TextChanged += new System.EventHandler(this.klaraSvar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 367);
            this.Controls.Add(this.tbxFråga3);
            this.Controls.Add(this.tbxFråga2);
            this.Controls.Add(this.tbxFråga1);
            this.Controls.Add(this.btnRätta);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnRätta;
        private System.Windows.Forms.TextBox tbxFråga1;
        private System.Windows.Forms.TextBox tbxFråga2;
        private System.Windows.Forms.TextBox tbxFråga3;
    }
}

