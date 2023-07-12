using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure;

public struct Student:IClassLeader
{
    private readonly int id;
    public string Name { get; set; }
    public void Write(string writing)
    {
        Console.WriteLine(writing);
    }
    public Student(string name)
    {
        name = name;
    }
}
