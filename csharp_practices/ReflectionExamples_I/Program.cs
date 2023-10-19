using ReflectionExamples_I;
using System.Collections;
using System.Reflection;


Assembly assembly = Assembly.GetExecutingAssembly();
foreach (var a in assembly.GetTypes())
{
    //Console.WriteLine(a.FullName);

    if (a.Name == "Program")
    {
        var methods = a.GetMethods(BindingFlags.NonPublic |
             BindingFlags.Instance | BindingFlags.Static);
        foreach (var m in methods)
        {
            Console.WriteLine(m.Name);
        }
    }

  
}


Course course = new Course("C#", 8000, new List<Topic>
    {
    new Topic { Title ="Tool Installation", Duration=1},
    new Topic { Title = "Getting Started", Duration = 2 },
    });


//Type type = typeof(Course);
Type type =course.GetType();
var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
foreach (var property in properties)
{
   // Console.WriteLine(property.GetValue(course));

    if(property.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
    {
        Type p = property.GetType();
        {
            Type[] genericArguments = p.GetGenericArguments();
            var items = (IEnumerable)property.GetValue(course);
            foreach(var item in items)
            {
                var it = item.GetType();
                var topicTypes = it.GetProperties(BindingFlags.Instance |
                    BindingFlags.Public);
                foreach(var topicType in topicTypes)
                {
                    Console.WriteLine(topicType.GetValue(item));
                }
            }
        }
        Console.WriteLine();
    }

    else
    {
        Console.WriteLine(property.GetValue(course));
    }
}
