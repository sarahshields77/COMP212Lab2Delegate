using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_SarahShields_Lab2
{
    public partial class PublishNotificationForm : Form
    {
        private NotificationHandler handler;
        public PublishNotificationForm(NotificationHandler handler)
        {
            InitializeComponent();
            this.handler = handler;
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            string notificationContent = notificationContentTextBox.Text;

            Form1 parentForm = (Form1)this.Owner;
            NotificationHandler handler = parentForm.handler;

            handler.PublishNotification(notificationContent);

            notificationContentTextBox.Text = "";
            this.Close();
        }

        private void publishExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
