
/*
Console.WriteLine("What is your name?");
Console.Write("My name is ");
Console.Write("Gazzali ");
string line= Console.ReadLine();
Console.WriteLine(line);


string Input= Console.ReadLine();

string[] dataInput = Input.Split(',');

Console.WriteLine($"Name: {dataInput[0]}, Age: {dataInput[1]}, Occupation: {dataInput[2]}, Hobby: {dataInput[3]}");
*/


string newInput=Console.ReadLine();

var newData = newInput.Split(';');

Console.WriteLine($"Name: {newData[0]}, Age: {newData[1]}, Occupation: {newData[2]}, Hobby: {newData[3]}, Siblings: {newData[4]}");


