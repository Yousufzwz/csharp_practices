using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesForExam_1
{
    internal class UniTeachers:University
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public UniTeachers(string name, string id)
        {
            Name = name;
            ID = id;
        }
    }
}
