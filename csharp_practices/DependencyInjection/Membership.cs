using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection;

public class Membership
{
    private readonly IWelcomeEmailSender _welcomeEmailSender;
    public Membership(IWelcomeEmailSender emailSender)
    {
        _welcomeEmailSender = emailSender;
    }
    public void SignUp(string email, string password)
    {
        CreateUser(email, password);

        _welcomeEmailSender.SendWelcomeEmail(email);
    }

    private void CreateUser(string email, string password)
    {
        throw new NotImplementedException();    
    }
}
