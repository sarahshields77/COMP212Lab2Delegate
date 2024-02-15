using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_SarahShields_Lab2
{
    public partial class Form1 : Form
    {
        public NotificationHandler handler; 
        public Button PublishButton { get; private set; } // expose a property
        public Form1()
        {
            InitializeComponent();
            handler = new NotificationHandler(NotificationDeliveryMethod); // create instance
            PublishButton = publishButton; // assign the actual button reference
            EnablePublishButton(false); // Initially disable the publish button
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            ManageSubscriptionForm form = new ManageSubscriptionForm(handler); 
            form.Show();
        }
        private void NotificationDeliveryMethod(string message)
        {
            // notification delivery logic
            MessageBox.Show(message);
        }
        public void EnablePublishButton(bool enable)
        {
            publishButton.Enabled = enable;
        }
        private void publishButton_Click(object sender, EventArgs e)
        {
            //  notification publishing logic
            PublishNotificationForm form = new PublishNotificationForm(handler);
            form.Owner = this; // set Form1 as owner of PublishNotificationForm
            form.Show();           
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
