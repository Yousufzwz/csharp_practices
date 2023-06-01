using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractices
{
    public class LibraryStaff : LibraryHall
    {
        public override string PersonID
        {
            get
            {
                return "LS-09A";
            }
        }

        //LibraryHall owns it
        public override string Credentials(string name, string id)
        {
            throw new NotImplementedException();
        }
    }
}
