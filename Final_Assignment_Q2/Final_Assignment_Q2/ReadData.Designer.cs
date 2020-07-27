namespace Final_Assignment_Q2
{
    partial class ReadData
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
            this.lblIdxReadMain = new System.Windows.Forms.Label();
            this.lblTopicReadData = new System.Windows.Forms.Label();
            this.lblContentReadInfo = new System.Windows.Forms.Label();
            this.btnNextInfo = new System.Windows.Forms.Button();
            this.lblIndexTitle = new System.Windows.Forms.Label();
            this.lblTopicHead = new System.Windows.Forms.Label();
            this.lblHeadCOntent = new System.Windows.Forms.Label();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdxReadMain
            // 
            this.lblIdxReadMain.AutoSize = true;
            this.lblIdxReadMain.Location = new System.Drawing.Point(173, 30);
            this.lblIdxReadMain.Name = "lblIdxReadMain";
            this.lblIdxReadMain.Size = new System.Drawing.Size(46, 20);
            this.lblIdxReadMain.TabIndex = 2;
            this.lblIdxReadMain.Text = "index";
            // 
            // lblTopicReadData
            // 
            this.lblTopicReadData.AutoSize = true;
            this.lblTopicReadData.Location = new System.Drawing.Point(173, 69);
            this.lblTopicReadData.Name = "lblTopicReadData";
            this.lblTopicReadData.Size = new System.Drawing.Size(43, 20);
            this.lblTopicReadData.TabIndex = 3;
            this.lblTopicReadData.Text = "topic";
            // 
            // lblContentReadInfo
            // 
            this.lblContentReadInfo.AutoSize = true;
            this.lblContentReadInfo.Location = new System.Drawing.Point(173, 113);
            this.lblContentReadInfo.Name = "lblContentReadInfo";
            this.lblContentReadInfo.Size = new System.Drawing.Size(51, 20);
            this.lblContentReadInfo.TabIndex = 4;
            this.lblContentReadInfo.Text = "label1";
            // 
            // btnNextInfo
            // 
            this.btnNextInfo.Location = new System.Drawing.Point(45, 219);
            this.btnNextInfo.Name = "btnNextInfo";
            this.btnNextInfo.Size = new System.Drawing.Size(75, 36);
            this.btnNextInfo.TabIndex = 5;
            this.btnNextInfo.Text = "Next";
            this.btnNextInfo.UseVisualStyleBackColor = true;
            this.btnNextInfo.Click += new System.EventHandler(this.btnNextInfo_Click);
            // 
            // lblIndexTitle
            // 
            this.lblIndexTitle.AutoSize = true;
            this.lblIndexTitle.Location = new System.Drawing.Point(41, 30);
            this.lblIndexTitle.Name = "lblIndexTitle";
            this.lblIndexTitle.Size = new System.Drawing.Size(52, 20);
            this.lblIndexTitle.TabIndex = 6;
            this.lblIndexTitle.Text = "Index:";
            // 
            // lblTopicHead
            // 
            this.lblTopicHead.AutoSize = true;
            this.lblTopicHead.Location = new System.Drawing.Point(41, 69);
            this.lblTopicHead.Name = "lblTopicHead";
            this.lblTopicHead.Size = new System.Drawing.Size(51, 20);
            this.lblTopicHead.TabIndex = 7;
            this.lblTopicHead.Text = "Topic:";
            // 
            // lblHeadCOntent
            // 
            this.lblHeadCOntent.AutoSize = true;
            this.lblHeadCOntent.Location = new System.Drawing.Point(41, 113);
            this.lblHeadCOntent.Name = "lblHeadCOntent";
            this.lblHeadCOntent.Size = new System.Drawing.Size(70, 20);
            this.lblHeadCOntent.TabIndex = 8;
            this.lblHeadCOntent.Text = "Content:";
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Location = new System.Drawing.Point(148, 219);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(211, 36);
            this.btnBackMenu.TabIndex = 9;
            this.btnBackMenu.Text = "Back to Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Assignment_Q2.Properties.Resources.Covid191;
            this.pictureBox1.Location = new System.Drawing.Point(32, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ReadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.lblHeadCOntent);
            this.Controls.Add(this.lblTopicHead);
            this.Controls.Add(this.lblIndexTitle);
            this.Controls.Add(this.btnNextInfo);
            this.Controls.Add(this.lblContentReadInfo);
            this.Controls.Add(this.lblTopicReadData);
            this.Controls.Add(this.lblIdxReadMain);
            this.Name = "ReadData";
            this.Text = "lstbxReadData";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdxReadMain;
        private System.Windows.Forms.Label lblTopicReadData;
        private System.Windows.Forms.Label lblContentReadInfo;
        private System.Windows.Forms.Button btnNextInfo;
        private System.Windows.Forms.Label lblIndexTitle;
        private System.Windows.Forms.Label lblTopicHead;
        private System.Windows.Forms.Label lblHeadCOntent;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}