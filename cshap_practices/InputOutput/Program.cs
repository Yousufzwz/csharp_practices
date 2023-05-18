
/*
Console.WriteLine("What is your name?");
Console.Write("My name is ");
Console.Write("Gazzali ");
string line= Console.ReadLine();
Console.WriteLine(line);


string Input= Console.ReadLine();

string[] dataInput = Input.Split(',');

Console.WriteLine($"Name: {dataInput[0]}, Age: {dataInput[1]}, Occupation: {dataInput[2]}, Hobby: {dataInput[3]}");



string newInput=Console.ReadLine();

var newData = newInput.Split(';');

Console.WriteLine($"Name: {newData[0]}, Age: {newData[1]}, Occupation: {newData[2]}, Hobby: {newData[3]}, Siblings: {newData[4]}");
*/



ConsoleKeyInfo input = Console.ReadKey();
Console.WriteLine("a");   
int a;


var numInput = Console.ReadLine();

var num1= int.Parse(numInput);
numInput = Console.ReadLine();  
var num2= int.Parse(numInput);
var sum = num1 * num2;
Console.WriteLine(sum);