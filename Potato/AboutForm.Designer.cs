namespace Potato
{
    partial class AboutForm
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
            this.llOriginalTwitterPost = new System.Windows.Forms.LinkLabel();
            this.llSourceImage = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llOriginalTwitterPost
            // 
            this.llOriginalTwitterPost.AutoSize = true;
            this.llOriginalTwitterPost.Location = new System.Drawing.Point(12, 9);
            this.llOriginalTwitterPost.Name = "llOriginalTwitterPost";
            this.llOriginalTwitterPost.Size = new System.Drawing.Size(101, 13);
            this.llOriginalTwitterPost.TabIndex = 1;
            this.llOriginalTwitterPost.TabStop = true;
            this.llOriginalTwitterPost.Text = "Original Twitter Post";
            this.llOriginalTwitterPost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOriginalTwitterPost_LinkClicked);
            // 
            // llSourceImage
            // 
            this.llSourceImage.AutoSize = true;
            this.llSourceImage.Location = new System.Drawing.Point(119, 9);
            this.llSourceImage.Name = "llSourceImage";
            this.llSourceImage.Size = new System.Drawing.Size(73, 13);
            this.llSourceImage.TabIndex = 2;
            this.llSourceImage.TabStop = true;
            this.llSourceImage.Text = "Source Image";
            this.llSourceImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSourceImage_LinkClicked_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shamelessly stolen from an image posted on Twitter by Oliver Darkshire (@deathbyb" +
    "adger). Source tweet and image linked above.";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 75);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llSourceImage);
            this.Controls.Add(this.llOriginalTwitterPost);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llOriginalTwitterPost;
        private System.Windows.Forms.LinkLabel llSourceImage;
        private System.Windows.Forms.Label label1;
    }
}