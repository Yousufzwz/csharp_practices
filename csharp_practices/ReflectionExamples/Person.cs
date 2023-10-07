using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples;

public class Person : ICloneable
{
    private int Id { get; set; }    
    private string Name { get; set; }

    public void Walk(int speed)
    {
        Console.WriteLine("Walking");
    }

    private void Talk(string message)
    {
        Console.WriteLine(message);
    }

    public object Clone()
    {
        return new Person { Id =Id, Name=Name};
    }
}
