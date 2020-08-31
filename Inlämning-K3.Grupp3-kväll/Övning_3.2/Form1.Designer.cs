namespace Övning_3._2
{
    partial class Teckenkoden
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
            this.lblTeckenkod = new System.Windows.Forms.Label();
            this.tbxTeckenkod = new System.Windows.Forms.TextBox();
            this.btnHittaTecken = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTeckenkod
            // 
            this.lblTeckenkod.AutoSize = true;
            this.lblTeckenkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeckenkod.Location = new System.Drawing.Point(94, 81);
            this.lblTeckenkod.Name = "lblTeckenkod";
            this.lblTeckenkod.Size = new System.Drawing.Size(82, 17);
            this.lblTeckenkod.TabIndex = 0;
            this.lblTeckenkod.Text = "Teckenkod:";
            // 
            // tbxTeckenkod
            // 
            this.tbxTeckenkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTeckenkod.Location = new System.Drawing.Point(182, 78);
            this.tbxTeckenkod.Name = "tbxTeckenkod";
            this.tbxTeckenkod.Size = new System.Drawing.Size(75, 23);
            this.tbxTeckenkod.TabIndex = 1;
            // 
            // btnHittaTecken
            // 
            this.btnHittaTecken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHittaTecken.Location = new System.Drawing.Point(263, 78);
            this.btnHittaTecken.Name = "btnHittaTecken";
            this.btnHittaTecken.Size = new System.Drawing.Size(113, 23);
            this.btnHittaTecken.TabIndex = 2;
            this.btnHittaTecken.Text = "Hitta Tecken! ";
            this.btnHittaTecken.UseVisualStyleBackColor = true;
            this.btnHittaTecken.Click += new System.EventHandler(this.btnHittaTecken_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(94, 124);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 3;
            this.lblSvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(14, 26);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(448, 20);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Matta in ett tal mellan 1 och 255 medan och klicka på knappen";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Teckenkoden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 171);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnHittaTecken);
            this.Controls.Add(this.tbxTeckenkod);
            this.Controls.Add(this.lblTeckenkod);
            this.Name = "Teckenkoden";
            this.Text = "Vad är teckenkoden?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeckenkod;
        private System.Windows.Forms.TextBox tbxTeckenkod;
        private System.Windows.Forms.Button btnHittaTecken;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblText;
    }
}

