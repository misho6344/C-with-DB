


************************************ Basic c# project connected to ssms21 database *********************************************





Server=(localdb)\\mssqllocaldb;  Database=test;  Trusted_Connection=True;

database - test , table - dbo.person   on ssms21 database program

works only if it has coloms (id, name, lastname)  in _  _ssms database_  _ , in the test database in the dbo.person table.

NuGet packages - microsoft.sql.client 6.0.2 version.



********************************* Connection_String **********************************************



using Microsoft.Data.SqlClient;
var connectionstring = @"Server=(localdb)\mssqllocaldb;Database=test;Trusted_Connection=True;";

SqlConnection connection = new SqlConnection(connectionstring);
connection.Open();

var query = "SELECT * FROM dbo.person";
SqlCommand command = new SqlCommand(query, connection); 
var sqldatareader = command.ExecuteReader();
while (sqldatareader.Read())
{
    Console.WriteLine($"ID: {sqldatareader.GetInt32(0)}");
    Console.WriteLine($"Name: {sqldatareader.GetString(1)}");
    Console.WriteLine($"LastName: {sqldatareader.GetString(2)}");
    Console.WriteLine("\n");

}

Console.WriteLine("database opened");
connection.Close();

****************************************************************************************************************

