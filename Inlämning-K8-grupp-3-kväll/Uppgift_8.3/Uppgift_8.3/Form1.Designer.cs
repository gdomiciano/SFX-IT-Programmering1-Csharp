namespace Uppgift_8._3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxStenSaxPåse = new System.Windows.Forms.GroupBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDatornsVal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxPåse = new System.Windows.Forms.PictureBox();
            this.pbxSax = new System.Windows.Forms.PictureBox();
            this.pbxSten = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpela = new System.Windows.Forms.Button();
            this.gbxMinaResultat = new System.Windows.Forms.GroupBox();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.gbxStenSaxPåse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).BeginInit();
            this.gbxMinaResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStenSaxPåse
            // 
            this.gbxStenSaxPåse.Controls.Add(this.lblResultat);
            this.gbxStenSaxPåse.Controls.Add(this.lblDatornsVal);
            this.gbxStenSaxPåse.Controls.Add(this.label2);
            this.gbxStenSaxPåse.Controls.Add(this.pbxPåse);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSax);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSten);
            this.gbxStenSaxPåse.Controls.Add(this.label1);
            this.gbxStenSaxPåse.Enabled = false;
            this.gbxStenSaxPåse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStenSaxPåse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxStenSaxPåse.Location = new System.Drawing.Point(13, 13);
            this.gbxStenSaxPåse.Name = "gbxStenSaxPåse";
            this.gbxStenSaxPåse.Size = new System.Drawing.Size(470, 425);
            this.gbxStenSaxPåse.TabIndex = 0;
            this.gbxStenSaxPåse.TabStop = false;
            this.gbxStenSaxPåse.Text = "Sten, Sax eller Påse";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Enabled = false;
            this.lblResultat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResultat.Location = new System.Drawing.Point(32, 366);
            this.lblResultat.MinimumSize = new System.Drawing.Size(400, 30);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(400, 30);
            this.lblResultat.TabIndex = 6;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatornsVal
            // 
            this.lblDatornsVal.AutoSize = true;
            this.lblDatornsVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsVal.Enabled = false;
            this.lblDatornsVal.Location = new System.Drawing.Point(230, 293);
            this.lblDatornsVal.MinimumSize = new System.Drawing.Size(90, 30);
            this.lblDatornsVal.Name = "lblDatornsVal";
            this.lblDatornsVal.Size = new System.Drawing.Size(90, 30);
            this.lblDatornsVal.TabIndex = 5;
            this.lblDatornsVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datorn valde:";
            // 
            // pbxPåse
            // 
            this.pbxPåse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxPåse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxPåse.BackgroundImage")));
            this.pbxPåse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxPåse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPåse.Location = new System.Drawing.Point(316, 102);
            this.pbxPåse.Name = "pbxPåse";
            this.pbxPåse.Size = new System.Drawing.Size(129, 129);
            this.pbxPåse.TabIndex = 3;
            this.pbxPåse.TabStop = false;
            this.pbxPåse.Click += new System.EventHandler(this.pbxPåse_Click);
            // 
            // pbxSax
            // 
            this.pbxSax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbxSax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSax.BackgroundImage")));
            this.pbxSax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxSax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSax.Location = new System.Drawing.Point(171, 102);
            this.pbxSax.Name = "pbxSax";
            this.pbxSax.Size = new System.Drawing.Size(121, 129);
            this.pbxSax.TabIndex = 2;
            this.pbxSax.TabStop = false;
            this.pbxSax.Click += new System.EventHandler(this.pbxSax_Click);
            // 
            // pbxSten
            // 
            this.pbxSten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbxSten.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSten.BackgroundImage")));
            this.pbxSten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxSten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSten.Location = new System.Drawing.Point(22, 102);
            this.pbxSten.Name = "pbxSten";
            this.pbxSten.Size = new System.Drawing.Size(125, 129);
            this.pbxSten.TabIndex = 1;
            this.pbxSten.TabStop = false;
            this.pbxSten.Click += new System.EventHandler(this.pbxSten_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välj sten sax eller påse genom att klicka på en bild";
            // 
            // btnSpela
            // 
            this.btnSpela.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpela.Location = new System.Drawing.Point(513, 37);
            this.btnSpela.Name = "btnSpela";
            this.btnSpela.Size = new System.Drawing.Size(275, 59);
            this.btnSpela.TabIndex = 1;
            this.btnSpela.Text = "🎲 Spela";
            this.btnSpela.UseVisualStyleBackColor = true;
            this.btnSpela.Click += new System.EventHandler(this.btnSpela_Click);
            // 
            // gbxMinaResultat
            // 
            this.gbxMinaResultat.Controls.Add(this.tbxMinaResultat);
            this.gbxMinaResultat.Enabled = false;
            this.gbxMinaResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMinaResultat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxMinaResultat.Location = new System.Drawing.Point(513, 139);
            this.gbxMinaResultat.Name = "gbxMinaResultat";
            this.gbxMinaResultat.Size = new System.Drawing.Size(275, 299);
            this.gbxMinaResultat.TabIndex = 2;
            this.gbxMinaResultat.TabStop = false;
            this.gbxMinaResultat.Text = "Mina Resultat";
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(25, 43);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(226, 227);
            this.tbxMinaResultat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxMinaResultat);
            this.Controls.Add(this.btnSpela);
            this.Controls.Add(this.gbxStenSaxPåse);
            this.Name = "Form1";
            this.Text = " Uppgift_8.3 | Sten, sax eller påse";
            this.gbxStenSaxPåse.ResumeLayout(false);
            this.gbxStenSaxPåse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).EndInit();
            this.gbxMinaResultat.ResumeLayout(false);
            this.gbxMinaResultat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStenSaxPåse;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblDatornsVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxPåse;
        private System.Windows.Forms.PictureBox pbxSax;
        private System.Windows.Forms.PictureBox pbxSten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpela;
        private System.Windows.Forms.GroupBox gbxMinaResultat;
        private System.Windows.Forms.TextBox tbxMinaResultat;
    }
}

