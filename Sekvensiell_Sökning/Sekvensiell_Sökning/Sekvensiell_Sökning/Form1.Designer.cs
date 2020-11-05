namespace Sekvensiell_Sökning
{
    partial class Sekvensiell_Sökning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sekvensiell_Sökning));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSöktValör = new System.Windows.Forms.TextBox();
            this.tbxIndex = new System.Windows.Forms.TextBox();
            this.btnSök = new System.Windows.Forms.Button();
            this.btnBlanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kortens valörer är 2 till 10. Sök efter ett kort och se dess index.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sökt valör:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(14, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Index:";
            // 
            // tbxSöktValör
            // 
            this.tbxSöktValör.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSöktValör.Location = new System.Drawing.Point(108, 76);
            this.tbxSöktValör.Name = "tbxSöktValör";
            this.tbxSöktValör.Size = new System.Drawing.Size(88, 26);
            this.tbxSöktValör.TabIndex = 3;
            // 
            // tbxIndex
            // 
            this.tbxIndex.Enabled = false;
            this.tbxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIndex.Location = new System.Drawing.Point(108, 117);
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(88, 26);
            this.tbxIndex.TabIndex = 4;
            // 
            // btnSök
            // 
            this.btnSök.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSök.Location = new System.Drawing.Point(154, 307);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(176, 34);
            this.btnSök.TabIndex = 5;
            this.btnSök.Text = "Sekventiell sökning";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // btnBlanda
            // 
            this.btnBlanda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBlanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanda.Location = new System.Drawing.Point(335, 307);
            this.btnBlanda.Name = "btnBlanda";
            this.btnBlanda.Size = new System.Drawing.Size(127, 34);
            this.btnBlanda.TabIndex = 6;
            this.btnBlanda.Text = "Blanda";
            this.btnBlanda.UseVisualStyleBackColor = true;
            this.btnBlanda.Click += new System.EventHandler(this.btnBlanda_Click);
            // 
            // Sekvensiell_Sökning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(687, 353);
            this.Controls.Add(this.btnBlanda);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.tbxIndex);
            this.Controls.Add(this.tbxSöktValör);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sekvensiell_Sökning";
            this.Text = "Sekvensiell Sökning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSöktValör;
        private System.Windows.Forms.TextBox tbxIndex;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.Button btnBlanda;
    }
}

