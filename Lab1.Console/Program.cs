using System;
using System.Configuration;
using Lab1.Console;

class Program
{
    static void Main()
    {
        var name = ConfigurationManager.AppSettings["Name"] ?? "Студент";
        Console.WriteLine(string.Format(Resource1.ResHello, name));
        Console.WriteLine("Нажмите  Enter...");
        Console.ReadLine();
        Console.WriteLine(string.Format(Resource1.ResBye, name));
    }
}
