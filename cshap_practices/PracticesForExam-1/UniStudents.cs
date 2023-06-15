using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesForExam_1
{
    internal class UniStudents:University
    {
        public UniStudents() { }
        
        public string Name { get; set; }
        public string ID { get; set; }

        public UniStudents(string name, string id)
        {
            Name = name;
            ID = id;
        }
    }
}
