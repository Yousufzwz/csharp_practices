using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET;

public class DataUtility
{
    //public void InsertData()
    //{
    //    string connectStr = "Server=DESKTOP-7KDQ6IB\\SQLEXPRESS;Database=PracticedDB1;User Id=practiced1;Password=9876;TrustServerCertificate=True";
    //    using SqlConnection sqlConnection = new SqlConnection(connectStr);

    //    string sql1 = "insert into Courses ([name], fees, ClassStartDate, IsActive)\r\nvalues('Golang', 7000, '11/11/2022', 1);";
    //    SQLOperations(sql1, sqlConnection);

    //    string sql2 = "delete from Courses where name = 'Golang'";
    //    //SQLOperations(sql2 , sqlConnection);

    //    void SQLOperations(string sql, SqlConnection sqlConnection)
    //    {
    //        using SqlCommand command = new SqlCommand(sql, sqlConnection);
    //        if (sqlConnection.State != System.Data.ConnectionState.Open)
    //            sqlConnection.Open();

    //        command.ExecuteNonQuery();
    //    }


    //    Console.WriteLine("done");
    //}

    private SqlConnection _sqlConnection;
    public DataUtility(string connectionString) 
    {
        _sqlConnection = new SqlConnection(connectionString);
    }

    public void SQLOperations(string sql)
    {
        using SqlCommand cmd = CreateCommand(sql);
        cmd.ExecuteNonQuery();
    }

    public IList<Dictionary<string, object>>ReadData(string query)
    {
        using SqlCommand cmd = CreateCommand(query);
        using SqlDataReader reader= cmd.ExecuteReader();

        List<Dictionary<string, object>>data= new List<Dictionary<string, object>>();

        while (reader.Read())
        {
            Dictionary<string,object>row= new Dictionary<string,object>();
            for(int i=0; i<reader.FieldCount; i++)
            {
                row.Add(reader.GetName(i), reader.GetValue(i));
            }
            data.Add(row);
        }
        return data;
    }

    private SqlCommand CreateCommand(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, _sqlConnection);
        if (_sqlConnection.State != System.Data.ConnectionState.Open)
            _sqlConnection.Open();

        return cmd;
    }


}
