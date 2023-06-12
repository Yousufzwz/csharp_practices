using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01_Practices;

internal class Car : Vehicle
{
    private BMW bmw;

  
    public Car()
    {
        bmw = new BMW();
    }

    public override void Start()
    { 
        Console.WriteLine("Starting Car");
        bmw.Model();
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping Car");
    }

    
}
