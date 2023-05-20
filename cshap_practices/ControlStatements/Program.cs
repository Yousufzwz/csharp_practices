


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


# region for, while, do while, for each loop

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



int[][,] newArray = new int[][,]
{
    new int[,] { {89, 10}, {100, 90} },
    new int[,] { {20, 5}, {11, 12}, {18, 19} },
    new int[,] { {21, 22}, {23, 24}, {25, 26} }
};

// Iterate through each element in the array
for (int i = 0; i < newArray.Length; i++)
{
    int[,] subArray = newArray[i];

    // Iterate through each element in the subarray
    for (int j = 0; j < subArray.GetLength(0); j++)
    {
        for (int k = 0; k < subArray.GetLength(1); k++)
        {
            int element = subArray[j, k];
            Console.WriteLine(element);
        }
    }
}


/*
int[][] newArray2 = new int[3][];
newArray2[0] = new int[] {1,2};
newArray2[1] = new int[] { 1, 2, 3, 4, 5 };
newArray2[2] = new int[] { 1 };



int[][][] newArray3 = new int[3][][];

newArray3[0] = new int[2][];         
newArray3[1] = new int[3][];        
newArray3[2] = new int[1][];        

newArray3[0][0] = new int[3];       
newArray3[0][1] = new int[2];       
newArray3[1][0] = new int[4];       
newArray3[1][1] = new int[2];       
newArray3[1][2] = new int[3]; 
newArray3[2][0] = new int[2];       

newArray3[0][0][0] = 1;             
int value = newArray3[0][0][0];     



int[,] maleTeachers = //new int [2,3]
{ {10, 11, 12}, {13, 14, 15 } };


for(int mt=0; mt<maleTeachers.GetLength(0); mt++)
{
    for(int mt1=0; mt1<maleTeachers.GetLength(1); mt1++)
    {
        Console.WriteLine(maleTeachers[mt, mt1]);
    }
}


int[,,,] studentID = { //[3,1,1,5]
    { { { 301, 302, 303, 304, 305 } } },
    { { { 306, 307, 308, 309, 310 } }},
    {{ { 50, 51, 52, 53, 54} } }
   

};
    

for (int i = 0; i < studentID.GetLength(0); i++)
{
    for (int j = 0; j < studentID.GetLength(1); j++)
    {
       for(int k = 0; k < studentID.GetLength(2); k++)
        {
          for(int m =0;  m < studentID.GetLength(3); m++)
            {
                Console.WriteLine(studentID[i, j, k, m]);
            }
        }
    }
}

*/
/*
int dataRow = int.Parse(Console.ReadLine());

int[][] dataArray = new int[dataRow][]; 

for (int i = 0; i < dataRow; i++)
{
    var inputtingNums = Console.ReadLine().Split(' ');
    dataArray[i] = new int[inputtingNums.Length];
    
    for(int j = 0;j < inputtingNums.Length; j++)
    { dataArray[i][j] = int.Parse(inputtingNums[j]);}
}

*/