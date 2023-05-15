

string name = "MahmudulHasan";
int nameSize = name.Length;
Console.WriteLine(nameSize);

string firstName = "Ahmad";
string lastName = "Esa";
string fullName= firstName + " "+ lastName;
Console.WriteLine(fullName);

string newString = "Good Boy";
string subNewString = newString.Substring(5, 3);
Console.WriteLine(subNewString);

int newNum = 100;
string convertedNum=newNum.ToString();
Console.WriteLine(convertedNum);

string newName = "Mahmud";
string newLastName = "Zakariya";
string formatthis = string.Format("This person's name is {0} {2}", newName, fullName, newLastName);
Console.WriteLine(formatthis);

int age = 27;
int numberOfApples = 12;

int totalFruit = numberOfApples + 5;

Console.WriteLine("I am " + age + " years old and have " + numberOfApples + " apples.");
Console.WriteLine("If I add 5 more apples, I will have " + totalFruit + " pieces of fruit.");