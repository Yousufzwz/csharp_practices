

var person = (name:"Ahmad", age:21, weight:80.20);
Console.WriteLine(person.name);
Console.WriteLine(person.age);

(int amount, int price) Calculate (int a, int b)
{
    return (3,3);
}

(int[] a, int b) data = (new int[] { 1, 2, 3, 4, 5 }, 122);
(double c, int d)[] newData = new (double, int)[] { (1.1, 2)};


var (quantity, products) = GetProduct(1, 11);
Console.WriteLine($"quantity:{quantity}, products:{products}");


(int quantity, int products) GetProduct(int a, int b)
{
    int quantity = a + 1000;
    int products = b + 10;
    return (quantity, products);
}