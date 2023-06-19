using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practices
{
    internal class HTMLEmailSender : IWelcomeEmailSender
    {
        public void Send(string email, string subject, string body)
        {

        }
        public void SendWelcomeEmail(string email)
        {
            Send(email, "Hi there!", "Welcome");
        }
    }
}
