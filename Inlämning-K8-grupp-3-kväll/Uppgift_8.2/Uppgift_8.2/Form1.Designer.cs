namespace Uppgift_8._2
{
    partial class Uppgift_8_2
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnVissaFärg = new System.Windows.Forms.Button();
            this.txbR = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.txbG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(29, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(278, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Skriv färgerns RGB-värde i textrutorna";
            // 
            // btnVissaFärg
            // 
            this.btnVissaFärg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVissaFärg.Location = new System.Drawing.Point(242, 48);
            this.btnVissaFärg.Name = "btnVissaFärg";
            this.btnVissaFärg.Size = new System.Drawing.Size(77, 37);
            this.btnVissaFärg.TabIndex = 1;
            this.btnVissaFärg.Text = "Visa färg";
            this.btnVissaFärg.UseVisualStyleBackColor = true;
            this.btnVissaFärg.Click += new System.EventHandler(this.btnVissaFärg_Click);
            // 
            // txbR
            // 
            this.txbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbR.Location = new System.Drawing.Point(36, 56);
            this.txbR.Name = "txbR";
            this.txbR.Size = new System.Drawing.Size(42, 23);
            this.txbR.TabIndex = 2;
            // 
            // txbB
            // 
            this.txbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbB.Location = new System.Drawing.Point(187, 55);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(40, 23);
            this.txbB.TabIndex = 3;
            // 
            // txbG
            // 
            this.txbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbG.Location = new System.Drawing.Point(112, 56);
            this.txbG.Name = "txbG";
            this.txbG.Size = new System.Drawing.Size(40, 23);
            this.txbG.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // lblFel
            // 
            this.lblFel.AutoSize = true;
            this.lblFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFel.Location = new System.Drawing.Point(69, 125);
            this.lblFel.Name = "lblFel";
            this.lblFel.Size = new System.Drawing.Size(0, 20);
            this.lblFel.TabIndex = 8;
            this.lblFel.Visible = false;
            // 
            // Uppgift_8_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 229);
            this.Controls.Add(this.lblFel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbG);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbR);
            this.Controls.Add(this.btnVissaFärg);
            this.Controls.Add(this.lblInfo);
            this.Name = "Uppgift_8_2";
            this.Text = "Uppgift 8.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnVissaFärg;
        private System.Windows.Forms.TextBox txbR;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.TextBox txbG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFel;
    }
}

