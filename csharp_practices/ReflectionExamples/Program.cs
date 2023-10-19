// See https://aka.ms/new-console-template for more information

using System.Reflection;
using ReflectionExamples;

Type t = typeof(Person);

Person p = new ();
Type type = p.GetType ();

MethodInfo [] methods= t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

foreach(MethodInfo m in methods)
{
    Console.WriteLine(m.Name);
}

ConstructorInfo defaultConstructor = t.GetConstructor(new Type[] { });
Person person = (Person)defaultConstructor.Invoke(new object[] { });

MethodInfo talkMethod= t.GetMethod("Talk",
    BindingFlags.Instance | BindingFlags.NonPublic, new Type[] {typeof(string)});

talkMethod.Invoke(person, new object[] { "Assalamualaikum" });    







