using System;

namespace Lab7_Class_List_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Class information Storage Center!\n");
            bool repeat = true;
            //declaring all the information in parallel strings
            string[] studentNames = { "Adam", "Ben", "Cam", "David", "Evan", "Frank", "Gary", "Hailey", "Ingred", "Jamie", "Kyle" };
            string[] colorFavorites = { "amber", "blue", "copper", "denim", "emerald", "fusia", "gold", "hot pink", "indigo", "jade", "khaki" };
            string[] favoritePlaces = { "Alaska", "Boston", "Colorado", "Delaware", "Egypt", "Florida", "Glasgow", "Hawaii", "India", "Jacksonville", "Kansas" };
            do
            {
                Console.WriteLine("Which person would you like to know more about?\n");
                int rosterChoice = -1;

                while (rosterChoice > 11 || rosterChoice < 1)
                {
                    rosterChoice = GetInt("Enter a number between (1-11): ");

                    if (rosterChoice > 11 || rosterChoice < 1)
                    {
                        Console.WriteLine("That student is not on the roster... ");
                    }
                }

                Console.WriteLine($"\nStudent {rosterChoice} is {studentNames[rosterChoice - 1]} would you like to know their favorite color or place? " +
                    $"(Enter \"Color\" or \"Place\")");

                bool correctChoice = false;
                while (!correctChoice)
                {
                    string answer = null;
                    answer = Console.ReadLine().ToLower();
                    if (answer == "color")
                    {
                        Console.WriteLine($"\n{studentNames[rosterChoice - 1]}'s favorite color is {colorFavorites[rosterChoice - 1]}. Would you like to know more about the class (Y or N)? ");
                        correctChoice = true;
                    }
                    else if (answer == "place")
                    {
                        Console.WriteLine($"\n{studentNames[rosterChoice - 1]}'s favorite place is {favoritePlaces[rosterChoice - 1]}. Would you like to know more about the class (Y or N)? ");
                        correctChoice = true;
                    }
                    else
                    {
                        Console.Write("This data does not exist... Please enter (Color or Place): ");
                    }
                }
                repeat = GetYesorNo();
            } while (repeat);
            Console.WriteLine("Thanks for trying my program!");
        }

        private static int GetInt(string prompt)
        {
            bool valid = false;
            int input = -1;

            while (!valid)
            {
                Console.Write(prompt);
                string integer = Console.ReadLine();
                valid = int.TryParse(integer, out input);
            }

            return input;
        }

        private static bool GetYesorNo()
        {
            bool valid = true;
            bool repeat = true;
            while (valid)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "y" || answer == "yes")
                {
                    valid = false;
                    repeat = true;
                }
                else if (answer == "n" || answer == "no")

                {
                    valid = false;
                    repeat = false;
                }
                else
                {
                    Console.Write("Did not enter a valid input. Please enter (y/n): ");
                }
            }

            return repeat;
        }
    }
}
