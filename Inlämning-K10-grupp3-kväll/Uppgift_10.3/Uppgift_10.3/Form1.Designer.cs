namespace Uppgift_10._3
{
    partial class Uppgift_10_3
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
            this.txbTecken = new System.Windows.Forms.TextBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tecken";
            // 
            // txbTecken
            // 
            this.txbTecken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTecken.Location = new System.Drawing.Point(115, 21);
            this.txbTecken.Name = "txbTecken";
            this.txbTecken.Size = new System.Drawing.Size(100, 23);
            this.txbTecken.TabIndex = 1;
            this.txbTecken.TextChanged += new System.EventHandler(this.txbTecken_TextChanged);
            // 
            // btnVisa
            // 
            this.btnVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisa.Location = new System.Drawing.Point(48, 117);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(138, 29);
            this.btnVisa.TabIndex = 2;
            this.btnVisa.Text = "Visa Resultat";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.Location = new System.Drawing.Point(15, 69);
            this.lblSvar.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblSvar.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(200, 19);
            this.lblSvar.TabIndex = 3;
            // 
            // Uppgift_10_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 167);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.txbTecken);
            this.Controls.Add(this.label1);
            this.Name = "Uppgift_10_3";
            this.Text = "Uppgift 10.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTecken;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.Label lblSvar;
    }
}

