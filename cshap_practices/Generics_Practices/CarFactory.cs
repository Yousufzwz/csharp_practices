using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practices;

internal class CarFactory<T> where T : ICar
{
    private T nCar;

    public T CopyCar { get;  }

    public CarFactory(T car)
    {
        nCar = car;
    }

    public bool CheckCar()
    {
        try
        {
            nCar.Start();
            nCar.Accelerate();
            nCar.Stop();
            return true;
        }
        catch { return false; }
    }

}
