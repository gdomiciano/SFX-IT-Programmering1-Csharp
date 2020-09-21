namespace Uppgift_7._4
{
    partial class If
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
            this.lblTal1 = new System.Windows.Forms.Label();
            this.lblRäknesätt = new System.Windows.Forms.Label();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.tbxRäknesätt = new System.Windows.Forms.TextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTal1
            // 
            this.lblTal1.AutoSize = true;
            this.lblTal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTal1.Location = new System.Drawing.Point(59, 31);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(44, 17);
            this.lblTal1.TabIndex = 0;
            this.lblTal1.Text = "Tal 1:";
            // 
            // lblRäknesätt
            // 
            this.lblRäknesätt.AutoSize = true;
            this.lblRäknesätt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRäknesätt.Location = new System.Drawing.Point(27, 75);
            this.lblRäknesätt.Name = "lblRäknesätt";
            this.lblRäknesätt.Size = new System.Drawing.Size(76, 17);
            this.lblRäknesätt.TabIndex = 1;
            this.lblRäknesätt.Text = "Räknesätt:";
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTal2.Location = new System.Drawing.Point(59, 125);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(44, 17);
            this.lblTal2.TabIndex = 2;
            this.lblTal2.Text = "Tal 2:";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.Location = new System.Drawing.Point(27, 175);
            this.lblSvar.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(200, 19);
            this.lblSvar.TabIndex = 3;
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeräkna.Location = new System.Drawing.Point(88, 224);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(75, 23);
            this.btnBeräkna.TabIndex = 4;
            this.btnBeräkna.Text = "Beräkna";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.btnBeräkna_Click);
            // 
            // tbxTal1
            // 
            this.tbxTal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTal1.Location = new System.Drawing.Point(109, 28);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 23);
            this.tbxTal1.TabIndex = 5;
            this.tbxTal1.TextChanged += new System.EventHandler(this.klaraSvar);
            // 
            // tbxRäknesätt
            // 
            this.tbxRäknesätt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRäknesätt.Location = new System.Drawing.Point(109, 72);
            this.tbxRäknesätt.Name = "tbxRäknesätt";
            this.tbxRäknesätt.Size = new System.Drawing.Size(100, 23);
            this.tbxRäknesätt.TabIndex = 6;
            this.tbxRäknesätt.TextChanged += new System.EventHandler(this.klaraSvar);
            // 
            // tbxTal2
            // 
            this.tbxTal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTal2.Location = new System.Drawing.Point(109, 122);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 23);
            this.tbxTal2.TabIndex = 7;
            this.tbxTal2.TextChanged += new System.EventHandler(this.klaraSvar);
            // 
            // If
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 278);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxRäknesätt);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.btnBeräkna);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblRäknesätt);
            this.Controls.Add(this.lblTal1);
            this.Name = "If";
            this.Text = "Uppgift 7.4 | if ... else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal1;
        private System.Windows.Forms.Label lblRäknesätt;
        private System.Windows.Forms.Label lblTal2;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnBeräkna;
        private System.Windows.Forms.TextBox tbxTal1;
        private System.Windows.Forms.TextBox tbxRäknesätt;
        private System.Windows.Forms.TextBox tbxTal2;
    }
}

