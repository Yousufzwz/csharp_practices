using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practices
{
    public partial class Person
    {
        public string Address { get; set; }

        public void Walk()
        {
            Console.WriteLine("Walking");
        }
    }
}
