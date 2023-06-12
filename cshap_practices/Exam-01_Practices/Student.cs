using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.cs;

namespace Exam_01_Practices;

internal class Student : LibraryMember
{
    private string Name { get; set; }
    private int ID { get; set; }

   internal Student(string name, int id) : base()
    {
        Name = name;
        ID = id;
    }
    internal Student() { }
}
