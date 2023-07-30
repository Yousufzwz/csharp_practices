// See https://aka.ms/new-console-template for more information

using EntityExample;


TrainingDbContext context = new TrainingDbContext();

//context.Courses.Add(new Course { Name = "React.js", Fees=8000, IsActive = true, ClassStartTime=DateTime.Now });
//context.Courses.Add(new Course { Name = "C++", Fees = 18000, IsActive = true, ClassStartTime = DateTime.Now });
//context.Students.Add(new Student { Name = "Ahmad",  CGPA=3.9 });

//context.SaveChanges();

Course course1= context.Courses.Where(c => c.Id == 3).FirstOrDefault();
Console.WriteLine(course1.Name);

course1.Fees = 10000;
context.SaveChanges();

context.Courses.Remove(course1);
context.SaveChanges();


