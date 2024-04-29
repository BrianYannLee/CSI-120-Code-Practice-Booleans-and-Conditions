//Programmer: Brian Lee
//Date: 04/29/2024

//Code Practice Boleans and Condition

namespace CSI_120_Code_Practice_Booleans_and_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick which you want to use.");
            Console.WriteLine("1. Temperature Check");
            Console.WriteLine("2. Odd or Even Check");
            Console.WriteLine("3. Leap Year Check");

            int userInput;
            try
            {
                while(!int.TryParse(Console.ReadLine(), out userInput) || (userInput < 1 || userInput >3))
                    Console.WriteLine("Invalid Input. Try Again");
                if (userInput == 1)
                    Part1();
                else if (userInput == 2)
                    Part2();
                else if (userInput == 3)
                    Part3();
                else
                    Console.WriteLine("Error has occured");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }




        }//end of main
        public static void Part1()
        {
            Console.WriteLine("Part 1");
            Console.WriteLine();

            Console.WriteLine("Please Enter a temperature");
            double userInput;

            try
            {
                while (!double.TryParse(Console.ReadLine(), out userInput))
                    Console.WriteLine("Invalid Input. Try Again");

                if (userInput < 32)
                    Console.WriteLine("That's Freezing, be careful out there.");
                else if (33 <= userInput && userInput <= 50)
                    Console.WriteLine("It's really cold out, bring a jacket");
                else if (51 <= userInput && userInput <= 68)
                    Console.WriteLine("It's starting to get cold. A sweater should work");
                else if (69 <= userInput && userInput <= 75)
                    Console.WriteLine("It's comfortable out. A shirt and jeans will work");
                else
                    Console.WriteLine("It's T-shirt and short time");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }

            Console.WriteLine();
        }//end of Part1
        public static void Part2()
        {
            Console.WriteLine("Part 2");
            Console.WriteLine();

            int userInput;
            Console.WriteLine("Please enter an Integer");
            try
            {
                while(!int.TryParse(Console.ReadLine(), out userInput))
                    Console.WriteLine("Invalid Input. Try Again");

                if(userInput%2 == 0)
                    Console.WriteLine("Your number is even");
                else
                    Console.WriteLine("Your Number is odd");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }

            Console.WriteLine();
        }//end of Part2
        public static void Part3()
        {
            Console.WriteLine("Part 3");
            Console.WriteLine();

            int userInput;
            try
            {
                while(!int.TryParse(Console.ReadLine(), out userInput))
                    Console.WriteLine("Invalid Input. Try Again");
                if((userInput % 4 == 0 && userInput % 100 != 0)|| userInput % 400 == 0)
                    Console.WriteLine("This year is a leap year");
                else
                    Console.WriteLine("This year isn't a leap year");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"An Error has occred: {ex.Message}");
            }

            Console.WriteLine();
        }//end of Part3
    }//end of class
}//end of namespace
