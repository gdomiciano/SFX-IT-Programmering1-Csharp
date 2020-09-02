namespace Övning_3._3
{
    partial class DecimaltalTillHeltal
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
            this.TextBoxTexten = new System.Windows.Forms.TextBox();
            this.RundKnapp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxTexten
            // 
            this.TextBoxTexten.Location = new System.Drawing.Point(373, 174);
            this.TextBoxTexten.Name = "TextBoxTexten";
            this.TextBoxTexten.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTexten.TabIndex = 0;
            // 
            // RundKnapp
            // 
            this.RundKnapp.Location = new System.Drawing.Point(387, 220);
            this.RundKnapp.Name = "RundKnapp";
            this.RundKnapp.Size = new System.Drawing.Size(75, 23);
            this.RundKnapp.TabIndex = 1;
            this.RundKnapp.Text = "AvRunda";
            this.RundKnapp.UseVisualStyleBackColor = true;
            this.RundKnapp.Click += new System.EventHandler(this.RundKnapp_Click);
            // 
            // DecimaltalTillHeltal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonToRoundNumbers);
            this.Controls.Add(this.TextBoxInput);
            this.Name = "DecimaltalTillHeltal";
=======
            this.Controls.Add(this.RundKnapp);
            this.Controls.Add(this.TextBoxTexten);
            this.Name = "Form1";
>>>>>>> bc0c34981a2547eb8179e4cba2468ee054f05a7d
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxTexten;
        private System.Windows.Forms.Button RundKnapp;
    }
}

