using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection;

public class HTMLEmailSender : IWelcomeEmailSender
{
    public void SendEmail(string email, string subject, string body)
    {

    }

    public void Send(string email, string subject, string body)
    {
        SendEmail(email, subject, body);
    }


    public void SendWelcomeEmail(string email)
    {
        SendEmail(email, "Hi", "New email for you");
    }
}
