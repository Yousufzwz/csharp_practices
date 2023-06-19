using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practices
{
    public interface IWelcomeEmailSender
    {
        void SendWelcomeEmail(string email);
    }
}
