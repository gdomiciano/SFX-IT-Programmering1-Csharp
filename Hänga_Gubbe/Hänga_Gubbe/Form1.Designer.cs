namespace Hänga_Gubbe
{
    partial class Spel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spel));
            this.label1 = new System.Windows.Forms.Label();
            this.mTbxSvar = new System.Windows.Forms.MaskedTextBox();
            this.pbxMark = new System.Windows.Forms.PictureBox();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
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
            this.mTbxSvar.Margin = new System.Windows.Forms.Padding(4);
            this.mTbxSvar.Name = "mTbxSvar";
            this.mTbxSvar.Size = new System.Drawing.Size(116, 23);
            this.mTbxSvar.TabIndex = 1;
            this.mTbxSvar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTbxSvar.UseSystemPasswordChar = true;
            this.mTbxSvar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbxSvar_KeyUp);
            // 
            // pbxMark
            // 
            this.pbxMark.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pbxMark.Location = new System.Drawing.Point(13, 61);
            this.pbxMark.Margin = new System.Windows.Forms.Padding(4);
            this.pbxMark.Name = "pbxMark";
            this.pbxMark.Size = new System.Drawing.Size(300, 330);
            this.pbxMark.TabIndex = 2;
            this.pbxMark.TabStop = false;
            this.pbxMark.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxMark_Paint);
            // 
            // tbxGissa
            // 
            this.tbxGissa.AcceptsReturn = true;
            this.tbxGissa.Location = new System.Drawing.Point(142, 434);
            this.tbxGissa.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGissa.MinimumSize = new System.Drawing.Size(60, 40);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(60, 40);
            this.tbxGissa.TabIndex = 4;
            this.tbxGissa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxGissa.TextChanged += new System.EventHandler(this.tbxGissa_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo.Location = new System.Drawing.Point(8, 482);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.MinimumSize = new System.Drawing.Size(300, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(300, 30);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxGubbe
            // 
            this.pbxGubbe.BackColor = System.Drawing.Color.Transparent;
            this.pbxGubbe.Image = ((System.Drawing.Image)(resources.GetObject("pbxGubbe.Image")));
            this.pbxGubbe.InitialImage = null;
            this.pbxGubbe.Location = new System.Drawing.Point(122, 72);
            this.pbxGubbe.Margin = new System.Windows.Forms.Padding(4);
            this.pbxGubbe.Name = "pbxGubbe";
            this.pbxGubbe.Size = new System.Drawing.Size(80, 80);
            this.pbxGubbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGubbe.TabIndex = 6;
            this.pbxGubbe.TabStop = false;
            // 
            // tbxVisa
            // 
            this.tbxVisa.BackColor = System.Drawing.SystemColors.Control;
            this.tbxVisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxVisa.Location = new System.Drawing.Point(12, 398);
            this.tbxVisa.MinimumSize = new System.Drawing.Size(300, 34);
            this.tbxVisa.Name = "tbxVisa";
            this.tbxVisa.Size = new System.Drawing.Size(300, 29);
            this.tbxVisa.TabIndex = 7;
            this.tbxVisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // Spel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 533);
            this.Controls.Add(this.btnSlumpa);
            this.Controls.Add(this.tbxVisa);
            this.Controls.Add(this.pbxGubbe);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbxGissa);
            this.Controls.Add(this.pbxMark);
            this.Controls.Add(this.mTbxSvar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Spel";
            this.Text = "Hänga gubbe | spel";
            this.Load += new System.EventHandler(this.Spel_Load);
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
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pbxGubbe;
        private System.Windows.Forms.TextBox tbxVisa;
        private System.Windows.Forms.Button btnSlumpa;
    }
}

