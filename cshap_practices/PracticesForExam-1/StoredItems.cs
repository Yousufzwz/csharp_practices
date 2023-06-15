using OnlineOrder.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesForExam_1;

internal class StoredItems
{
    public int counter;
    public int TotalCount;
    public StoredItems(Garments product)
    {
        TotalCount++;
    }
    public void Count(Garments anotherProduct)
    {
        counter++;

    }
}
