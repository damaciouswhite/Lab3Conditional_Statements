using System;


namespace Lab3_ConditionalStatements
{
    class Program
    {

        public static string Name { get; set; }
        public static int Integer { get; set; }


        public static void Intro()
        {
            Console.WriteLine("The purpose of this application is for the user to enter a number between 1-100 and the system returns a message indicating what type of number they entered \n(even/odd/etc).");
            Console.WriteLine("");
            Console.Write("Please enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Hello {Name}!");
            Console.WriteLine("");
        }

        public static bool GetInt()
        {

            Console.Write("Please enter a Integer (1-100): ");
            Console.WriteLine("");

            while (true)
            {
                
                Integer = Convert.ToInt32(Console.ReadLine());
                if (Integer <= 0 || Integer > 100)
                {
                    Console.WriteLine("That is not a valid input. Please enter a Interger (1-100)");
                    continue;
                }

                Console.WriteLine($"You entered : {Integer}");
                Console.WriteLine("");
                return false;
            }
        }


        public static void Beginning()
        {
            Console.WriteLine("Lab 3");
            Console.WriteLine("=====");
            Console.WriteLine();
            Console.WriteLine("Conditional Statments & Decesion Making");
            Console.WriteLine("=======================================");
            Console.WriteLine();
        }

        public static bool Condition()
        {
            if (Integer % 2 != 0)
            {
                Console.WriteLine($"{Name}, the number you entered was odd");
            }
            if (Integer % 2 == 0 && Integer >= 2 && Integer <= 25)
            {
                Console.WriteLine($"{Name}, the number you entered was even and less than 25");
            }
            if (Integer % 2 == 0 && Integer >= 26 && Integer <= 60)
            {
                Console.WriteLine($"{Name}, the number you entered was even, greater than 25 and less than 60");
            }
            if (Integer % 2 == 0 && Integer >= 60)
            {
                Console.WriteLine($"{Name}, the number you entered was even and greater than 60");
            }
            if (Integer % 2 != 0 && Integer >= 60)
            {
                Console.WriteLine($"{Name}, the number you entered was odd and greater than 60");
            }
            return false;

        }

        public static void ToContinue()
        {   
            Console.WriteLine("");
            Console.WriteLine("Would you like to enter another number? (y/n)");
            string ContinueAnswer = Console.ReadLine().ToLower();
            if (ContinueAnswer == "y")
            {
                GetInt();
            }
            Console.WriteLine("Thanks, have a good day!");

        }

        static void Main(string[] args)
        {
            Beginning();
            Intro();
            GetInt();
            Condition();
            ToContinue();

        }
    }
}
