

int? x = null;
if (true)
{
    x = 0;
}
else
{
    x = 1;
}
if(x.HasValue)
{
    Console.WriteLine(x.Value);
}

string? y = null;

x ??= 5;

int? z = null;
Console.WriteLine(z);
if(z.HasValue)
{
    Console.WriteLine("z has value: "+ z.HasValue);
}
else
{
    Console.WriteLine("z is null");
}
