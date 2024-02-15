using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace COMP212_SarahShields_Lab2
{
    public delegate void NotificationDelivery(string message); // delegate that takes a string message as input
    public class NotificationHandler   // this class holds the delegate instance and is responsible for sending notifications
    {
        public List<Subscriber> emailSubscribersList;
        public List<Subscriber> smsSubscribersList;
        private NotificationDelivery notificationDelivery;

        public NotificationHandler(NotificationDelivery notificationDelivery)   // constructor takes the delegate as argument 
        {                                                                       // and initializes the fields
            this.emailSubscribersList = new List<Subscriber>();
            this.smsSubscribersList = new List<Subscriber>();
            this.notificationDelivery = notificationDelivery;
        }
        public bool Subscribe(Subscriber subscriber)
        {
            // check if the email or phone number already exists
            if ((subscriber.Email != null && emailSubscribersList.Any(sub => sub.Email == subscriber.Email)) ||
                (subscriber.CellPhone != null && smsSubscribersList.Any(sub => sub.CellPhone == subscriber.CellPhone)))
            {
                MessageBox.Show("There is already a subscription on file for this client.");
                return false;
            }

            // subscribe the user
            if (!emailSubscribersList.Contains(subscriber) && !smsSubscribersList.Contains(subscriber))
            {
                if (IsValidEmail(subscriber.Email))
                {
                    emailSubscribersList.Add(subscriber);
                    if (notificationDelivery != null)
                    {
                        notificationDelivery("Email subscription successful for " + subscriber.Email);
                    }
                }
                else if (IsValidPhoneNumber(subscriber.CellPhone) && notificationDelivery != null)
                {
                    smsSubscribersList.Add(subscriber);
                    notificationDelivery("SMS subscription successful for " + subscriber.CellPhone);
                }
                else
                {
                    // handle case where neither email nor phone number is valid
                    MessageBox.Show("Please enter a valid email address or phone number.");
                    return false;
                }

                // enable Publish button if there are subscribers
                if (emailSubscribersList.Count > 0 || smsSubscribersList.Count > 0)
                {
                    OnSubscribersChanged();
                }

                return true; 
            }
            else
            {
                MessageBox.Show("There is already a subscription on file for this client.");
                return false;
            }
        }
        public void Unsubscribe(Subscriber subscriber)
        {
            if (emailSubscribersList.Contains(subscriber))
                emailSubscribersList.Remove(subscriber);
            if (smsSubscribersList.Contains(subscriber))
                smsSubscribersList.Remove(subscriber);

            // notification message
            if (notificationDelivery != null)
                notificationDelivery("Unsubscribed successfully");

            // enable Publish button if there are subscribers
            if (emailSubscribersList.Count == 0 && smsSubscribersList.Count == 0)
                OnSubscribersChanged();
        }
        public void PublishNotification(string message)
        {
            foreach (Subscriber subscriber in emailSubscribersList)
            {
                // logic to send email notification using subscriber.Email and message
                // i.e. SendEmail(subscriber.Email, message);
            }
            foreach (Subscriber subscriber in smsSubscribersList)
            {
                // logic to send SMS notification using subscriber.CellPhone and message
                // i.e. SendSMS(subscriber.CellPhone, message);
            }
            if (notificationDelivery != null)
            {
                notificationDelivery("Notification sent to " + (emailSubscribersList.Count + smsSubscribersList.Count) + " subscribers");
            }
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
        // notify when subscribers are changed
        private void OnSubscribersChanged()
        {
            Form1 parentForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (parentForm != null)
                parentForm.EnablePublishButton(emailSubscribersList.Count > 0 || smsSubscribersList.Count > 0);
        }

    }
}
