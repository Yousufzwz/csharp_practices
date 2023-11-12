using BuilderPattern;

string connectionString =
   new ConnectionStringBuilder("localhost", "PracticeDB1")
   //.UseTrustedConnection()
   .UsePort(25) 
   .UseMultipleActiveRecordSet()
   .SetCredentials("mahmud", "12345")
   .GetConnectionString();

Console.WriteLine(connectionString);


        
    