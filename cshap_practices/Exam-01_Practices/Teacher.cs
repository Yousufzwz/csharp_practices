using Library.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01_Practices;

internal class Teacher:LibraryMember
{
    private string Name { get; set; }
    private int ID { get; set; }

    internal Teacher(string name, int id)
    {
        Name = name;
        ID = id;
    }

    

}
