using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier;

internal class TestClass
{
    public int Add(string id, params int[] nums)
    {
        var sum = 0;
        foreach (var i in nums)
        {
            sum += i;
        }
        return sum;
    }
}
