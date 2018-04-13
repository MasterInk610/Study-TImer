namespace Study_Timer
{
    partial class frmStdyTmr
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
            this.components = new System.ComponentModel.Container();
            this.prgbr1 = new ProgressBarColour();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnStdy3 = new System.Windows.Forms.RadioButton();
            this.rdbtnStdy2 = new System.Windows.Forms.RadioButton();
            this.rdbtnStdy1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnBrk3 = new System.Windows.Forms.RadioButton();
            this.rdbtnBrk2 = new System.Windows.Forms.RadioButton();
            this.rdbtnBrk1 = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrStdy = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgbr1
            // 
            this.prgbr1.Location = new System.Drawing.Point(12, 125);
            this.prgbr1.Name = "prgbr1";
            this.prgbr1.Size = new System.Drawing.Size(352, 55);
            this.prgbr1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnStdy3);
            this.groupBox1.Controls.Add(this.rdbtnStdy2);
            this.groupBox1.Controls.Add(this.rdbtnStdy1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Study Time";
            // 
            // rdbtnStdy3
            // 
            this.rdbtnStdy3.AutoSize = true;
            this.rdbtnStdy3.Location = new System.Drawing.Point(6, 72);
            this.rdbtnStdy3.Name = "rdbtnStdy3";
            this.rdbtnStdy3.Size = new System.Drawing.Size(55, 17);
            this.rdbtnStdy3.TabIndex = 2;
            this.rdbtnStdy3.TabStop = true;
            this.rdbtnStdy3.Text = "2 hour";
            this.rdbtnStdy3.UseVisualStyleBackColor = true;
            // 
            // rdbtnStdy2
            // 
            this.rdbtnStdy2.AutoSize = true;
            this.rdbtnStdy2.Location = new System.Drawing.Point(6, 49);
            this.rdbtnStdy2.Name = "rdbtnStdy2";
            this.rdbtnStdy2.Size = new System.Drawing.Size(55, 17);
            this.rdbtnStdy2.TabIndex = 1;
            this.rdbtnStdy2.TabStop = true;
            this.rdbtnStdy2.Text = "1 hour";
            this.rdbtnStdy2.UseVisualStyleBackColor = true;
            // 
            // rdbtnStdy1
            // 
            this.rdbtnStdy1.AutoSize = true;
            this.rdbtnStdy1.Location = new System.Drawing.Point(6, 26);
            this.rdbtnStdy1.Name = "rdbtnStdy1";
            this.rdbtnStdy1.Size = new System.Drawing.Size(56, 17);
            this.rdbtnStdy1.TabIndex = 0;
            this.rdbtnStdy1.TabStop = true;
            this.rdbtnStdy1.Text = "30 min";
            this.rdbtnStdy1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnBrk3);
            this.groupBox2.Controls.Add(this.rdbtnBrk2);
            this.groupBox2.Controls.Add(this.rdbtnBrk1);
            this.groupBox2.Location = new System.Drawing.Point(248, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Break Time";
            // 
            // rdbtnBrk3
            // 
            this.rdbtnBrk3.AutoSize = true;
            this.rdbtnBrk3.Location = new System.Drawing.Point(6, 72);
            this.rdbtnBrk3.Name = "rdbtnBrk3";
            this.rdbtnBrk3.Size = new System.Drawing.Size(56, 17);
            this.rdbtnBrk3.TabIndex = 2;
            this.rdbtnBrk3.TabStop = true;
            this.rdbtnBrk3.Text = "30 min";
            this.rdbtnBrk3.UseVisualStyleBackColor = true;
            // 
            // rdbtnBrk2
            // 
            this.rdbtnBrk2.AutoSize = true;
            this.rdbtnBrk2.Location = new System.Drawing.Point(6, 49);
            this.rdbtnBrk2.Name = "rdbtnBrk2";
            this.rdbtnBrk2.Size = new System.Drawing.Size(56, 17);
            this.rdbtnBrk2.TabIndex = 1;
            this.rdbtnBrk2.TabStop = true;
            this.rdbtnBrk2.Text = "15 min";
            this.rdbtnBrk2.UseVisualStyleBackColor = true;
            // 
            // rdbtnBrk1
            // 
            this.rdbtnBrk1.AutoSize = true;
            this.rdbtnBrk1.Location = new System.Drawing.Point(6, 26);
            this.rdbtnBrk1.Name = "rdbtnBrk1";
            this.rdbtnBrk1.Size = new System.Drawing.Size(56, 17);
            this.rdbtnBrk1.TabIndex = 0;
            this.rdbtnBrk1.TabStop = true;
            this.rdbtnBrk1.Text = "10 min";
            this.rdbtnBrk1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(135, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Time";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(135, 76);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 35);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Emergency Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrStdy
            // 
            this.tmrStdy.Interval = 1000;
            this.tmrStdy.Tick += new System.EventHandler(this.tmrStdy_Tick);
            // 
            // frmStdyTmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 192);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prgbr1);
            this.Name = "frmStdyTmr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Time";
            this.Load += new System.EventHandler(this.frmStdyTmr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgbr1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnStdy3;
        private System.Windows.Forms.RadioButton rdbtnStdy2;
        private System.Windows.Forms.RadioButton rdbtnStdy1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnBrk3;
        private System.Windows.Forms.RadioButton rdbtnBrk2;
        private System.Windows.Forms.RadioButton rdbtnBrk1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrStdy;
    }
}

