namespace Uppgift_11._3
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
            this.rBtnCirkel = new System.Windows.Forms.RadioButton();
            this.rBtnRektangel = new System.Windows.Forms.RadioButton();
            this.rBtnRuta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.tbxBredd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSida = new System.Windows.Forms.TextBox();
            this.btnRita = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnCirkel
            // 
            this.rBtnCirkel.AutoSize = true;
            this.rBtnCirkel.Location = new System.Drawing.Point(21, 44);
            this.rBtnCirkel.Name = "rBtnCirkel";
            this.rBtnCirkel.Size = new System.Drawing.Size(51, 17);
            this.rBtnCirkel.TabIndex = 0;
            this.rBtnCirkel.TabStop = true;
            this.rBtnCirkel.Tag = "form";
            this.rBtnCirkel.Text = "Cirkel";
            this.rBtnCirkel.UseVisualStyleBackColor = true;
            this.rBtnCirkel.CheckedChanged += new System.EventHandler(this.formChecka);
            // 
            // rBtnRektangel
            // 
            this.rBtnRektangel.AutoSize = true;
            this.rBtnRektangel.Location = new System.Drawing.Point(20, 157);
            this.rBtnRektangel.Name = "rBtnRektangel";
            this.rBtnRektangel.Size = new System.Drawing.Size(74, 17);
            this.rBtnRektangel.TabIndex = 1;
            this.rBtnRektangel.TabStop = true;
            this.rBtnRektangel.Tag = "form";
            this.rBtnRektangel.Text = "Rektangel";
            this.rBtnRektangel.UseVisualStyleBackColor = true;
            this.rBtnRektangel.CheckedChanged += new System.EventHandler(this.formChecka);
            // 
            // rBtnRuta
            // 
            this.rBtnRuta.AutoSize = true;
            this.rBtnRuta.Location = new System.Drawing.Point(20, 320);
            this.rBtnRuta.Name = "rBtnRuta";
            this.rBtnRuta.Size = new System.Drawing.Size(48, 17);
            this.rBtnRuta.TabIndex = 2;
            this.rBtnRuta.TabStop = true;
            this.rBtnRuta.Tag = "form";
            this.rBtnRuta.Text = "Ruta";
            this.rBtnRuta.UseVisualStyleBackColor = true;
            this.rBtnRuta.CheckedChanged += new System.EventHandler(this.formChecka);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radius:";
            // 
            // tbxRadius
            // 
            this.tbxRadius.Enabled = false;
            this.tbxRadius.Location = new System.Drawing.Point(42, 96);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(100, 20);
            this.tbxRadius.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Höjd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bredd";
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Enabled = false;
            this.tbxHöjd.Location = new System.Drawing.Point(41, 209);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(100, 20);
            this.tbxHöjd.TabIndex = 7;
            // 
            // tbxBredd
            // 
            this.tbxBredd.Enabled = false;
            this.tbxBredd.Location = new System.Drawing.Point(41, 252);
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(100, 20);
            this.tbxBredd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sida";
            // 
            // tbxSida
            // 
            this.tbxSida.Enabled = false;
            this.tbxSida.Location = new System.Drawing.Point(41, 369);
            this.tbxSida.Name = "tbxSida";
            this.tbxSida.Size = new System.Drawing.Size(100, 20);
            this.tbxSida.TabIndex = 10;
            // 
            // btnRita
            // 
            this.btnRita.Location = new System.Drawing.Point(57, 439);
            this.btnRita.Name = "btnRita";
            this.btnRita.Size = new System.Drawing.Size(75, 23);
            this.btnRita.TabIndex = 11;
            this.btnRita.Text = "Rita";
            this.btnRita.UseVisualStyleBackColor = true;
            this.btnRita.Click += new System.EventHandler(this.btnRita_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Location = new System.Drawing.Point(201, 471);
            this.lblSvar.MinimumSize = new System.Drawing.Size(500, 25);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(500, 25);
            this.lblSvar.TabIndex = 12;
            this.lblSvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxSida);
            this.groupBox1.Controls.Add(this.rBtnCirkel);
            this.groupBox1.Controls.Add(this.rBtnRektangel);
            this.groupBox1.Controls.Add(this.btnRita);
            this.groupBox1.Controls.Add(this.rBtnRuta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxRadius);
            this.groupBox1.Controls.Add(this.tbxBredd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxHöjd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(175, 479);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Välj en fom och ange information för att rita formen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSvar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Rita Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnCirkel;
        private System.Windows.Forms.RadioButton rBtnRektangel;
        private System.Windows.Forms.RadioButton rBtnRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.TextBox tbxBredd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSida;
        private System.Windows.Forms.Button btnRita;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

