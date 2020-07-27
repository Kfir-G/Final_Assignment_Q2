namespace Final_Assignment_Q2
{
    partial class Exam
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdbtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.rdbtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdbtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.rdbtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnGiveQ = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(37, 28);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(82, 20);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question?";
            // 
            // rdbtnAnswer1
            // 
            this.rdbtnAnswer1.AutoSize = true;
            this.rdbtnAnswer1.Location = new System.Drawing.Point(41, 73);
            this.rdbtnAnswer1.Name = "rdbtnAnswer1";
            this.rdbtnAnswer1.Size = new System.Drawing.Size(100, 24);
            this.rdbtnAnswer1.TabIndex = 1;
            this.rdbtnAnswer1.TabStop = true;
            this.rdbtnAnswer1.Text = "Answer 1";
            this.rdbtnAnswer1.UseVisualStyleBackColor = true;
            this.rdbtnAnswer1.CheckedChanged += new System.EventHandler(this.rdbtnAnswer1_CheckedChanged);
            // 
            // rdbtnAnswer2
            // 
            this.rdbtnAnswer2.AutoSize = true;
            this.rdbtnAnswer2.Location = new System.Drawing.Point(41, 120);
            this.rdbtnAnswer2.Name = "rdbtnAnswer2";
            this.rdbtnAnswer2.Size = new System.Drawing.Size(100, 24);
            this.rdbtnAnswer2.TabIndex = 2;
            this.rdbtnAnswer2.TabStop = true;
            this.rdbtnAnswer2.Text = "Answer 2";
            this.rdbtnAnswer2.UseVisualStyleBackColor = true;
            this.rdbtnAnswer2.CheckedChanged += new System.EventHandler(this.rdbtnAnswer2_CheckedChanged);
            // 
            // rdbtnAnswer3
            // 
            this.rdbtnAnswer3.AutoSize = true;
            this.rdbtnAnswer3.Location = new System.Drawing.Point(41, 162);
            this.rdbtnAnswer3.Name = "rdbtnAnswer3";
            this.rdbtnAnswer3.Size = new System.Drawing.Size(100, 24);
            this.rdbtnAnswer3.TabIndex = 3;
            this.rdbtnAnswer3.TabStop = true;
            this.rdbtnAnswer3.Text = "Answer 3";
            this.rdbtnAnswer3.UseVisualStyleBackColor = true;
            this.rdbtnAnswer3.CheckedChanged += new System.EventHandler(this.rdbtnAnswer3_CheckedChanged);
            // 
            // rdbtnAnswer4
            // 
            this.rdbtnAnswer4.AutoSize = true;
            this.rdbtnAnswer4.Location = new System.Drawing.Point(41, 209);
            this.rdbtnAnswer4.Name = "rdbtnAnswer4";
            this.rdbtnAnswer4.Size = new System.Drawing.Size(100, 24);
            this.rdbtnAnswer4.TabIndex = 4;
            this.rdbtnAnswer4.TabStop = true;
            this.rdbtnAnswer4.Text = "Answer 4";
            this.rdbtnAnswer4.UseVisualStyleBackColor = true;
            this.rdbtnAnswer4.CheckedChanged += new System.EventHandler(this.rdbtnAnswer4_CheckedChanged);
            // 
            // btnGiveQ
            // 
            this.btnGiveQ.Location = new System.Drawing.Point(41, 253);
            this.btnGiveQ.Name = "btnGiveQ";
            this.btnGiveQ.Size = new System.Drawing.Size(75, 40);
            this.btnGiveQ.TabIndex = 5;
            this.btnGiveQ.Text = "Hit me";
            this.btnGiveQ.UseVisualStyleBackColor = true;
            this.btnGiveQ.Click += new System.EventHandler(this.btnGiveQ_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Assignment_Q2.Properties.Resources.Covid19;
            this.pictureBox1.Location = new System.Drawing.Point(302, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiveQ);
            this.Controls.Add(this.rdbtnAnswer4);
            this.Controls.Add(this.rdbtnAnswer3);
            this.Controls.Add(this.rdbtnAnswer2);
            this.Controls.Add(this.rdbtnAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Exam";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdbtnAnswer1;
        private System.Windows.Forms.RadioButton rdbtnAnswer2;
        private System.Windows.Forms.RadioButton rdbtnAnswer3;
        private System.Windows.Forms.RadioButton rdbtnAnswer4;
        private System.Windows.Forms.Button btnGiveQ;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}