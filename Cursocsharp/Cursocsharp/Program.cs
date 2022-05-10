// See https://aka.ms/new-console-template for more information
using Cursocsharp;

Console.WriteLine("Hello, World!");

//Date date1 = new Date(2022, 05, 10);

try
{
    Console.WriteLine(new Date(2024, 02, 29));
    Console.WriteLine(new Date(2020, 11, 21));
    Console.WriteLine(new Date(1983, 11, 30));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
