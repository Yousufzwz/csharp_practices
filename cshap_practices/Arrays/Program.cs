


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


double[,] man =
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

//jagged array
int [] tokenList = new int[2];
int[] tokenList2 = new int[3];
int[] tokenList3 = new int[4];

int [][] tokens = new int[2][];
tokens[0] = tokenList;
tokens[1]=tokenList2;
tokens[2]=tokenList3;

int[][] newTokens =
{
    new int [] { 0, 1, 2, 3, 4 },
    new int [] { 1, 2,},

};


int[,,,] newNums = new int[2, 2, 1, 1];





