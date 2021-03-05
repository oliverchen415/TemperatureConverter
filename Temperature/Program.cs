using System;
using TemperatureLibrary;

namespace TemperatureProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            
            Console.WriteLine("Temperature conversion\r");
            Console.WriteLine("----------------------\n");

            while (!endApp)
            {
                string temp = "";
                double result = 0;

                Console.WriteLine("Type a temperature, then press enter.");
                temp = Console.ReadLine();

                double cleanNum = 0;
                while (!double.TryParse(temp, out cleanNum))
                {
                    Console.WriteLine("Invalid input. Please enter a number: ");
                    temp = Console.ReadLine();
                }

                Console.WriteLine("Choose an option (convert from - convert to)");
                Console.WriteLine("\ta) F to C");
                Console.WriteLine("\tb) F to K");
                Console.WriteLine("\tc) C to F");
                Console.WriteLine("\td) C to K");
                Console.WriteLine("\te) K to F");
                Console.WriteLine("\tf) K to C");
                Console.Write("Your Option? ");

                string op = Console.ReadLine();

                try
                {
                    result = TempConvert.Conversion(cleanNum, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("The operation will result in an invalid value.\n");
                    }
                    else Console.WriteLine($"Your result: {result:F2}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception has occurred! " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                Console.WriteLine("Press 'n' and 'Enter' to exit the app, or any other key and 'Enter' to continue: ");

                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");

            }
            return;
           
        }

    }
}


