using System;
using System.Collections.Generic;

namespace CapStone2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            List<Task_List> tasks = new List<Task_List>
        {
            new Task_List("Jack", "Does the work", DateTime.Parse("10/25/2019")),
            new Task_List("Tristian","Stares", DateTime.Parse("10/10/2019")),
            new Task_List("Steve", "Is Funny", DateTime.Parse("10/03/2019")),
        };



            PrintOptions();
            int userInput = ValidateRange("Please choose on of the 5 options above using 1-5: ",0,5);
            Console.WriteLine(Task_List.AddTask());

            

        }


        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
                return Console.ReadLine();
        }
        public static void PrintOptions()
        {
            Console.WriteLine("1.List tasks");
            Console.WriteLine("2.Add task");
            Console.WriteLine("3.Delete task");
            Console.WriteLine("4.Mark task complete");
            Console.WriteLine("5.Quit");


        }

        public static int ParseInput(string message)
        {
            try
            {
                string input = GetUserInput(message);
                int number = int.Parse(input);
                return number;
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Not in the correct format");
                return ParseInput(message);
            }
            catch
            {
                return ParseInput(message);
            }
        }
        public static int ValidateRange(string message, int min, int max) // used this instead of a try catch
        {
            int number = ParseInput(message);
            if (number > min && number <= max)
            {
                return number;

            }
            else
            {
                return ValidateRange(message, min, max);
            }

        }
    }
}
