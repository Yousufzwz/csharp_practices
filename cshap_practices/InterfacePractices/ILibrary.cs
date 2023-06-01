using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractices
{ 
    internal interface ILibrary
    {

        public string PersonID { get; }
        public string PersonInfo(string name, string age);
    }
}
