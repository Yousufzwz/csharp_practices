

using Exam_01_Practices;
using TaskCompletion.io;
using Library.cs;

int[,] array1 =
{
    {20, 21, 22, 23, 24, },
    {25, 26, 27, 28,29}

};

int[,,] array2 =
{
    {
        { 1,2,3 },
        { 2,3,4 },
    },
    {
        {4, 5, 6 },
        { 2,3,4 },
    },
     {
        {4, 5, 6 },
        { 2,3,4 },
    }
};

//int[][] array3 = new int[3][];
//array3[0] = new int[] {1,2,3 };
//array3[1] = new int[] { 1};
//array3[2] = new int[] { 10, 11, 12, 13 };

//for(int i=0; i<array3.Length; i++)
//{
//    for(int  j=0; j < array3[i].Length; j++)
//    {
//        Console.WriteLine(array3[i][j]);
//    }
//}

//int[][,] array4= new int[3][,];
//array4[0] = new int[,] { { 100, 200 }, { 1, 2},{ 3,1},{ 4,5} };
//array4[1] = new int[,] { {89, 79 } };
//array4[2] = new int[,] { {90}, { 10 } };

//for(int i=0; i < array4.Length; i++)
//{
//    for(int j=0; j < array4[i].GetLength(0); j++)
//    {
//        for(int k=0; k<array4[i].GetLength(1);k++)
//        {
//            Console.WriteLine(array4[i][j, k]);
//        }
//}
//}


//string input = Console.ReadLine();

//while (input != "end")
//{
//    char[] charArray = input.ToCharArray();
//    Array.Reverse(charArray);
//    string reversedInput = new string(charArray);

//    if (input.ToLower() == reversedInput.ToLower())
//    {
//        Console.WriteLine("Palindrome");
//    }
//    else
//    {
//        Console.WriteLine("Not Palindrome");
//    }

//    input = Console.ReadLine();
//}



//int n=int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//string[,] studentData= new string[n,m];

//for(int i=0;i<n;i++)
//{
//    Console.WriteLine($"Enter Name and ID {i+1}:");
//    string[] data = Console.ReadLine().Split(' ');

//    studentData[i, 0] = data[0];
//    studentData[i, 1]= data[1];

//}

//for(int i=0; i<n;i++)
//{
//    string name = studentData[i,0];
//    string id = studentData[i, 1];
//    Console.WriteLine($"Student:{name} ID:{id}");


//}

Counter.GetCounter();
Car c = new Car();
c.Start();
c.Stop();

Product product = new Shirt("US-Polo", "1902A");
Product anotherProduct = new Bags("President", "10092PS");
StoreRoom storedItem= new StoreRoom(product);
storedItem.Count(anotherProduct);
Console.WriteLine(storedItem.counter);



LibraryMember pupilMember = new Student();
LibraryMember pupilData= new Student("Ahmad", 901);
LibraryMember masterData = new Teacher("Mahmud", 111);

pupilMember.Name = "Ahmad";
Console.WriteLine(pupilMember.Name);

masterData.MasterFee = 1200;
Console.WriteLine(masterData.MasterFee);

pupilData.PupilFee = -100;
Console.WriteLine(pupilData.PupilFee);



