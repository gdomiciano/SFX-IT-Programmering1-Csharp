namespace Uppgift_13._1
{
    partial class Uppgift_13_1
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
            this.gbxLäggtill = new System.Windows.Forms.GroupBox();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.tbxLäggTillEngelskt = new System.Windows.Forms.TextBox();
            this.tbxLäggTillSvenskt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxGlostest = new System.Windows.Forms.GroupBox();
            this.btnSvara = new System.Windows.Forms.Button();
            this.tbxGlostestEngelskt = new System.Windows.Forms.TextBox();
            this.tbxGlostestSvenskt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxResultat = new System.Windows.Forms.GroupBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnStartaGlostest = new System.Windows.Forms.Button();
            this.btnNyaGlosor = new System.Windows.Forms.Button();
            this.gbxLäggtill.SuspendLayout();
            this.gbxGlostest.SuspendLayout();
            this.gbxResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLäggtill
            // 
            this.gbxLäggtill.Controls.Add(this.btnLäggTill);
            this.gbxLäggtill.Controls.Add(this.tbxLäggTillEngelskt);
            this.gbxLäggtill.Controls.Add(this.tbxLäggTillSvenskt);
            this.gbxLäggtill.Controls.Add(this.label2);
            this.gbxLäggtill.Controls.Add(this.label1);
            this.gbxLäggtill.Location = new System.Drawing.Point(13, 13);
            this.gbxLäggtill.Name = "gbxLäggtill";
            this.gbxLäggtill.Size = new System.Drawing.Size(266, 183);
            this.gbxLäggtill.TabIndex = 0;
            this.gbxLäggtill.TabStop = false;
            this.gbxLäggtill.Text = "Lägg till glosor";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(19, 124);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(217, 30);
            this.btnLäggTill.TabIndex = 4;
            this.btnLäggTill.Text = "Lägg till glossa";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // tbxLäggTillEngelskt
            // 
            this.tbxLäggTillEngelskt.Location = new System.Drawing.Point(136, 75);
            this.tbxLäggTillEngelskt.Name = "tbxLäggTillEngelskt";
            this.tbxLäggTillEngelskt.Size = new System.Drawing.Size(100, 22);
            this.tbxLäggTillEngelskt.TabIndex = 3;
            // 
            // tbxLäggTillSvenskt
            // 
            this.tbxLäggTillSvenskt.Location = new System.Drawing.Point(136, 34);
            this.tbxLäggTillSvenskt.Name = "tbxLäggTillSvenskt";
            this.tbxLäggTillSvenskt.Size = new System.Drawing.Size(100, 22);
            this.tbxLäggTillSvenskt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Engelskt ord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svenskt ord:";
            // 
            // gbxGlostest
            // 
            this.gbxGlostest.Controls.Add(this.btnSvara);
            this.gbxGlostest.Controls.Add(this.tbxGlostestEngelskt);
            this.gbxGlostest.Controls.Add(this.tbxGlostestSvenskt);
            this.gbxGlostest.Controls.Add(this.label4);
            this.gbxGlostest.Controls.Add(this.label3);
            this.gbxGlostest.Enabled = false;
            this.gbxGlostest.Location = new System.Drawing.Point(13, 214);
            this.gbxGlostest.Name = "gbxGlostest";
            this.gbxGlostest.Size = new System.Drawing.Size(266, 164);
            this.gbxGlostest.TabIndex = 1;
            this.gbxGlostest.TabStop = false;
            this.gbxGlostest.Text = "Glostest";
            this.gbxGlostest.EnabledChanged += new System.EventHandler(this.gbxGlostest_EnabledChanged);
            // 
            // btnSvara
            // 
            this.btnSvara.Location = new System.Drawing.Point(19, 115);
            this.btnSvara.Name = "btnSvara";
            this.btnSvara.Size = new System.Drawing.Size(217, 28);
            this.btnSvara.TabIndex = 4;
            this.btnSvara.Text = "Svara";
            this.btnSvara.UseVisualStyleBackColor = true;
            this.btnSvara.Click += new System.EventHandler(this.btnSvara_Click);
            // 
            // tbxGlostestEngelskt
            // 
            this.tbxGlostestEngelskt.Location = new System.Drawing.Point(136, 70);
            this.tbxGlostestEngelskt.Name = "tbxGlostestEngelskt";
            this.tbxGlostestEngelskt.Size = new System.Drawing.Size(100, 22);
            this.tbxGlostestEngelskt.TabIndex = 3;
            // 
            // tbxGlostestSvenskt
            // 
            this.tbxGlostestSvenskt.Location = new System.Drawing.Point(136, 27);
            this.tbxGlostestSvenskt.Name = "tbxGlostestSvenskt";
            this.tbxGlostestSvenskt.Size = new System.Drawing.Size(100, 22);
            this.tbxGlostestSvenskt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Engelskt ord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Svenskt ord:";
            // 
            // gbxResultat
            // 
            this.gbxResultat.Controls.Add(this.lblResultat);
            this.gbxResultat.Enabled = false;
            this.gbxResultat.Location = new System.Drawing.Point(310, 13);
            this.gbxResultat.Name = "gbxResultat";
            this.gbxResultat.Size = new System.Drawing.Size(200, 365);
            this.gbxResultat.TabIndex = 2;
            this.gbxResultat.TabStop = false;
            this.gbxResultat.Text = "Resultat";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(8, 34);
            this.lblResultat.MaximumSize = new System.Drawing.Size(180, 0);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 17);
            this.lblResultat.TabIndex = 0;
            // 
            // btnStartaGlostest
            // 
            this.btnStartaGlostest.Location = new System.Drawing.Point(32, 399);
            this.btnStartaGlostest.Name = "btnStartaGlostest";
            this.btnStartaGlostest.Size = new System.Drawing.Size(217, 39);
            this.btnStartaGlostest.TabIndex = 3;
            this.btnStartaGlostest.Text = "Starta Glostest";
            this.btnStartaGlostest.UseVisualStyleBackColor = true;
            this.btnStartaGlostest.Click += new System.EventHandler(this.btnStartaGlostest_Click);
            // 
            // btnNyaGlosor
            // 
            this.btnNyaGlosor.Location = new System.Drawing.Point(310, 399);
            this.btnNyaGlosor.Name = "btnNyaGlosor";
            this.btnNyaGlosor.Size = new System.Drawing.Size(200, 39);
            this.btnNyaGlosor.TabIndex = 4;
            this.btnNyaGlosor.Text = "Nya glosor";
            this.btnNyaGlosor.UseVisualStyleBackColor = true;
            this.btnNyaGlosor.Click += new System.EventHandler(this.btnNyaGlosor_Click);
            // 
            // Uppgift_13_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.btnNyaGlosor);
            this.Controls.Add(this.btnStartaGlostest);
            this.Controls.Add(this.gbxResultat);
            this.Controls.Add(this.gbxGlostest);
            this.Controls.Add(this.gbxLäggtill);
            this.Name = "Uppgift_13_1";
            this.Text = "Uppgift";
            this.gbxLäggtill.ResumeLayout(false);
            this.gbxLäggtill.PerformLayout();
            this.gbxGlostest.ResumeLayout(false);
            this.gbxGlostest.PerformLayout();
            this.gbxResultat.ResumeLayout(false);
            this.gbxResultat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLäggtill;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.TextBox tbxLäggTillEngelskt;
        private System.Windows.Forms.TextBox tbxLäggTillSvenskt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxGlostest;
        private System.Windows.Forms.Button btnSvara;
        private System.Windows.Forms.TextBox tbxGlostestEngelskt;
        private System.Windows.Forms.TextBox tbxGlostestSvenskt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxResultat;
        private System.Windows.Forms.Button btnStartaGlostest;
        private System.Windows.Forms.Button btnNyaGlosor;
        private System.Windows.Forms.Label lblResultat;
    }
}

