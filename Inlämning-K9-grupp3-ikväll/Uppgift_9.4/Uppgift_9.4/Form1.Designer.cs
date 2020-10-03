namespace Uppgift_9._4
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
            this.pbxBoll = new System.Windows.Forms.PictureBox();
            this.btnFlyttaBoll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBoll)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBoll
            // 
            this.pbxBoll.BackColor = System.Drawing.Color.Transparent;
            this.pbxBoll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBoll.BackgroundImage")));
            this.pbxBoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBoll.Location = new System.Drawing.Point(26, 41);
            this.pbxBoll.Name = "pbxBoll";
            this.pbxBoll.Size = new System.Drawing.Size(89, 64);
            this.pbxBoll.TabIndex = 0;
            this.pbxBoll.TabStop = false;
            // 
            // btnFlyttaBoll
            // 
            this.btnFlyttaBoll.Location = new System.Drawing.Point(15, 12);
            this.btnFlyttaBoll.Name = "btnFlyttaBoll";
            this.btnFlyttaBoll.Size = new System.Drawing.Size(114, 23);
            this.btnFlyttaBoll.TabIndex = 1;
            this.btnFlyttaBoll.Text = "Flytta boll till botten";
            this.btnFlyttaBoll.UseVisualStyleBackColor = true;
            this.btnFlyttaBoll.Click += new System.EventHandler(this.btnFlyttaBoll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 414);
            this.Controls.Add(this.btnFlyttaBoll);
            this.Controls.Add(this.pbxBoll);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBoll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBoll;
        private System.Windows.Forms.Button btnFlyttaBoll;
    }
}

