using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IWelcomeEmailSender : IEmailSender
    {
        void SendWelcomeEmail(string email);
    }
}
