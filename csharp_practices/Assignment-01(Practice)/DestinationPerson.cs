using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Practice_;

public class DestinationPerson
{
    public string FullName { get; set; }
    public int CurrentAge { get; set; }
    public Address CurrentAddress { get; set; }
    public List<PhoneNumber> ContactNumbers { get; set; }
}