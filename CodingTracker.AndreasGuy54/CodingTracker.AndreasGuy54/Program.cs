﻿using CodingTracker.AndreasGuy54;
using Microsoft.Data.Sqlite;
using System.Configuration;

string connectionString = ConfigurationManager.AppSettings.Get("connString");

using (SqliteConnection connection = new SqliteConnection(connectionString))
{
    connection.Open();

    SqliteCommand tableCmd = connection.CreateCommand();
    tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS coding_hours(
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        StartTime TEXT,            
        EndTime TEXT,
        Duration TEXT)";


    tableCmd.ExecuteNonQuery();

    connection.Close();
}

UserInput.GetUserInput();

Console.ReadLine();

/*Console.WriteLine("Testing date format conversion");
string date = "15-09-23 14:30";
Console.WriteLine(date);

var cdate = Convert.ToDateTime(date);
Console.WriteLine(cdate.ToString("F"));*/