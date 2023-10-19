using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Practice_;

public class PropertyMapping
{
    public PropertyInfo DestProperty { get; }
    public PropertyInfo SourceProperty { get; }

    public PropertyMapping(PropertyInfo destProperty, PropertyInfo sourceProperty)
    {
        DestProperty = destProperty;
        SourceProperty = sourceProperty;
    }
}