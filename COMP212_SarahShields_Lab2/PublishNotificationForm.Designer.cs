namespace COMP212_SarahShields_Lab2
{
    partial class PublishNotificationForm
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
            this.notificationContentTextBox = new System.Windows.Forms.TextBox();
            this.notificationContentLabel = new System.Windows.Forms.Label();
            this.publishButton = new System.Windows.Forms.Button();
            this.publishExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notificationContentTextBox
            // 
            this.notificationContentTextBox.Location = new System.Drawing.Point(163, 43);
            this.notificationContentTextBox.Name = "notificationContentTextBox";
            this.notificationContentTextBox.Size = new System.Drawing.Size(204, 20);
            this.notificationContentTextBox.TabIndex = 0;
            // 
            // notificationContentLabel
            // 
            this.notificationContentLabel.AutoSize = true;
            this.notificationContentLabel.Location = new System.Drawing.Point(35, 46);
            this.notificationContentLabel.Name = "notificationContentLabel";
            this.notificationContentLabel.Size = new System.Drawing.Size(100, 13);
            this.notificationContentLabel.TabIndex = 1;
            this.notificationContentLabel.Text = "Notification Content";
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(65, 102);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(95, 34);
            this.publishButton.TabIndex = 2;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // publishExitButton
            // 
            this.publishExitButton.Location = new System.Drawing.Point(243, 102);
            this.publishExitButton.Name = "publishExitButton";
            this.publishExitButton.Size = new System.Drawing.Size(90, 34);
            this.publishExitButton.TabIndex = 3;
            this.publishExitButton.Text = "Exit";
            this.publishExitButton.UseVisualStyleBackColor = true;
            this.publishExitButton.Click += new System.EventHandler(this.publishExitButton_Click);
            // 
            // PublishNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 174);
            this.Controls.Add(this.publishExitButton);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.notificationContentLabel);
            this.Controls.Add(this.notificationContentTextBox);
            this.Name = "PublishNotificationForm";
            this.Text = "Publish Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notificationContentTextBox;
        private System.Windows.Forms.Label notificationContentLabel;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Button publishExitButton;
    }
}