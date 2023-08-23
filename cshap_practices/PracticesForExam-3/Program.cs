


//Linq
#region Linq1
using PracticesForExam_3;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Xml.Linq;

List<int>numbers= new List<int> { 70, 10, 5, 2, 3};

var sortedNum = from num in numbers
                orderby num
                select num;

var evenNum = numbers.Where(x => x % 2 == 0);

var sum = numbers.Sum();
var average=numbers.Average();
var max=numbers.Max();
var min=numbers.Min();

Console.WriteLine("Sorted Numbers:");
foreach (var num in sortedNum)
{
    Console.WriteLine(num);
}
Console.WriteLine();

Console.WriteLine("Even Numbers:");
foreach (var num in evenNum)
{
    Console.WriteLine(num);
}
Console.WriteLine();
#endregion
#region Linq2
List<string>words= new List<string>() {"apple", "banana", "mango", "coconut", "pear" };

var selectedWords = words.Where(w => w.Contains("a") && w.Length >= 5);
foreach (var word in selectedWords)
{
    Console.WriteLine(word);
}
Console.WriteLine();


List<string> fruits = new List<string> { "apple", "banana", "cherry", "apricot", "grape" };

var selectedFruits = fruits.Select(fruit => fruit.ToUpper())
                           .Where(upperFruit => upperFruit.StartsWith("A"));

Console.WriteLine("Uppercase fruits with 'A':");
foreach (var fruit in selectedFruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine();


List<int> n = new List<int>() {1,2,3,4,5,10 };
bool containOdd=n.Any(x => x % 2 != 0);
bool allGthanZero=n.All(y=>y>0);
Console.WriteLine(containOdd);
Console.WriteLine(allGthanZero);


List<Student> students = new List<Student>();
students.Add(new Student() { Id = 1, Name = "Ahmad", Age = 22, CourseId = 1 });
students.Add(new Student() { Id = 2, Name = "Robert", Age = 21, CourseId = 2 });
students.Add(new Student() { Id = 3, Name = "Alice", Age = 27, CourseId = 1 });
students.Add(new Student() { Id = 4, Name = "Sultana", Age = 26, CourseId = 3 });
students.Add(new Student() { Id = 5, Name = "Zakariya", Age = 21, CourseId = 2 });

List<Course> courses = new List<Course>
{
    new Course{Id =1, Title="C++ Programming"},
    new Course{Id =2, Title="Geometry"},
    new Course{Id =3, Title="DSA"}

};

var ageByCourse = from s in students
                  join c in courses on s.CourseId equals c.Id
                  group s.Age by c into courseGroup
                  select new { CourseTitle = courseGroup.Key.Title,
                      AverageAge = courseGroup.Average()
                  };

Console.WriteLine("Average Age by Course:");
foreach (var result in ageByCourse)
{
    Console.WriteLine($"Course: {result.CourseTitle}, Average Age: {result.AverageAge}");
}
#endregion

//Delegate
#region Delegate1
Console.WriteLine();

Notifier notifier = new Notifier();
notifier.Notification += SendEmail;
notifier.Notification += SendSMS;

notifier.SendNotification("Important message!!!");

notifier.Notification -= SendEmail;

notifier.SendNotification("Information updated.");


void SendEmail(string message)
{
    Console.WriteLine($"Sending email: {message}");
}

void SendSMS(string message)
{
    Console.WriteLine($"Sending SMS: {message}");
}

Console.WriteLine();


WeatherStation station = new WeatherStation();
RemoteDisplay remoteDisplay = new RemoteDisplay();

station.WeatherChanged += remoteDisplay.ShowWeather;

station.CurrentTemp = 32.6;
station.CurrentTemp = 30.5;

station.WeatherChanged -= remoteDisplay.ShowWeather;

station.CurrentTemp = 31.3;

Console.WriteLine();
#endregion

//Func, Lambda
#region Func, Lambda
Func<int, int> square = x => x * x;
int res = square(5);
Console.WriteLine(res);

int[] nums = { 9, 2, 3, 5, 1, 8 };
var evens=nums.Where(x=>x %2 == 0);

foreach(int en in evens)
Console.WriteLine(en);

Console.WriteLine();

Func<double, double>CalcCircleArea = r =>Math.PI * r *r;
double ca = CalcCircleArea(3.0);
Console.WriteLine(ca);

Console.WriteLine();

List<string> names = new List<string>
{
    "Mahmud", "Ahmad", "Zakariya", "Idris"
};

names.Sort((n1, n2)=> n1.CompareTo(n2));    
foreach(string sortedNames in names)
    Console.WriteLine(sortedNames);

Console.WriteLine();
#endregion

//FileStream

//string filePath = "newSample.txt";

//using (FileStream fileStream = new FileStream(filePath, FileMode.Create)) 
//{
//    string data = "Hi, there!";
//    byte[] bytes= Encoding.UTF8.GetBytes(data);
//    fileStream.Write(bytes, 0, bytes.Length);   
//}

//Console.WriteLine("Data written in the file");

//using (FileStream fileStream2 = new FileStream(filePath, FileMode.Create))
//{
//    byte[] buffer = new byte[fileStream2.Length];
//    int byteRead=fileStream2.Read(buffer, 0, buffer.Length);
//    string readData= Encoding.UTF8.GetString(buffer, 0, byteRead);
//    Console.WriteLine($"Read from file: {readData}");

//}

Console.WriteLine();


//Action
List<int> newNums= new List<int> {9,2,3,6,1,5 };

Action<int> printAndDouble = nums => Console.WriteLine($"Previous:{nums}, After doubling: {nums * 2}");
foreach(int num in newNums)
    printAndDouble(num);

Console.WriteLine(  );

List<Product> products = new List<Product>();
products.Add(new Product() {Name ="Smart Phone", Price=15000 });
products.Add(new Product() { Name = "Camera", Price = 25000 });
products.Add(new Product() { Name = "Tablet", Price = 35000 });
products.Add(new Product() { Name = "Laptom", Price = 55000 });
products.Add(new Product() { Name = "Computer", Price = 85000 });

Action<Product> processProduct = products =>
{
    Console.WriteLine($"Product: {products.Name}");
    Console.WriteLine($"Price: {products.Price}");

    if (products.Price >= 35000)
    {
        Console.WriteLine("High priced products");
    }
    else
    {
        Console.WriteLine("Low priced products");
    }
    Console.WriteLine(  );
};

foreach(Product product in products)
{
    processProduct(product);
}



string[] wordss = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
var wordGroups = from w in words
                 group w by w[0] into g
                 select (FirstLetter: g.Key, Words: g);
foreach (var g in wordGroups)
{
    Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
    foreach (var w in g.Words)
    {
        Console.WriteLine(w);
    }
}



