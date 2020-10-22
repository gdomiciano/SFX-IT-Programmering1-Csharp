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
            this.SuspendLayout();
            // 
            // rBtnCirkel
            // 
            this.rBtnCirkel.AutoSize = true;
            this.rBtnCirkel.Location = new System.Drawing.Point(28, 63);
            this.rBtnCirkel.Name = "rBtnCirkel";
            this.rBtnCirkel.Size = new System.Drawing.Size(51, 17);
            this.rBtnCirkel.TabIndex = 0;
            this.rBtnCirkel.TabStop = true;
            this.rBtnCirkel.Tag = "form";
            this.rBtnCirkel.Text = "Cirkel";
            this.rBtnCirkel.UseVisualStyleBackColor = true;
            // 
            // rBtnRektangel
            // 
            this.rBtnRektangel.AutoSize = true;
            this.rBtnRektangel.Location = new System.Drawing.Point(28, 197);
            this.rBtnRektangel.Name = "rBtnRektangel";
            this.rBtnRektangel.Size = new System.Drawing.Size(74, 17);
            this.rBtnRektangel.TabIndex = 1;
            this.rBtnRektangel.TabStop = true;
            this.rBtnRektangel.Tag = "form";
            this.rBtnRektangel.Text = "Rektangel";
            this.rBtnRektangel.UseVisualStyleBackColor = true;
            // 
            // rBtnRuta
            // 
            this.rBtnRuta.AutoSize = true;
            this.rBtnRuta.Location = new System.Drawing.Point(31, 383);
            this.rBtnRuta.Name = "rBtnRuta";
            this.rBtnRuta.Size = new System.Drawing.Size(48, 17);
            this.rBtnRuta.TabIndex = 2;
            this.rBtnRuta.TabStop = true;
            this.rBtnRuta.Tag = "form";
            this.rBtnRuta.Text = "Ruta";
            this.rBtnRuta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radius:";
            // 
            // tbxRadius
            // 
            this.tbxRadius.Location = new System.Drawing.Point(70, 116);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(100, 20);
            this.tbxRadius.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Höjd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bredd";
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(70, 249);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(100, 20);
            this.tbxHöjd.TabIndex = 7;
            // 
            // tbxBredd
            // 
            this.tbxBredd.Location = new System.Drawing.Point(70, 292);
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(100, 20);
            this.tbxBredd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Höjd";
            // 
            // tbxSida
            // 
            this.tbxSida.Location = new System.Drawing.Point(73, 436);
            this.tbxSida.Name = "tbxSida";
            this.tbxSida.Size = new System.Drawing.Size(100, 20);
            this.tbxSida.TabIndex = 10;
            // 
            // btnRita
            // 
            this.btnRita.Location = new System.Drawing.Point(58, 536);
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
            this.lblSvar.Location = new System.Drawing.Point(282, 480);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(50, 13);
            this.lblSvar.TabIndex = 12;
            this.lblSvar.Text = "Arean är:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 596);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnRita);
            this.Controls.Add(this.tbxSida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxBredd);
            this.Controls.Add(this.tbxHöjd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxRadius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBtnRuta);
            this.Controls.Add(this.rBtnRektangel);
            this.Controls.Add(this.rBtnCirkel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

