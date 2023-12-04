using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Assignment_01_Solution_Practice_;

public class SimpleMapper
{
    public void Copy(object source, object destination)
    {
        PropertyCopier(source, destination, new Dictionary<object, object>());
    }

    private void PropertyCopier(object source, object destination, Dictionary<object, object> visited)
    {
        if (source == null || destination == null || visited.ContainsKey(source))
            return;

        visited[source] = destination;

        Type typeOfSource = source.GetType();
        Type typeOfDestination = destination.GetType();

        PropertyInfo[] propertiesFromSource = typeOfSource.GetProperties();
        PropertyInfo[] propertiesFromDestination = typeOfDestination.GetProperties();

        foreach (var propertySource in propertiesFromSource)
        {
            if (propertySource.CanRead)
            {
                PropertyInfo propertyDestination = propertiesFromDestination.FirstOrDefault(p => p.Name == propertySource.Name);

                if (propertyDestination != null && propertyDestination.CanWrite)
                {
                    var value = propertySource.GetValue(source);

                    if (value != null)
                    {
                        if (value is IList && propertyDestination.PropertyType.IsGenericType)
                        {
                            HandleListMapping(value, propertyDestination, destination, visited);
                        }
                        else if (value.GetType().IsArray && propertyDestination.PropertyType.IsArray)
                        {
                            HandleArrayMapping(value, propertyDestination, destination, visited);
                        }
                        else if (!propertySource.PropertyType.IsPrimitive && propertySource.PropertyType != typeof(string))
                        {
                            HandleComplexTypeMapping(value, propertyDestination, destination, visited);
                        }
                        else
                        {
                            propertyDestination.SetValue(destination, value);
                        }
                    }
                    else
                    {
                        // Handle null values
                        propertyDestination.SetValue(destination, null);
                    }
                }
            }
        }
    }

    private void HandleListMapping(object value, PropertyInfo propertyDestination, object destination, Dictionary<object, object> visited)
    {
        Type typeOfList = value.GetType();
        IList newList = (IList)Activator.CreateInstance(propertyDestination.PropertyType);

        Type typeOfItem = propertyDestination.PropertyType.GetGenericArguments()[0];

        foreach (var item in (IEnumerable)value)
        {
            var newItem = Activator.CreateInstance(typeOfItem);
            PropertyCopier(item, newItem, visited);
            newList.Add(newItem);
        }

        propertyDestination.SetValue(destination, newList);
    }

    private void HandleArrayMapping(object value, PropertyInfo propertyDestination, object destination, Dictionary<object, object> visited)
    {
        Type typeOfItem = propertyDestination.PropertyType.GetElementType();
        IList newList = new List<object>();

        foreach (var item in (Array)value)
        {
            var newItem = Activator.CreateInstance(typeOfItem);
            PropertyCopier(item, newItem, visited);
            newList.Add(newItem);
        }

        // Convert the List<T> to an array
        Array newArray = Array.CreateInstance(typeOfItem, newList.Count);
        for (int i = 0; i < newList.Count; i++)
        {
            newArray.SetValue(newList[i], i);
        }

        propertyDestination.SetValue(destination, newArray);
    }


    private void HandleComplexTypeMapping(object value, PropertyInfo propertyDestination, object destination, Dictionary<object, object> visited)
    {
        // Check if the property type has a parameterless constructor
        var constructor = propertyDestination.PropertyType.GetConstructor(Type.EmptyTypes);

        if (constructor != null)
        {
            var newObject = constructor.Invoke(null);
            PropertyCopier(value, newObject, visited);
            propertyDestination.SetValue(destination, newObject);
        }
        else
        {
            // Handle the case where the property type does not have a parameterless constructor
            // You may choose to throw an exception, log a warning, or handle it in another way.
            // For simplicity, we'll set the property to null in this example.
            propertyDestination.SetValue(destination, null);
        }
    }

}


