using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_SarahShields_Lab2
{
    public partial class ManageSubscriptionForm : Form
    {
        public NotificationHandler handler;
        public ManageSubscriptionForm(NotificationHandler handler)
        {
            InitializeComponent();
            this.handler = handler;
        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            string email = emailInputTextBox.Text; 
            string cellPhone = smsInputTextBox.Text; 

            // check if both email and phone number are empty
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(cellPhone))
            {
                MessageBox.Show("Please enter either an email address or a phone number.");
                return;
            }
            // validate email
            if (!IsValidEmail(email) && !string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Invalid email address.");
                return;
            }
            // validate phone number
            if (!IsValidPhoneNumber(cellPhone) && !string.IsNullOrEmpty(cellPhone))
            {
                MessageBox.Show("Invalid phone number.");
                return;
            }
            // if one of the inputs is valid, proceed with subscription
            Subscriber newSubscriber = new Subscriber(email, cellPhone);

            if (handler.Subscribe(newSubscriber))
            {
                // enable Publish button if there are subscribers
                Form1 parentForm = this.Owner as Form1;
                if (parentForm != null)
                {
                    parentForm.EnablePublishButton(handler.emailSubscribersList.Count > 0 || handler.smsSubscribersList.Count > 0);
                }
            }
            else
            {
                MessageBox.Show("Subscription failed. Please check your details and try again.");
            }
            this.Close();
        }
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }
        private bool IsValidPhoneNumber(string cellPhone)
        {   
            string phoneNumberPattern = @"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$";

            if (string.IsNullOrEmpty(cellPhone))
                return false;

            cellPhone = cellPhone.Trim(); 

            Regex regex = new Regex(phoneNumberPattern);
            return regex.IsMatch(cellPhone); 
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void unsubscribeButton_Click(object sender, EventArgs e)
        {
            string email = emailInputTextBox.Text;
            string cellPhone = smsInputTextBox.Text;

            if (!IsValidEmail(email) && !IsValidPhoneNumber(cellPhone))
            {
                MessageBox.Show("Invalid email address and cell phone number.");
                return;
            }

            Subscriber subscriberToRemove;
            if (IsValidEmail(email))
            {
                subscriberToRemove = new Subscriber(email);
            }
            else
            {
                subscriberToRemove = new Subscriber(cellPhone);
            }

            handler.Unsubscribe(subscriberToRemove);
        }
    }
}
