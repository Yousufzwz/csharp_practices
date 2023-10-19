//////using System;
//////using System.Collections.Generic;
//////using System.Reflection;

//////namespace Assignment_01_Practice_;

//////public class SimpleMapper
//////{
//////    private List<PropertyMapping> propertyMappings;

//////    public SimpleMapper()
//////    {
//////        propertyMappings = new List<PropertyMapping>();
//////    }

//////    public void Copy(object source, object destination)
//////    {
//////        Type sourceType = source.GetType();
//////        Type destType = destination.GetType();

//////        // Build a list of property mappings
//////        foreach (var destProperty in destType.GetProperties())
//////        {
//////            PropertyInfo sourceProperty = sourceType.GetProperty(destProperty.Name);
//////            if (sourceProperty != null && sourceProperty.PropertyType == destProperty.PropertyType)
//////            {
//////                propertyMappings.Add(new PropertyMapping(destProperty, sourceProperty));
//////            }
//////        }

//////        // Copy values using the property mappings
//////        foreach (var mapping in propertyMappings)
//////        {
//////            object value = mapping.SourceProperty.GetValue(source);
//////            mapping.DestProperty.SetValue(destination, value);
//////        }
//////    }
//////}

//////==================


////using System;
////using System.Collections;
////using System.Linq;
////using System.Reflection;

////public class SimpleMapper
////{
////    public void Copy(object source, object destination)
////    {
////        CopyProperties(source, destination);
////    }

////    private void CopyProperties(object source, object destination)
////    {
////        Type sourceType = source.GetType();
////        Type destType = destination.GetType();

////        PropertyInfo[] sourceProperties = sourceType.GetProperties();
////        PropertyInfo[] destProperties = destType.GetProperties();

////        foreach (var sourceProperty in sourceProperties)
////        {
////            if (sourceProperty.CanRead)
////            {
////                PropertyInfo destProperty = destProperties.FirstOrDefault(p => p.Name == sourceProperty.Name);

////                if (destProperty != null && destProperty.CanWrite && destProperty.PropertyType == sourceProperty.PropertyType)
////                {
////                    var value = sourceProperty.GetValue(source);


////                    if (value != null && !value.GetType().IsPrimitive && value.GetType() != typeof(string))
////                    {

////                        if (value is IList)
////                        {

////                            Type listType = value.GetType();
////                            IList newList = Activator.CreateInstance(listType) as IList;

////                            foreach (var item in value as IList)
////                            {

////                                var itemType = item.GetType();
////                                var newItem = Activator.CreateInstance(itemType);


////                                CopyProperties(item, newItem);


////                                newList.Add(newItem);
////                            }


////                            destProperty.SetValue(destination, newList);
////                        }
////                        else
////                        {

////                            var objectType = value.GetType();
////                            var newObject = Activator.CreateInstance(objectType);

////                            CopyProperties(value, newObject);

////                            destProperty.SetValue(destination, newObject);
////                        }
////                    }
////                    else
////                    {
////                        destProperty.SetValue(destination, value);
////                    }
////                }
////            }
////        }
////    }
////}

////==============


using System;
using System.Collections;
using System.Linq;
using System.Reflection;


public class SimpleMapper
{
    public void Copy(object source, object destination)
    {
        PropertyCopier(source, destination);
    }

    private void PropertyCopier(object source, object destination)
    {
        Type TypeOfSource = source.GetType();
        Type TypeOfDestination = destination.GetType();

        PropertyInfo[] propertyFromSource = TypeOfSource.GetProperties();
        PropertyInfo[] propertyFromDestination = TypeOfDestination.GetProperties();
      
        foreach (var ps in propertyFromSource)
        {
            if (ps.CanRead)
            {
                PropertyInfo propertyDestination = propertyFromDestination.FirstOrDefault(p => p.Name == ps.Name);

                if (propertyDestination != null && propertyDestination.CanWrite)
                {
                    var value = ps.GetValue(source);

                    if (value != null)
                    {
                        if (value is IList && propertyDestination.PropertyType.IsGenericType)
                        {
                            Type TypeOfList = value.GetType();
                            IList newList = (IList)Activator.CreateInstance(propertyDestination.PropertyType);

                            Type TypeOfItem = propertyDestination.PropertyType.GetGenericArguments()[0];

                            foreach (var item in (IEnumerable)value)
                            {
                                var newItem = Activator.CreateInstance(TypeOfItem);
                                PropertyCopier(item, newItem);
                                newList.Add(newItem);
                            }

                            propertyDestination.SetValue(destination, newList);
                        }
                        else if (!value.GetType().IsPrimitive && value.GetType() != typeof(string))
                        {
                            var newObject = Activator.CreateInstance(propertyDestination.PropertyType);
                            PropertyCopier(value, newObject);
                            propertyDestination.SetValue(destination, newObject);
                        }
                        else
                        {
                            propertyDestination.SetValue(destination, value);
                        }
                    }
                    else
                    {
                        propertyDestination.SetValue(destination, null);
                    }
                }
            }
        }
    }
}

