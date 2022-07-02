// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string SQL = "SELECT Categories, Produts FROM MyProducts WHERE EXIST (SELECT Categories)";