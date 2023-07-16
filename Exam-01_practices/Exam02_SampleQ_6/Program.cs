


var(a,b) = Getresult(20,10);
Console.WriteLine($"{a},{b}");

(int a, int b) Getresult(int x, int y)
{
    int a = x * y;
    int b = x - y;
    return (a, b);
}