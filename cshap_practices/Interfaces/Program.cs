



var boss = new Boss();
var employee=new Employee();
var technician=new Technician();
PrintID(boss);
PrintID(employee);
PrintID(technician);



void PrintID(Workplace persons)
{
    Console.WriteLine(persons.ID);
}