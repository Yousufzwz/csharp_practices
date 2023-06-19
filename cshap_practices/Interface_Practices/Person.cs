using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practices
{
    public partial class Person
    {
        public string Name { get; set; }    

        public void Talk(string text)
        {
            Console.WriteLine(text);
        }
    }
}
