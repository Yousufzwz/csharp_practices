
using ExamTask_02;



User user = new Student();

User user2 = new Student("Jalaluddin", 40);

User user3 = new Teacher("Hasan Ahmed", 42);

user3.Salary = 30000;
user2.Fees = -2000;
user.Name = "Tareq";
Console.WriteLine(user.Name);

