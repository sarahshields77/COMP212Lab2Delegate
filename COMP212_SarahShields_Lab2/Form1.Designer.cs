namespace COMP212_SarahShields_Lab2
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
            this.manageButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageButton
            // 
            this.manageButton.Location = new System.Drawing.Point(12, 24);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(118, 29);
            this.manageButton.TabIndex = 0;
            this.manageButton.Text = "Manage Subscription";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // publishButton
            // 
            this.publishButton.Enabled = false;
            this.publishButton.Location = new System.Drawing.Point(136, 24);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(114, 29);
            this.publishButton.TabIndex = 1;
            this.publishButton.Text = "Publish Notification";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(269, 24);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 41);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 90);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.manageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Button exitButton;
    }
}

