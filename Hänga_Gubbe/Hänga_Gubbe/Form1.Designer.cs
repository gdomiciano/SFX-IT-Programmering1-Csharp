namespace Hänga_Gubbe
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
            this.label1 = new System.Windows.Forms.Label();
            this.mTbxSvar = new System.Windows.Forms.MaskedTextBox();
            this.pbxMark = new System.Windows.Forms.PictureBox();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxGubbe = new System.Windows.Forms.PictureBox();
            this.tbxVisa = new System.Windows.Forms.TextBox();
            this.btnSlumpa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGubbe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rätt svar";
            // 
            // mTbxSvar
            // 
            this.mTbxSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTbxSvar.Location = new System.Drawing.Point(31, 30);
            this.mTbxSvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTbxSvar.Name = "mTbxSvar";
            this.mTbxSvar.Size = new System.Drawing.Size(116, 23);
            this.mTbxSvar.TabIndex = 1;
            this.mTbxSvar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTbxSvar.UseSystemPasswordChar = true;
            // 
            // pbxMark
            // 
            this.pbxMark.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pbxMark.Location = new System.Drawing.Point(13, 61);
            this.pbxMark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxMark.Name = "pbxMark";
            this.pbxMark.Size = new System.Drawing.Size(300, 330);
            this.pbxMark.TabIndex = 2;
            this.pbxMark.TabStop = false;
            // 
            // tbxGissa
            // 
            this.tbxGissa.AcceptsReturn = true;
            this.tbxGissa.Location = new System.Drawing.Point(122, 439);
            this.tbxGissa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxGissa.MinimumSize = new System.Drawing.Size(60, 30);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(60, 30);
            this.tbxGissa.TabIndex = 4;
            this.tbxGissa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 490);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // pbxGubbe
            // 
            this.pbxGubbe.BackColor = System.Drawing.Color.Gold;
            this.pbxGubbe.Location = new System.Drawing.Point(129, 84);
            this.pbxGubbe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxGubbe.Name = "pbxGubbe";
            this.pbxGubbe.Size = new System.Drawing.Size(53, 54);
            this.pbxGubbe.TabIndex = 6;
            this.pbxGubbe.TabStop = false;
            // 
            // tbxVisa
            // 
            this.tbxVisa.BackColor = System.Drawing.SystemColors.Control;
            this.tbxVisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVisa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxVisa.Location = new System.Drawing.Point(12, 398);
            this.tbxVisa.MinimumSize = new System.Drawing.Size(300, 34);
            this.tbxVisa.Name = "tbxVisa";
            this.tbxVisa.Size = new System.Drawing.Size(300, 34);
            this.tbxVisa.TabIndex = 7;
            // 
            // btnSlumpa
            // 
            this.btnSlumpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlumpa.Location = new System.Drawing.Point(182, 30);
            this.btnSlumpa.Name = "btnSlumpa";
            this.btnSlumpa.Size = new System.Drawing.Size(112, 23);
            this.btnSlumpa.TabIndex = 8;
            this.btnSlumpa.Text = "Slumpa Svar!";
            this.btnSlumpa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 533);
            this.Controls.Add(this.btnSlumpa);
            this.Controls.Add(this.tbxVisa);
            this.Controls.Add(this.pbxGubbe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxGissa);
            this.Controls.Add(this.pbxMark);
            this.Controls.Add(this.mTbxSvar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGubbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTbxSvar;
        private System.Windows.Forms.PictureBox pbxMark;
        private System.Windows.Forms.TextBox tbxGissa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxGubbe;
        private System.Windows.Forms.TextBox tbxVisa;
        private System.Windows.Forms.Button btnSlumpa;
    }
}

