using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01_Practices;

internal abstract class Vehicle
{
    public readonly string name;

    public const string fixedValue= "97809707";

     ~ Vehicle()
    {
        
    }
    public Vehicle()
    {
        name = "BMW";
    }

    public abstract void Start();
    public abstract void Stop();

}
