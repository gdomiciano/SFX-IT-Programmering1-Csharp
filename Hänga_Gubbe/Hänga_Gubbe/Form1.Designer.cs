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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // mTbxSvar
            // 
            resources.ApplyResources(this.mTbxSvar, "mTbxSvar");
            this.mTbxSvar.Name = "mTbxSvar";
            this.mTbxSvar.UseSystemPasswordChar = true;
            this.mTbxSvar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MTbxSvar_KeyUp);
            // 
            // pbxMark
            // 
            resources.ApplyResources(this.pbxMark, "pbxMark");
            this.pbxMark.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pbxMark.Name = "pbxMark";
            this.pbxMark.TabStop = false;
            this.pbxMark.Paint += new System.Windows.Forms.PaintEventHandler(this.PbxMark_Paint);
            // 
            // tbxGissa
            // 
            this.tbxGissa.AcceptsReturn = true;
            resources.ApplyResources(this.tbxGissa, "tbxGissa");
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.TextChanged += new System.EventHandler(this.TbxGissa_TextChanged);
            // 
            // lblInfo
            // 
            resources.ApplyResources(this.lblInfo, "lblInfo");
            this.lblInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo.Name = "lblInfo";
            // 
            // pbxGubbe
            // 
            resources.ApplyResources(this.pbxGubbe, "pbxGubbe");
            this.pbxGubbe.BackColor = System.Drawing.Color.Transparent;
            this.pbxGubbe.Name = "pbxGubbe";
            this.pbxGubbe.TabStop = false;
            // 
            // tbxVisa
            // 
            resources.ApplyResources(this.tbxVisa, "tbxVisa");
            this.tbxVisa.BackColor = System.Drawing.SystemColors.Control;
            this.tbxVisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxVisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxVisa.Name = "tbxVisa";
            // 
            // btnSlumpa
            // 
            resources.ApplyResources(this.btnSlumpa, "btnSlumpa");
            this.btnSlumpa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSlumpa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSlumpa.Name = "btnSlumpa";
            this.btnSlumpa.UseVisualStyleBackColor = false;
            this.btnSlumpa.Click += new System.EventHandler(this.BtnSlumpa_Click);
            // 
            // Spel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSlumpa);
            this.Controls.Add(this.tbxVisa);
            this.Controls.Add(this.pbxGubbe);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbxGissa);
            this.Controls.Add(this.pbxMark);
            this.Controls.Add(this.mTbxSvar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Spel";
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

