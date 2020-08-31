namespace Uppgift_2._1
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
            this.btnRöd = new System.Windows.Forms.Button();
            this.btnBlå = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRöd
            // 
            this.btnRöd.Location = new System.Drawing.Point(50, 64);
            this.btnRöd.Name = "btnRöd";
            this.btnRöd.Size = new System.Drawing.Size(75, 23);
            this.btnRöd.TabIndex = 0;
            this.btnRöd.Text = "Röd";
            this.btnRöd.UseVisualStyleBackColor = true;
            this.btnRöd.Click += new System.EventHandler(this.btnRöd_Click);
            // 
            // btnBlå
            // 
            this.btnBlå.Location = new System.Drawing.Point(255, 64);
            this.btnBlå.Name = "btnBlå";
            this.btnBlå.Size = new System.Drawing.Size(75, 23);
            this.btnBlå.TabIndex = 1;
            this.btnBlå.Text = "Blå";
            this.btnBlå.UseVisualStyleBackColor = true;
            this.btnBlå.Click += new System.EventHandler(this.btnBlå_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnBlå);
            this.Controls.Add(this.btnRöd);
            this.Name = "Form1";
            this.Text = "Uppgift";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRöd;
        private System.Windows.Forms.Button btnBlå;
    }
}

