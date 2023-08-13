


//Linq
#region Linq1
using PracticesForExam_3;
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




