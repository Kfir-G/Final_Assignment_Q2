namespace Final_Assignment_Q2
{
    partial class UpdateData
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
            this.txtbxContent = new System.Windows.Forms.TextBox();
            this.lblHeadContent = new System.Windows.Forms.Label();
            this.lblHeadTopic = new System.Windows.Forms.Label();
            this.txtbxTopic = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxContent
            // 
            this.txtbxContent.Location = new System.Drawing.Point(44, 193);
            this.txtbxContent.Multiline = true;
            this.txtbxContent.Name = "txtbxContent";
            this.txtbxContent.Size = new System.Drawing.Size(225, 147);
            this.txtbxContent.TabIndex = 0;
            // 
            // lblHeadContent
            // 
            this.lblHeadContent.AutoSize = true;
            this.lblHeadContent.Location = new System.Drawing.Point(44, 152);
            this.lblHeadContent.Name = "lblHeadContent";
            this.lblHeadContent.Size = new System.Drawing.Size(125, 20);
            this.lblHeadContent.TabIndex = 1;
            this.lblHeadContent.Text = "Put your content";
            // 
            // lblHeadTopic
            // 
            this.lblHeadTopic.AutoSize = true;
            this.lblHeadTopic.Location = new System.Drawing.Point(44, 31);
            this.lblHeadTopic.Name = "lblHeadTopic";
            this.lblHeadTopic.Size = new System.Drawing.Size(98, 20);
            this.lblHeadTopic.TabIndex = 2;
            this.lblHeadTopic.Text = "Put the topic";
            // 
            // txtbxTopic
            // 
            this.txtbxTopic.Location = new System.Drawing.Point(48, 72);
            this.txtbxTopic.Multiline = true;
            this.txtbxTopic.Name = "txtbxTopic";
            this.txtbxTopic.Size = new System.Drawing.Size(221, 53);
            this.txtbxTopic.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(44, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 49);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Assignment_Q2.Properties.Resources.Covid19;
            this.pictureBox1.Location = new System.Drawing.Point(394, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtbxTopic);
            this.Controls.Add(this.lblHeadTopic);
            this.Controls.Add(this.lblHeadContent);
            this.Controls.Add(this.txtbxContent);
            this.Name = "UpdateData";
            this.Text = "UpdateData";
            this.Load += new System.EventHandler(this.UpdateData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxContent;
        private System.Windows.Forms.Label lblHeadContent;
        private System.Windows.Forms.Label lblHeadTopic;
        private System.Windows.Forms.TextBox txtbxTopic;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}