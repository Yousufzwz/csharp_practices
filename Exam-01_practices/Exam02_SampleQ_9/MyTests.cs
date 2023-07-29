using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_SampleQ_9;

internal class MyTests<Type1, Type2>
{
    private (Type1, Type2) sampleTuple;

    public MyTests(Type1 name, Type2 age)
    {
        sampleTuple=(name, age);
    }

    public void PrintTuple()
    {
        Console.WriteLine(sampleTuple.Item1);
        Console.WriteLine(sampleTuple.Item2);

    }

    //public abstract int CheckID<K, Z>(K a, Z p);


}

