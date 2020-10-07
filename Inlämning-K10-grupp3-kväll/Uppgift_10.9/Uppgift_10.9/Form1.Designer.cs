namespace Uppgift_10._9
{
    partial class Uppgift_10_9
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
            this.btnKasta = new System.Windows.Forms.Button();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKasta
            // 
            this.btnKasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKasta.Location = new System.Drawing.Point(26, 13);
            this.btnKasta.Name = "btnKasta";
            this.btnKasta.Size = new System.Drawing.Size(156, 33);
            this.btnKasta.TabIndex = 0;
            this.btnKasta.Text = "Kasta tärningarna";
            this.btnKasta.UseVisualStyleBackColor = true;
            // 
            // tbxResultat
            // 
            this.tbxResultat.Enabled = false;
            this.tbxResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResultat.Location = new System.Drawing.Point(26, 52);
            this.tbxResultat.Multiline = true;
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.Size = new System.Drawing.Size(156, 131);
            this.tbxResultat.TabIndex = 1;
            // 
            // Uppgift_10_9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 204);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.btnKasta);
            this.Name = "Uppgift_10_9";
            this.Text = "Uppgift 10.9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKasta;
        private System.Windows.Forms.TextBox tbxResultat;
    }
}

