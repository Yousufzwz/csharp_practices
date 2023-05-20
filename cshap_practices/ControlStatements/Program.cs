


# region if statement

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



# region switch statement


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


# region ternary operator

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


# region for loop

for (int i=0; i<5; i++)
{
    Console.WriteLine("Priting message");
}

int z1 = 50;
while(z1>0)
{
    z1 /= 5;
    Console.WriteLine("This times divided");
}

int z2 = 50;
do
{
    z2 /= 50;
    Console.WriteLine("While");

} while(z2> 0);

int [] numbersCollection = {10, 20, 30, 0, 50, -15};

foreach(int numIterator in numbersCollection)
{
    if (numIterator < 0)
        continue;
    if (numIterator == 0)
        continue;
    if (numIterator < -5)
        break;
   
    
    Console.WriteLine(numIterator);
}

for(int i=0; i<numbersCollection.Length; i++)
{
    Console.WriteLine(numbersCollection[i]);
}

#endregion

int[][,] newArray = new int[][,]

{
new int[,] { {89, 10}, {100, 90} },
new int[,] { {20, 5}, {11, 12}, {18,19} },
new int[,] { {21, 22}, {23, 24}, {25, 26} }
};

int b1= 100;


