using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practices
{
    internal class Membership
    {
        private readonly IWelcomeEmailSender _emailsender;
        public Membership(IWelcomeEmailSender emailSender)
        {
            _emailsender = emailSender;
        } 
        public void Signup(string email, string password)
        {
            
        }

        private void CreateUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
