using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_SampleQ_9;

internal class MyTests<T1, T2>
{
    private (T1, T2) sampleTuple;

    public MyTests(T1 name, T2 age)
    {
        sampleTuple=(name, age);
    }

    public void PrintTuple()
    {
        Console.WriteLine(sampleTuple.Item1);
        Console.WriteLine(sampleTuple.Item2);

    }
}
