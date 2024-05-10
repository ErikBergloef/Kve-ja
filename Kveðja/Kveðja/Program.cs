using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string signature = "Kvedja,\n";
            
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine(signature + firstName);
            


        }
    }
}