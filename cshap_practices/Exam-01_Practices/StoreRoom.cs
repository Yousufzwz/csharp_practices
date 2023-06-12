using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCompletion.io;

namespace Exam_01_Practices
{
    internal class StoreRoom
    {   
        public int counter;

        public StoreRoom(Product product)
        {
            counter++;
        }
        public void Count(Product anotherProduct)
        {
            counter++;
        }
    }
}
