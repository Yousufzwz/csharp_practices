

using Structure;

Student student1 = new Student("a");
student1.Name = "Mahmud";
student1.Write("Doing homework");

Student student2 = student1;

Console.WriteLine(student1.Name);
Console.WriteLine(student2.Name);

student2.Name = "Ahmad";
Console.WriteLine(student1.Name);
Console.WriteLine(student2.Name);

void ChangeName(Student n)
{
    n.Name = "Zakariya";
}

ChangeName(student1);
Console.WriteLine(student1.Name);