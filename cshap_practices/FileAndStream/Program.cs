using System.Text;

//File.WriteAllText("sample.txt", "Mahmud Zakariya");
//File.AppendAllLines("sample.txt", new string[] { "Line1", "Line2" });


//using (StreamWriter writer = File.AppendText("sample.txt"))
//{
//    writer.WriteLine("Line3");
//}

//{
//    using FileStream fileStream = File.Open("sample.txt", FileMode.Open);
//    byte[] buffer = new byte[10];
//    fileStream.Read(buffer, 0, 9);
//    string text = Encoding.UTF8.GetString(buffer);
//    Console.WriteLine(text);
//}

//using FileStream fs = File.Open("sample.txt", FileMode.Open);
//while (true)
//{
//    int x = fs.ReadByte();
//    if(x < 0)
//    { break; }
//    Console.Write((char)x);
//}

FileInfo myfile = new FileInfo("sample.txt");

if(myfile.Exists)
    Console.WriteLine("File exist!");

if(File.Exists("sample.txt"))
    Console.WriteLine("File exist!");


string myDirectory = Directory.GetCurrentDirectory();
DirectoryInfo dir = new DirectoryInfo(myDirectory);
string root = dir.Parent.Parent.Parent.FullName;
string path = Path.Combine(root, "sample.txt");
Console.WriteLine(path);