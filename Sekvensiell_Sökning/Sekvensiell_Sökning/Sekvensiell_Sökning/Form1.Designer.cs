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
            this.lblFeedback = new System.Windows.Forms.Label();
            this.gbxHistorik = new System.Windows.Forms.GroupBox();
            this.btnKlaraHistorik = new System.Windows.Forms.Button();
            this.tbxHistorik = new System.Windows.Forms.TextBox();
            this.gbxHistorik.SuspendLayout();
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
            this.tbxSöktValör.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSöktValör.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSöktValör.Location = new System.Drawing.Point(108, 76);
            this.tbxSöktValör.Name = "tbxSöktValör";
            this.tbxSöktValör.Size = new System.Drawing.Size(46, 26);
            this.tbxSöktValör.TabIndex = 3;
            this.tbxSöktValör.TextChanged += new System.EventHandler(this.tbxSöktValör_TextChanged);
            // 
            // tbxIndex
            // 
            this.tbxIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxIndex.Enabled = false;
            this.tbxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIndex.Location = new System.Drawing.Point(108, 117);
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(46, 26);
            this.tbxIndex.TabIndex = 4;
            // 
            // btnSök
            // 
            this.btnSök.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSök.Enabled = false;
            this.btnSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSök.Location = new System.Drawing.Point(157, 270);
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
            this.btnBlanda.Location = new System.Drawing.Point(338, 270);
            this.btnBlanda.Name = "btnBlanda";
            this.btnBlanda.Size = new System.Drawing.Size(127, 34);
            this.btnBlanda.TabIndex = 6;
            this.btnBlanda.Text = "Blanda";
            this.btnBlanda.UseVisualStyleBackColor = true;
            this.btnBlanda.Click += new System.EventHandler(this.btnBlanda_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblFeedback.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFeedback.Location = new System.Drawing.Point(160, 80);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 19);
            this.lblFeedback.TabIndex = 7;
            // 
            // gbxHistorik
            // 
            this.gbxHistorik.Controls.Add(this.tbxHistorik);
            this.gbxHistorik.Controls.Add(this.btnKlaraHistorik);
            this.gbxHistorik.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHistorik.ForeColor = System.Drawing.SystemColors.Info;
            this.gbxHistorik.Location = new System.Drawing.Point(674, 12);
            this.gbxHistorik.Name = "gbxHistorik";
            this.gbxHistorik.Size = new System.Drawing.Size(241, 292);
            this.gbxHistorik.TabIndex = 8;
            this.gbxHistorik.TabStop = false;
            this.gbxHistorik.Text = "Sökhistorik";
            // 
            // btnKlaraHistorik
            // 
            this.btnKlaraHistorik.Enabled = false;
            this.btnKlaraHistorik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKlaraHistorik.Location = new System.Drawing.Point(6, 245);
            this.btnKlaraHistorik.Name = "btnKlaraHistorik";
            this.btnKlaraHistorik.Size = new System.Drawing.Size(229, 36);
            this.btnKlaraHistorik.TabIndex = 0;
            this.btnKlaraHistorik.Text = "Klara historiken";
            this.btnKlaraHistorik.UseVisualStyleBackColor = true;
            this.btnKlaraHistorik.Click += new System.EventHandler(this.btnKlaraHistorik_Click);
            // 
            // tbxHistorik
            // 
            this.tbxHistorik.Enabled = false;
            this.tbxHistorik.Location = new System.Drawing.Point(7, 29);
            this.tbxHistorik.Multiline = true;
            this.tbxHistorik.Name = "tbxHistorik";
            this.tbxHistorik.ReadOnly = true;
            this.tbxHistorik.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxHistorik.Size = new System.Drawing.Size(228, 210);
            this.tbxHistorik.TabIndex = 1;
            // 
            // Sekvensiell_Sökning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(937, 320);
            this.Controls.Add(this.gbxHistorik);
            this.Controls.Add(this.lblFeedback);
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
            this.gbxHistorik.ResumeLayout(false);
            this.gbxHistorik.PerformLayout();
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
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.GroupBox gbxHistorik;
        private System.Windows.Forms.TextBox tbxHistorik;
        private System.Windows.Forms.Button btnKlaraHistorik;
    }
}

