namespace Final_Assignment_Q2
{
    partial class UpdateQuestion
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
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            this.txtbxCorrecrAnswer = new System.Windows.Forms.TextBox();
            this.txtbxQuestion = new System.Windows.Forms.TextBox();
            this.txtbxIncorrectAnswer = new System.Windows.Forms.TextBox();
            this.lblHeadQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.Location = new System.Drawing.Point(228, 350);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(162, 57);
            this.btnUpdateQuestion.TabIndex = 0;
            this.btnUpdateQuestion.Text = "Update";
            this.btnUpdateQuestion.UseVisualStyleBackColor = true;
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // txtbxCorrecrAnswer
            // 
            this.txtbxCorrecrAnswer.Location = new System.Drawing.Point(36, 169);
            this.txtbxCorrecrAnswer.Multiline = true;
            this.txtbxCorrecrAnswer.Name = "txtbxCorrecrAnswer";
            this.txtbxCorrecrAnswer.Size = new System.Drawing.Size(227, 134);
            this.txtbxCorrecrAnswer.TabIndex = 1;
            // 
            // txtbxQuestion
            // 
            this.txtbxQuestion.Location = new System.Drawing.Point(228, 78);
            this.txtbxQuestion.Multiline = true;
            this.txtbxQuestion.Name = "txtbxQuestion";
            this.txtbxQuestion.Size = new System.Drawing.Size(162, 65);
            this.txtbxQuestion.TabIndex = 2;
            // 
            // txtbxIncorrectAnswer
            // 
            this.txtbxIncorrectAnswer.Location = new System.Drawing.Point(365, 169);
            this.txtbxIncorrectAnswer.Multiline = true;
            this.txtbxIncorrectAnswer.Name = "txtbxIncorrectAnswer";
            this.txtbxIncorrectAnswer.Size = new System.Drawing.Size(227, 134);
            this.txtbxIncorrectAnswer.TabIndex = 3;
            // 
            // lblHeadQuestion
            // 
            this.lblHeadQuestion.AutoSize = true;
            this.lblHeadQuestion.Location = new System.Drawing.Point(243, 46);
            this.lblHeadQuestion.Name = "lblHeadQuestion";
            this.lblHeadQuestion.Size = new System.Drawing.Size(132, 20);
            this.lblHeadQuestion.TabIndex = 4;
            this.lblHeadQuestion.Text = "Put your question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Put the correct answer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Put the incorrecr answer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Assignment_Q2.Properties.Resources.Covid19;
            this.pictureBox1.Location = new System.Drawing.Point(604, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeadQuestion);
            this.Controls.Add(this.txtbxIncorrectAnswer);
            this.Controls.Add(this.txtbxQuestion);
            this.Controls.Add(this.txtbxCorrecrAnswer);
            this.Controls.Add(this.btnUpdateQuestion);
            this.Name = "UpdateQuestion";
            this.Text = "UpdateQuestion";
            this.Load += new System.EventHandler(this.UpdateQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateQuestion;
        private System.Windows.Forms.TextBox txtbxCorrecrAnswer;
        private System.Windows.Forms.TextBox txtbxQuestion;
        private System.Windows.Forms.TextBox txtbxIncorrectAnswer;
        private System.Windows.Forms.Label lblHeadQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}