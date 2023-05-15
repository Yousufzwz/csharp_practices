

string name = "MahmudulHasan";
int nameSize = name.Length;
Console.WriteLine(nameSize);

string firstName = "Ahmad";
string lastName = "Esa";
string fullName= firstName + " "+ lastName;
Console.WriteLine(fullName);

string newString = "Good Boy";
string subNewString = newString.Substring(5, 3);
Console.WriteLine(subNewString );

int newNum = 100;
string convertedNum=newNum.ToString();
Console.WriteLine(convertedNum);

string newName = "Mahmud";
string newLastName = "Zakariya";
string formatthis = string.Format("This person's name is {0} {2} \n", newName, fullName, newLastName);
Console.WriteLine(formatthis);

int age = 27;
int numberOfApples = 12;

int totalFruit = numberOfApples + 5;

Console.WriteLine("I am " + age + " years old and have " + numberOfApples + " apples.");
Console.WriteLine("If I add 5 more apples, I will have " + totalFruit + " pieces of fruit. \n");

decimal productPrice = 19.99M;
decimal discount = 0.15M;
decimal discountedPrice = productPrice * (1 - discount);

Console.WriteLine($"The original price is {productPrice}");
Console.WriteLine($"The discount is {discount}");
Console.WriteLine($"The discounted price is {discountedPrice} \n");


Console.WriteLine("Size of bool: " + sizeof(bool) + " bytes");
Console.WriteLine("Size of byte: " + sizeof(byte) + " bytes");
Console.WriteLine("Size of char: " + sizeof(char) + " bytes");
Console.WriteLine("Size of short: " + sizeof(short) + " bytes");
Console.WriteLine("Size of int: " + sizeof(int) + " bytes");
Console.WriteLine("Size of long: " + sizeof(long) + " bytes");
Console.WriteLine("Size of float: " + sizeof(float) + " bytes");
Console.WriteLine("Size of double: " + sizeof(double) + " bytes");
Console.WriteLine("Size of decimal: " + sizeof(decimal) + " bytes \n");


Console.WriteLine("Size of bool: {0} bits", sizeof(bool) * 8);
Console.WriteLine("Size of byte: {0} bits", sizeof(byte) * 8);
Console.WriteLine("Size of char: {0} bits", sizeof(char) * 8);
Console.WriteLine("Size of short: {0} bits", sizeof(short) * 8);
Console.WriteLine("Size of int: {0} bits", sizeof(int) * 8);
Console.WriteLine("Size of long: {0} bits", sizeof(long) * 8);
Console.WriteLine("Size of float: {0} bits", sizeof(float) * 8);
Console.WriteLine("Size of double: {0} bits", sizeof(double) * 8);
Console.WriteLine("Size of decimal: {0} bits", sizeof(decimal) * 8);
Console.WriteLine("Size of object: {0} bits", IntPtr.Size * 8);
Console.WriteLine("Size of string: {0} bits", IntPtr.Size * 8);

