using Delegate;



//int[] arr = new int[] { 4, 5, 6, 1, 2, 9 };

//BubbleSort<int> sort = new BubbleSort<int>();
//var result = sort.Sort(arr, CompareNumber);

//bool CompareNumber(int a, int b)
//{
//    return a > b;
//}


//foreach (int i in result)
//{
//    Console.Write(i);
//    Console.Write(' ');
//}

//Console.WriteLine();

//Person[] persons = new Person[5];
//persons[0] = new Person() { Name="Mahmud", Age=23};
//persons[1] = new Person() { Name = "Hasan", Age = 25 };
//persons[2] = new Person() { Name = "Ahmad", Age = 27 };
//persons[3] = new Person() { Name = "Hasan", Age = 31 };






//BubbleSort<Person> sort2 = new BubbleSort<Person>();

//var res2 = sort2.Sort(persons, ComparePerson);


//bool ComparePerson(Person a, Person b)
//{
//    if (a.Name.CompareTo(b.Name) == 0)
//        return a.Age < b.Age;
//    else
//        return a.Name.CompareTo(b.Name) > 0;
//}



//foreach (var person in res2)
//    {
//        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
//    }






int[] arr = new int[] { 3, 9, 2, 9, 4, 7, 3, 1 };

BubbleSort<int> sort = new BubbleSort<int>();
var result = sort.Sort(arr, CompareNumber);

bool CompareNumber(int a, int b)
{
    return a > b;
}









foreach (var item in result)
{
    Console.Write(item);
    Console.Write(' ');
}
Console.WriteLine();

Person[] persons = new Person[4];
persons[0] = new Person() { Name = "Tareq", Age = 25 };
persons[1] = new Person() { Name = "Hasan", Age = 30 };
persons[2] = new Person() { Name = "Tareq", Age = 35 };
persons[3] = new Person() { Name = "Arif", Age = 40 };


BubbleSort<Person> sort2 = new BubbleSort<Person>();
var compare = ComparePerson;
var result2 = sort2.Sort(persons, compare);

bool ComparePerson(Person a, Person b)
{
    if (a.Name.CompareTo(b.Name) == 0)
        return a.Age < b.Age;
    else
        return a.Name.CompareTo(b.Name) > 0;
}



foreach (var person in result2)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}