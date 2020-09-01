namespace Övning_3._4b
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
            this.InputWithdraw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FemHundraBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HundraBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputWithdraw
            // 
            this.InputWithdraw.Location = new System.Drawing.Point(356, 157);
            this.InputWithdraw.Name = "InputWithdraw";
            this.InputWithdraw.Size = new System.Drawing.Size(100, 20);
            this.InputWithdraw.TabIndex = 0;
            this.InputWithdraw.TextChanged += new System.EventHandler(this.InputWithdraw_TextChanged);
            this.InputWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputWithdraw_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ammount To Withdraw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uttag i 500-sedlar";
            // 
            // FemHundraBox
            // 
            this.FemHundraBox.Location = new System.Drawing.Point(299, 224);
            this.FemHundraBox.Name = "FemHundraBox";
            this.FemHundraBox.Size = new System.Drawing.Size(100, 20);
            this.FemHundraBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uttag i 100-sedlar";
            // 
            // HundraBox
            // 
            this.HundraBox.Location = new System.Drawing.Point(299, 263);
            this.HundraBox.Name = "HundraBox";
            this.HundraBox.Size = new System.Drawing.Size(100, 20);
            this.HundraBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HundraBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FemHundraBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputWithdraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputWithdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FemHundraBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HundraBox;
    }
}

