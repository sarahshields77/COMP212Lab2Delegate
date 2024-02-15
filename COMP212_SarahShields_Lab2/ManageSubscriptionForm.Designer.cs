namespace COMP212_SarahShields_Lab2
{
    partial class ManageSubscriptionForm
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
            this.notificationEmailCheckbox = new System.Windows.Forms.CheckBox();
            this.notificationSMSCheckBox = new System.Windows.Forms.CheckBox();
            this.emailInputTextBox = new System.Windows.Forms.TextBox();
            this.smsInputTextBox = new System.Windows.Forms.TextBox();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notificationEmailCheckbox
            // 
            this.notificationEmailCheckbox.AutoSize = true;
            this.notificationEmailCheckbox.Location = new System.Drawing.Point(27, 46);
            this.notificationEmailCheckbox.Name = "notificationEmailCheckbox";
            this.notificationEmailCheckbox.Size = new System.Drawing.Size(146, 17);
            this.notificationEmailCheckbox.TabIndex = 0;
            this.notificationEmailCheckbox.Text = "Notification Sent by Email";
            this.notificationEmailCheckbox.UseVisualStyleBackColor = true;
            // 
            // notificationSMSCheckBox
            // 
            this.notificationSMSCheckBox.AutoSize = true;
            this.notificationSMSCheckBox.Location = new System.Drawing.Point(27, 97);
            this.notificationSMSCheckBox.Name = "notificationSMSCheckBox";
            this.notificationSMSCheckBox.Size = new System.Drawing.Size(144, 17);
            this.notificationSMSCheckBox.TabIndex = 1;
            this.notificationSMSCheckBox.Text = "Notification Sent by SMS";
            this.notificationSMSCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailInputTextBox
            // 
            this.emailInputTextBox.Location = new System.Drawing.Point(179, 43);
            this.emailInputTextBox.Name = "emailInputTextBox";
            this.emailInputTextBox.Size = new System.Drawing.Size(178, 20);
            this.emailInputTextBox.TabIndex = 2;
            // 
            // smsInputTextBox
            // 
            this.smsInputTextBox.Location = new System.Drawing.Point(179, 94);
            this.smsInputTextBox.Name = "smsInputTextBox";
            this.smsInputTextBox.Size = new System.Drawing.Size(178, 20);
            this.smsInputTextBox.TabIndex = 3;
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(36, 138);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(77, 30);
            this.subscribeButton.TabIndex = 4;
            this.subscribeButton.Text = "Subscribe";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Location = new System.Drawing.Point(135, 138);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(81, 30);
            this.unsubscribeButton.TabIndex = 5;
            this.unsubscribeButton.Text = "Unsubscribe";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.unsubscribeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(249, 138);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 30);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 191);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.unsubscribeButton);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.smsInputTextBox);
            this.Controls.Add(this.emailInputTextBox);
            this.Controls.Add(this.notificationSMSCheckBox);
            this.Controls.Add(this.notificationEmailCheckbox);
            this.Name = "ManageSubscriptionForm";
            this.Text = "Manage Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox notificationEmailCheckbox;
        private System.Windows.Forms.CheckBox notificationSMSCheckBox;
        private System.Windows.Forms.TextBox emailInputTextBox;
        private System.Windows.Forms.TextBox smsInputTextBox;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}