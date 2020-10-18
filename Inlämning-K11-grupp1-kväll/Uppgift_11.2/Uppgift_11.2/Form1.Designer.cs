namespace Uppgift_11._2
{
    partial class Kontaker
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
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxLista = new System.Windows.Forms.TextBox();
            this.btnLäggtill = new System.Windows.Forms.Button();
            this.rBtnFörnamn = new System.Windows.Forms.RadioButton();
            this.rBtnEfternamn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lista";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(94, 10);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(283, 22);
            this.tbxFörnamn.TabIndex = 0;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(479, 10);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(309, 22);
            this.tbxEfternamn.TabIndex = 1;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(94, 56);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(173, 22);
            this.tbxTelefon.TabIndex = 3;
            // 
            // tbxLista
            // 
            this.tbxLista.Location = new System.Drawing.Point(27, 149);
            this.tbxLista.Multiline = true;
            this.tbxLista.Name = "tbxLista";
            this.tbxLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLista.Size = new System.Drawing.Size(761, 235);
            this.tbxLista.TabIndex = 7;
            // 
            // btnLäggtill
            // 
            this.btnLäggtill.Location = new System.Drawing.Point(578, 56);
            this.btnLäggtill.Name = "btnLäggtill";
            this.btnLäggtill.Size = new System.Drawing.Size(210, 26);
            this.btnLäggtill.TabIndex = 4;
            this.btnLäggtill.Text = "Lägg till";
            this.btnLäggtill.UseVisualStyleBackColor = true;
            this.btnLäggtill.Click += new System.EventHandler(this.btnLäggtill_Click);
            // 
            // rBtnFörnamn
            // 
            this.rBtnFörnamn.AutoSize = true;
            this.rBtnFörnamn.Checked = true;
            this.rBtnFörnamn.Location = new System.Drawing.Point(27, 412);
            this.rBtnFörnamn.Name = "rBtnFörnamn";
            this.rBtnFörnamn.Size = new System.Drawing.Size(121, 21);
            this.rBtnFörnamn.TabIndex = 5;
            this.rBtnFörnamn.TabStop = true;
            this.rBtnFörnamn.Tag = "visaEfter";
            this.rBtnFörnamn.Text = "Förnamn Först";
            this.rBtnFörnamn.UseVisualStyleBackColor = true;
            // 
            // rBtnEfternamn
            // 
            this.rBtnEfternamn.AutoSize = true;
            this.rBtnEfternamn.Location = new System.Drawing.Point(155, 412);
            this.rBtnEfternamn.Name = "rBtnEfternamn";
            this.rBtnEfternamn.Size = new System.Drawing.Size(130, 21);
            this.rBtnEfternamn.TabIndex = 6;
            this.rBtnEfternamn.Tag = "visaEfter";
            this.rBtnEfternamn.Text = "Efternamn Först";
            this.rBtnEfternamn.UseVisualStyleBackColor = true;
            // 
            // Kontaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBtnEfternamn);
            this.Controls.Add(this.rBtnFörnamn);
            this.Controls.Add(this.btnLäggtill);
            this.Controls.Add(this.tbxLista);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kontaker";
            this.Text = "Kontakter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxLista;
        private System.Windows.Forms.Button btnLäggtill;
        private System.Windows.Forms.RadioButton rBtnFörnamn;
        private System.Windows.Forms.RadioButton rBtnEfternamn;
    }
}

