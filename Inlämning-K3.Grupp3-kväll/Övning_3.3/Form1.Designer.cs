namespace Övning_3._3
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
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonToRoundNumbers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(373, 174);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(100, 20);
            this.TextBoxInput.TabIndex = 0;
            // 
            // ButtonToRoundNumbers
            // 
            this.ButtonToRoundNumbers.Location = new System.Drawing.Point(387, 220);
            this.ButtonToRoundNumbers.Name = "ButtonToRoundNumbers";
            this.ButtonToRoundNumbers.Size = new System.Drawing.Size(75, 23);
            this.ButtonToRoundNumbers.TabIndex = 1;
            this.ButtonToRoundNumbers.Text = "Round";
            this.ButtonToRoundNumbers.UseVisualStyleBackColor = true;
            this.ButtonToRoundNumbers.Click += new System.EventHandler(this.ButtonToRoundNumbers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hint: Use Numbers in the form of 10,5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonToRoundNumbers);
            this.Controls.Add(this.TextBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonToRoundNumbers;
        private System.Windows.Forms.Label label1;
    }
}

