using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01_Practices;

internal static class Counter
{
    private static int counter = 0;

    public static void GetCounter() 
    { 
        counter++;
    }
    
    public static string Adder()
    {
        GetCounter();
        throw new NotImplementedException();
    }

    static Counter()
    {

    }
}
