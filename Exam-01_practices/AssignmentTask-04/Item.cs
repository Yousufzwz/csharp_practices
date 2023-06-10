using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask_04
{
    internal abstract class Item
    {
        protected double Price { get; set; }    
        protected abstract double GetDiscount(double originalPrice);

        protected Item(double price) 
        { 
        }
    }
}
