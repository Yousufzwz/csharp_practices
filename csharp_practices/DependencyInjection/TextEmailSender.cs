namespace DependencyInjection;

public class TextEmailSender : IWelcomeEmailSender
{
    public void Send(string email, string subject, string body)
    {

    }


    public void SendWelcomeEmail(string email)
    {
        Send(email, "Hi", "New email for you");
    }
}