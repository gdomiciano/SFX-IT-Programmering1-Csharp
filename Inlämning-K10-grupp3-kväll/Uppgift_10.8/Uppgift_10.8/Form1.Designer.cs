namespace Uppgift_10._8
{
    partial class Uppgift_10_8
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
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnVisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tid i sekunder:";
            // 
            // tbxTid
            // 
            this.tbxTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTid.Location = new System.Drawing.Point(121, 10);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.Size = new System.Drawing.Size(93, 23);
            this.tbxTid.TabIndex = 1;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.Location = new System.Drawing.Point(16, 65);
            this.lblSvar.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(200, 19);
            this.lblSvar.TabIndex = 2;
            // 
            // btnVisa
            // 
            this.btnVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisa.Location = new System.Drawing.Point(81, 109);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 23);
            this.btnVisa.TabIndex = 3;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // Uppgift_10_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 158);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxTid);
            this.Controls.Add(this.label1);
            this.Name = "Uppgift_10_8";
            this.Text = "Uppgift 10.8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTid;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnVisa;
    }
}

