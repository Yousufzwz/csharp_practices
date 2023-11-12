using Prototype;

Product p1 = new Product();
p1.Name = "Laptop";
p1.Price = 100;

Product p2 = p1.Copy();

if(p1!=p2)
{
    Console.WriteLine("Different object!");
}

Console.WriteLine($"{p2.Name}, {p2.Price}");