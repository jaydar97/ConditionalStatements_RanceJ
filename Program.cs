using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your expected grade for ISM 4300 ...");

            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);


                if (grade >= 98)
                {
                    Console.WriteLine("You will receive an A+!");
                }
                else if ((grade < 98) && (grade >= 92))
                {
                    Console.WriteLine("You will receive an A!");
                }
                else if ((grade < 98) && (grade >= 90))
                {
                    Console.WriteLine("You will receive an A-!");
                }
                else if ((grade < 90) && (grade >= 88))
                {
                    Console.WriteLine("You will receive a B+");
                }
                else if ((grade < 88) && (grade >= 82))
                {
                    Console.WriteLine("You will receive a B");
                }
                else if ((grade < 82) && (grade >= 80))
                {
                    Console.WriteLine("You will receive a B-");
                }
                else if ((grade < 80) && (grade >= 78))
                {
                    Console.WriteLine("You will receive a C+");
                }
                else if ((grade < 78) && (grade >= 72))
                {
                    Console.WriteLine("You will receive a C!");
                }
                else if ((grade < 72) && (grade >= 70))
                {
                    Console.WriteLine("You will receive a C-");
                }
                else if ((grade < 70) && (grade >= 68))
                {
                    Console.WriteLine("You will receive a D+");
                }
                else if ((grade < 68) && (grade >= 62))
                {
                    Console.WriteLine("You will receive a D");
                }
                else if ((grade < 62) && (grade >= 60))
                {
                    Console.WriteLine("You will receive a D-");
                }
                else if ((grade < 60))
                {
                    Console.WriteLine("You will receive an F");
                }
                else 
                {
                    Console.WriteLine("Please enter an integer...");
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
        
    }
}