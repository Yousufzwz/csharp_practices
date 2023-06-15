using OnlineOrder.io;
using PracticesForExam_1;

Garments product = new Shirts("POLO", "1239A");
Garments anotherProduct = new TravelBag("President", "10092PS");
StoredItems storedItem = new StoredItems(product);
storedItem.Count(anotherProduct);
Console.WriteLine(storedItem.counter);

University students = new UniStudents();
University studentData=new UniStudents("Ashraf", "120A");
University teacherData = new UniTeachers("Ahmad", "201A");
students.Name = "Zakariya";
Console.WriteLine(students.Name);

studentData.StudentPayment = 1200;
Console.WriteLine(studentData.StudentPayment);

teacherData.TeacherPayment = 900;
Console.WriteLine(teacherData.TeacherPayment);