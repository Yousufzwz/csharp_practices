using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCompletion.io;

namespace Exam_01_Practices
{
    internal class Shirt:Product
    {
        private   string Name { get; set; }
        private string Barcode { get; set; }

        internal Shirt(string name, string barcode)
        {
            Name = name;
            Barcode = barcode;
        }


    }
}
