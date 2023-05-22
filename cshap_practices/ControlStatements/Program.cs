


#region if statement

//var num = Console.ReadLine();
//var x = int.Parse(num);

//if (x > 10)
//{
//    Console.WriteLine("This number is greater than 10");

//}
//else if(x==10)
//{
//    Console.WriteLine("Same number!");
//}
//else if (x != 5 && x < 5)
//{
//    Console.WriteLine("This number is not equal 5");
//}

//else
//{
//    Console.WriteLine("Not bigger than 10"); 
//}


#endregion



#region switch statement


//var input1 = Console.ReadLine();
//var n = int.Parse(input1);

//switch (n)
//{
//    case 0:
//        Console.WriteLine("What is your name?");
//        break;
//    case 1:
//        Console.WriteLine("My name is Zakariya.");
//        break;
//    case 2:
//        Console.WriteLine("What you do?");
//        break;
//    case 3:
//        Console.WriteLine("I am a teacher.");
//        break;
//}

#endregion


#region ternary operator

//var input2 = Console.ReadLine();

////
////var z=int.Parse(input2);

////var printMessage = z > 10 ? "Hey! it is greater than 10!!! Gr..eater than 10!" : "So what, it is smaller than 10";   
////Console.WriteLine(printMessage);

//var name = input2.Length > 11 ? input2.Substring(0, 11) : input2;
//Console.WriteLine(name);

#endregion


#region increment-decrement


//int w = 10;
//int k = w++;
//int y = ++w;
//Console.WriteLine(k);
//Console.WriteLine(y);

//int a = 10;
//int b = a--;
//int c = --a;
//Console.WriteLine(b);
//Console.WriteLine(c);

//int d = 10;
//d += 5;
//d -= 10;
//d /= 5;
//d *= 2;
//Console.WriteLine(d);


#endregion


#region for, while, do while, for each loop

//for (int i=0; i<5; i++)
//{
//    Console.WriteLine("Priting message");
//}

//int z1 = 50;
//while(z1>0)
//{
//    z1 /= 5;
//    Console.WriteLine("This times divided");
//}

//int z2 = 50;
//do
//{
//    z2 /= 50;
//    Console.WriteLine("While");

//} while(z2> 0);

//int [] numbersCollection = {10, 20, 30, 0, 50, -15};

//foreach(int numIterator in numbersCollection)
//{
//    if (numIterator < 0)
//        continue;
//    if (numIterator == 0)
//        continue;
//    if (numIterator < -5)
//        break;


//    Console.WriteLine(numIterator);
//}

//for(int i=0; i<numbersCollection.Length; i++)
//{
//    Console.WriteLine(numbersCollection[i]);
//}

#endregion


//string names = "mahmudul,hasan,rakib,uddin,ahmad,esa,abu,sufian,zakariya";
//var people = names.Split(',');

//var nameInput= Console.ReadLine();
//var peoplenames = nameInput.Split(' ');

//foreach ( var person in peoplenames)
//{
//    Console.Write(person + " ");


//}


//var inputs= int.Parse(Console.ReadLine());

//int s = 0;

//while(inputs>0)
//{
//    var mod = inputs % 10;
//    s += mod;
//    inputs /= 10;
//}
//Console.WriteLine(s);


//int[] numbers = { 2, 4, 6, 8, 10 };
//int sum = 0;

//foreach (int number in numbers)
//{
//    sum += number;
//}

//Console.WriteLine("Sum of numbers: " + sum);

/*
var name = "waterfruit";

var characters= name.ToCharArray();

for (int i = characters.Length -1 ; i >=0 ; i--)
{
    Console.Write(characters[i]);
}




Array.Reverse(characters);

foreach (char c in characters)
{ 
    Console.Write(c);
}

var nameposition = name.IndexOf('f');
Console.WriteLine(nameposition);

name = name.Replace("f", " f");
Console.WriteLine(name);

var firstPart = name.IndexOf(' ');
var lastPart= name.Substring(firstPart + 1);
Console.WriteLine(lastPart);

*/




//using System.Text;

//var message = "adfjlkdsfjlasdkjffjlfffoidffffflllaffffffahihdsfa";
//StringBuilder seletedMessage = new StringBuilder(message);
//for(int i=0; i<message.Length; i++)
//{
//    if (seletedMessage[i] =='f')

//        seletedMessage[i] = 'W';


//}
//message = seletedMessage.ToString();
//Console.WriteLine(message);


using System.Xml;

string originalString = "string,,, words!";
string substring1 = originalString.Substring(10); 
string substring2 = originalString.Substring(0, 6);
Console.WriteLine(substring1);
Console.WriteLine(substring2);


var sentence = "What is you doing Sulaiman";

var findIndex1 = sentence.IndexOf("Sulaiman");
Console.WriteLine(findIndex1);

var findIndex2 = sentence.Replace("Sulaiman", "Al-Amin");
Console.WriteLine(findIndex2);

var findIndex3 = findIndex2.IndexOf("-");
var lastNamePart=findIndex2.Substring(findIndex3+1);  
Console.WriteLine(lastNamePart);

var mainText = "This car is made by Toyota";
var upperText=mainText.ToUpper();
var lowerText=mainText.ToLower();
Console.WriteLine($"{upperText} {lowerText}");

var searchedText = "Toyota";
var uText=searchedText.ToUpper();
var modifiedText=mainText.Replace(searchedText, uText);
Console.WriteLine(modifiedText);

var replacedText = mainText.Replace("Toyota", "TOYOTA");
Console.WriteLine(replacedText);

var name = "strings";
var newName=name.Trim('s');
Console.WriteLine(newName);

newName=name.Replace("r", string.Empty);
Console.WriteLine(newName);



var charArray =name.ToCharArray();
Array.Reverse(charArray);

var reversedName = new string(charArray); //converted to string 
Console.WriteLine(reversedName);

var objectName = "     Beauteous   ";
var trimmedStart = objectName.TrimStart();
var trimmedEnd = trimmedStart.TrimEnd();
Console.WriteLine($"{trimmedStart} {trimmedEnd}");

string text = "Man";
char character = 'P';

string textToString = text.ToString(); 
string characterToString = character.ToString();

Console.WriteLine(textToString);
Console.WriteLine(characterToString);


var s = "World";
var s2 = "is not permanent";

var concateThem= string.Concat(s+" ", s2);
Console.WriteLine(concateThem);


