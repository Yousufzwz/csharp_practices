using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practices;

internal class Coordinates<A, B>
{
    internal A X { get; set; }
    internal B Y { get; set; }
   
    
    public void Add<S>(S add)
    {
        A x = X;
        B y = Y;
        S a;
    }

    public void Remove(A remover)
    {

    }


}


