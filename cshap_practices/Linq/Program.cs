// See https://aka.ms/new-console-template for more information

using Linq;

List<Course>courses = new List<Course>();
courses.Add(new Course() {Id=1, Fees=5000, Title="C++" });
courses.Add(new Course() { Id = 2, Fees = 8000, Title = "C#" });
courses.Add(new Course() { Id = 3, Fees = 6000, Title = "Golang" });

List<Student> students = new List<Student>();
students.Add(new Student() { Id = 1, Name = "Ahmad",  CourseId= 2 });
students.Add(new Student() { Id = 2, Name = "Esa",    CourseId =3 });
students.Add(new Student() { Id = 3, Name = "Zakariya", CourseId = 1 });

var query = from s in students
            join c in courses on s.CourseId equals c.Id
            select (name: s.Name, fees: c.Fees);

var name = (from q in query where q.fees > 5000 select q.name).FirstOrDefault();

var name2 = query.Where(x => x.fees > 5000).Select(y => y.name).FirstOrDefault();

Console.WriteLine(name);
Console.WriteLine(name2);


