namespace Final_Assignment_Q2
{
    partial class Main
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
            this.btnMainPushExam = new System.Windows.Forms.Button();
            this.btnMainPushData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.picbxMain = new System.Windows.Forms.PictureBox();
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainPushExam
            // 
            this.btnMainPushExam.Location = new System.Drawing.Point(251, 39);
            this.btnMainPushExam.Name = "btnMainPushExam";
            this.btnMainPushExam.Size = new System.Drawing.Size(152, 86);
            this.btnMainPushExam.TabIndex = 0;
            this.btnMainPushExam.Text = "Push To Exam";
            this.btnMainPushExam.UseVisualStyleBackColor = true;
            this.btnMainPushExam.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMainPushData
            // 
            this.btnMainPushData.Location = new System.Drawing.Point(54, 39);
            this.btnMainPushData.Name = "btnMainPushData";
            this.btnMainPushData.Size = new System.Drawing.Size(161, 86);
            this.btnMainPushData.TabIndex = 1;
            this.btnMainPushData.Text = "Push To Read";
            this.btnMainPushData.UseVisualStyleBackColor = true;
            this.btnMainPushData.Click += new System.EventHandler(this.btnMainPushData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(54, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 86);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(251, 162);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(152, 86);
            this.btnUpdateData.TabIndex = 5;
            this.btnUpdateData.Text = "Update Data";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // picbxMain
            // 
            this.picbxMain.Image = global::Final_Assignment_Q2.Properties.Resources.Covid19;
            this.picbxMain.Location = new System.Drawing.Point(523, 39);
            this.picbxMain.Name = "picbxMain";
            this.picbxMain.Size = new System.Drawing.Size(227, 209);
            this.picbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxMain.TabIndex = 6;
            this.picbxMain.TabStop = false;
            this.picbxMain.Click += new System.EventHandler(this.picbxMain_Click);
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.Location = new System.Drawing.Point(54, 162);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(161, 86);
            this.btnUpdateQuestion.TabIndex = 7;
            this.btnUpdateQuestion.Text = "Update Question";
            this.btnUpdateQuestion.UseVisualStyleBackColor = true;
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateQuestion);
            this.Controls.Add(this.picbxMain);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMainPushData);
            this.Controls.Add(this.btnMainPushExam);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainPushExam;
        private System.Windows.Forms.Button btnMainPushData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.PictureBox picbxMain;
        private System.Windows.Forms.Button btnUpdateQuestion;
    }
}