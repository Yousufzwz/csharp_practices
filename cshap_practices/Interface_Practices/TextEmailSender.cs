using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practices
{
    internal class TextEmailSender : IWelcomeEmailSender
    {
        public void SendEmail(string email, string subject, string body)
        {

        }

        public void SendWelcomeEmail(string email)
        {
            SendEmail(email, "Hi", "Welcome here.");
        }
    }
}
