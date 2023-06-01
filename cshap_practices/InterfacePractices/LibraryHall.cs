using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractices
{
    public abstract class LibraryHall : ILibrary
    {
        public abstract string PersonID { get; }

        public string PersonInfo(string name, string age)
        {
            throw new NotImplementedException();
        }
        //LibraryHall owns it (main)
        public abstract string Credentials(string name, string id);
    }
}
