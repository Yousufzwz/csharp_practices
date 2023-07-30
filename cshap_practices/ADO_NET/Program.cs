// See https://aka.ms/new-console-template for more information

using ADO_NET;

string connectionString= "Server=DESKTOP-7KDQ6IB\\SQLEXPRESS;Database=PracticedDB1;User Id=practiced1;Password=9876;TrustServerCertificate=True";
DataUtility data1 = new DataUtility(connectionString);
//string sql = "delete from courses where name= 'Power Bi';";
//data1.SQLOperations(sql);

string query = "select * from courses";
IList<Dictionary<string, object>> data = data1.ReadData(query);
foreach(var dataItem in data)
{
    Console.WriteLine($"Id: {dataItem["Id"]}, name: {dataItem["Name"]}, fees:{dataItem["Fees"]}");
    //foreach(var col in dataItem)
    //{
    //    Console.Write($"{col.Key}:{col.Value}");
    //}
}




