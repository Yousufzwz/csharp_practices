

int? a = null;
Console.WriteLine(a);
if (a.HasValue)
{
    Console.WriteLine("variable a has value, which is:"+ a.HasValue);
}
else
{
    Console.WriteLine("a is null");
}
