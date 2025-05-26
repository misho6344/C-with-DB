// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
var connectionstring = @"Server=(localdb)\mssqllocaldb;Database=test;Trusted_Connection=True;";

SqlConnection connection = new SqlConnection(connectionstring);
connection.Open();

var insert = "INSERT INTO dbo.person VALUES ('4','ri','li')";
SqlCommand command = new SqlCommand(insert, connection); 

command.ExecuteNonQuery();
Console.WriteLine("done!" );

connection.Close();