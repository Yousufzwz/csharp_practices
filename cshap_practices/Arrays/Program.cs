


// single dimension

double[] peopleAges = new double[5]; 
peopleAges[0] = 20.5;
peopleAges[1] = 22.6;
peopleAges[2] = 24.8;
peopleAges[3] = 28.5;
peopleAges[4] = 30.1;

double selectedAges = peopleAges[0];
Console.WriteLine(selectedAges);

//for day-to-day use case

double[] newAges = new double [] { 26.5, 22.6, 26.4, 40.5};

//shortcut syntax

double[] newAges2 = { 20.8, 26.2, 23.5, 21.5 };


// multi-dimension

double[,] friendAges = new double[2, 2];
friendAges[0, 0] = 21.2;
friendAges[0, 1] = 23.4;
friendAges[1, 0] = 25.1;
friendAges[1, 1] = 28.1;


double[,] man = //[2,2]
{
    {
        21.2, 20.1
    },
    {
        25.1, 28.1
    },
 
    


};


int [] grades = new int[3];
grades[0] = 80;
grades[1] = 89;
grades[2] = 91;

int[] grades2 = { 80, 89, 91 };

double[] sample1 = new double[2];
sample1[0] = 85.6;
sample1[1] = 50.6;

double[] sample2 = new double[3];
sample2[0] = 87.4;
sample2[1] = 89.1;
sample2[2] = 67.3;

double[,] BMIinput = new double[2, 3];
BMIinput[0, 0] = 85.6;
BMIinput[0, 1] = 50.2;
BMIinput[0, 2] = 87.4;
BMIinput[1, 0] = 89.1;
BMIinput[1, 1] = 67.3;
BMIinput[1, 2] = 88.2;


int[,] nums = new int[4, 2];
nums[0, 0] = 11;
nums[0, 1] = 12;
nums[1, 0] = 13;
nums[1, 1] = 14;
nums[2, 0] = 15;
nums[2, 1] = 16;
nums[3, 0] = 17;
nums[3, 1] = 18;




double[,] newBMI = //new double[2, 5]
{
    {
        89.3, 45.7, 89.9, 50.5, 60.4
    },
    {
        90.5, 91.4, 89.3, 89.2, 66.4
    },

};

double[,,] friends = new double[4, 2, 2]
{
    {
        {3, 4},
        {5, 4},
    },
    {
        {6, 4},
        {8, 4}

    },
    {
        {9, 4},
        {10, 4},
    },
    {
        { 11, 5 },
        {11,6 }
    }

};

int[,,,] newNums = new int[2, 2, 1, 1]
{
    {
        {
            { 1 }
        },
        {
            { 2 }
        }
    },
    {
        {
            { 3 }
        },
        {
            { 4 }
        }
    }
};


//jagged array
int[] tokenList = new int[2];
int[] tokenList2 = new int[3];
int[] tokenList3 = new int[4];

int [][] tokens = new int[2][];
tokens[0] = tokenList;
tokens[1]=tokenList2;



/*
int[][,] newArray = new int[][,]
{
    new int[,] { {89, 10}, {100, 90} },
    new int[,] { {20, 5}, {11, 12}, {18, 19} },
    new int[,]  
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
*/

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




//int[,] matrix = {
//    {1, 2, 3},
//    {4, 5, 6},
//    {7, 8, 9}
//};



//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = i + 1; j < matrix.GetLength(1); j++)
//    {
//        int temp = matrix[i, j];
//        matrix[i, j] = matrix[j, i];
//        matrix[j, i] = temp;
//    }
//}


//for (int i = 0; i < matrix.GetLength(1); i++)
//{
//    for (int j = 0; j < matrix.GetLength(0); j++)
//    {
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}





//int[,] student = { { 10, 20}, { 30, 40} };

//for(int i = 0; i < student.GetLength(0);i++)
//{
//    for(int j =0; j < student.GetLength(1); j++)
//    {
//        Console.WriteLine(student[i,j]);

//    }
//}

//int[][] new3d = new int[3][];





//student data input-output
/*
var num1 = int.Parse(Console.ReadLine());
var num2 = int.Parse(Console.ReadLine());

string[,] studentData = new string[num1, num2];

for (int i = 0; i < num1; i++)
{
    Console.WriteLine($"Enter the name and ID of student {i + 1}:");
    string input = Console.ReadLine();
    string[] data = input.Split(',');

    studentData[i, 0] = data[0];  
    studentData[i, 1] = data[1];  
}

for (int i = 0; i < num1; i++)
{
    string name = studentData[i, 0];
    string id = studentData[i, 1];
    Console.WriteLine($"{name} {id}");
}
*/
/*
string input;
while (true)
{
    Console.WriteLine("Enter a string (or 'end' to exit):");
    input = Console.ReadLine();

    if (input.ToLower() == "end")
        break;

    int sum = 0;
    foreach (char c in input)
    {
        sum += c;
    }

    Console.WriteLine($"Sum of ASCII values: {sum}");
}
*/



/*
// Define the jagged array
int[][] jaggedArray = new int[3][];

// Input and store data in the jagged array
for (int i = 0; i < jaggedArray.Length; i++)
{
    Console.WriteLine($"Enter the number of elements for array {i + 1}:");
    int size = int.Parse(Console.ReadLine());

    jaggedArray[i] = new int[size];

    Console.WriteLine($"Enter {size} elements for array {i + 1}:");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        jaggedArray[i][j] = int.Parse(Console.ReadLine());
    }
}

// Print the stored data
Console.WriteLine("The stored data in the jagged array:");
for (int i = 0; i < jaggedArray.Length; i++)
{
    Console.Write($"Array {i + 1}: ");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
*/
/*
int[][] employeeData = new int[3][];
employeeData[0] = new int[] { 10, 20, 30, 40, 50 };
employeeData[1] = new int[1] { 100 };
employeeData[2] = new int[2] { 121, 131 };

for (int i = 0; i < employeeData.Length; i++)
{
    for (int j = 0; j < employeeData[i].Length; j++)
    {
        Console.WriteLine(employeeData[i][j] + " ");
    }
}

int[][,] officeData = new int[3][,];
officeData[0] = new int[,] { { 10, 20 }, { 1, 2 } };
officeData[1] = new int[,] { { 2, 3, 4, 5, 6, 7, 8 }, { 100, 200, 300, 400, 300, 400, 200 } };
officeData[2] = new int[,] { { 1 } };


for (int i = 0; i < officeData.Length; i++)
{
    Console.WriteLine($"Array {i + 1}:");
    for (int j = 0; j < officeData[i].GetLength(0); j++)
    {
        for (int k = 0; k < officeData[i].GetLength(1); k++)
        {
            Console.Write(officeData[i][j, k] + " ");
        }
        Console.WriteLine();
    }
}

*/

int[] data1 = { }; //new int[4];
int[,] data2 =
{
    {10,10,102},
    {11,21,111},
    
};

for(int i=0; i<data2.GetLength(0); i++)
{
    for(int j=0; j < data2.GetLength(1); j++)
    {
        Console.WriteLine(data2[i, j]);
    }
}
    



int a;





