namespace Uppgift_7._2
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
            this.lblEttiket = new System.Windows.Forms.Label();
            this.tbxSlag = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEttiket
            // 
            this.lblEttiket.AutoSize = true;
            this.lblEttiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEttiket.Location = new System.Drawing.Point(17, 35);
            this.lblEttiket.Name = "lblEttiket";
            this.lblEttiket.Size = new System.Drawing.Size(98, 17);
            this.lblEttiket.TabIndex = 0;
            this.lblEttiket.Text = "Slagets längd:";
            // 
            // tbxSlag
            // 
            this.tbxSlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSlag.Location = new System.Drawing.Point(121, 32);
            this.tbxSlag.Name = "tbxSlag";
            this.tbxSlag.Size = new System.Drawing.Size(100, 23);
            this.tbxSlag.TabIndex = 1;
            this.tbxSlag.TextChanged += new System.EventHandler(this.tbxSlag_TextChanged);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.Location = new System.Drawing.Point(32, 77);
            this.lblSvar.MinimumSize = new System.Drawing.Size(180, 20);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(180, 20);
            this.lblSvar.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(81, 124);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 174);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxSlag);
            this.Controls.Add(this.lblEttiket);
            this.Name = "Form1";
            this.Text = "Uppgift 7.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEttiket;
        private System.Windows.Forms.TextBox tbxSlag;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnOk;
    }
}

