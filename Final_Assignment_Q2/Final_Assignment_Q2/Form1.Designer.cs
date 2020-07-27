namespace Final_Assignment_Q2
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
            this.btnEnterSend = new System.Windows.Forms.Button();
            this.txtbxEnterPutName = new System.Windows.Forms.TextBox();
            this.lblEnterHead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterSend
            // 
            this.btnEnterSend.Location = new System.Drawing.Point(289, 259);
            this.btnEnterSend.Name = "btnEnterSend";
            this.btnEnterSend.Size = new System.Drawing.Size(187, 73);
            this.btnEnterSend.TabIndex = 0;
            this.btnEnterSend.Text = "Send and Start";
            this.btnEnterSend.UseVisualStyleBackColor = true;
            this.btnEnterSend.Click += new System.EventHandler(this.btnEnterSend_Click);
            // 
            // txtbxEnterPutName
            // 
            this.txtbxEnterPutName.Location = new System.Drawing.Point(289, 175);
            this.txtbxEnterPutName.Name = "txtbxEnterPutName";
            this.txtbxEnterPutName.Size = new System.Drawing.Size(187, 26);
            this.txtbxEnterPutName.TabIndex = 1;
            // 
            // lblEnterHead
            // 
            this.lblEnterHead.AutoSize = true;
            this.lblEnterHead.Location = new System.Drawing.Point(320, 108);
            this.lblEnterHead.Name = "lblEnterHead";
            this.lblEnterHead.Size = new System.Drawing.Size(117, 20);
            this.lblEnterHead.TabIndex = 2;
            this.lblEnterHead.Text = "Put Your Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Assignment_Q2.Properties.Resources.Covid19;
            this.pictureBox1.Location = new System.Drawing.Point(37, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Assignment_Q2.Properties.Resources.Covid19;
            this.pictureBox2.Location = new System.Drawing.Point(565, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEnterHead);
            this.Controls.Add(this.txtbxEnterPutName);
            this.Controls.Add(this.btnEnterSend);
            this.Name = "Form1";
            this.Text = "Enter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterSend;
        private System.Windows.Forms.TextBox txtbxEnterPutName;
        private System.Windows.Forms.Label lblEnterHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

