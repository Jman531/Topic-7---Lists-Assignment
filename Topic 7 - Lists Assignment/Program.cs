namespace Topic_7___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();

            Random generator = new Random();

            string userChoice, removeAmountChoice;
            int numRemoveChoice;
            bool done = false;

            Console.WriteLine("Generating a list of numbers...");
            for (int i = 1; i <= 25; i++)
            {
                numList.Add(generator.Next(1, 26));
                Console.Write(numList[i - 1] + ", ");
            }

            Console.WriteLine();

            Console.WriteLine();

            while (!done)
            {
                Console.WriteLine("What do you want to do with the number list:");

                Console.WriteLine();

                Console.WriteLine("1. Print out list");
                Console.WriteLine("2. Sort the list");
                Console.WriteLine("3. Create new list");
                Console.WriteLine("4. Remove number");
                Console.WriteLine("5. Add a number to the list");
                Console.WriteLine("6. Count the number of occurrrnces of a specified number");
                Console.WriteLine("7. Print the largest number");
                Console.WriteLine("8. Print the smallest number");
                Console.WriteLine("9. Print the sum of all the numbers");
                Console.WriteLine("10. Print the average of all the numbers");
                Console.WriteLine("11. Determine the most frequently occurring value");
                Console.WriteLine("12. Quit");
                userChoice = Console.ReadLine();

                Console.WriteLine();

                if (userChoice == "1" || userChoice.ToLower() == "print out list")
                {
                    Console.WriteLine("Printing the list...");
                    for (int i = 0; i <= numList.Count() - 1; i++)
                    {
                        Console.Write(numList[i] + ", ");
                    }

                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
                else if (userChoice == "2" || userChoice.ToLower() == "sort the list")
                {
                    Console.WriteLine("Sorting the list...");

                    numList.Sort();

                    Console.WriteLine();

                    Console.WriteLine("List has been sorted... Printing the list...");
                    for (int i = 0; i <= numList.Count() - 1; i++)
                    {
                        Console.Write(numList[i] + ", ");
                    }

                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
                else if (userChoice == "3" || userChoice.ToLower() == "create new list")
                {
                    Console.WriteLine("Creating a new list...");

                    numList.Clear();

                    for (int i = 1; i <= 25; i++)
                    {
                        numList.Add(generator.Next(1, 26));
                        Console.Write(numList[i - 1] + ", ");
                    }

                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
                else if (userChoice == "4" || userChoice.ToLower() == "remove number")
                {
                    Console.WriteLine("Choose a number to remove from the list: ");
                    while (!Int32.TryParse(Console.ReadLine(), out numRemoveChoice))
                        Console.WriteLine("That's not a valid number, please try again...");

                    Console.WriteLine();

                    Console.WriteLine("Do you want to remove ALL occurrences of that number or just one occurrence of that number?");
                    removeAmountChoice = Console.ReadLine();

                    if (removeAmountChoice.ToLower() == "all" || removeAmountChoice.ToLower() == "remove all")
                    {
                        Console.WriteLine("Got it! Removing all occurrences of " + numRemoveChoice + " from the list...");
                        while (!numList.Remove(numRemoveChoice))
                        {
                            numList.Remove(numRemoveChoice);
                        }
                    }
                    else if (numList.Remove(numRemoveChoice))
                        Console.WriteLine("Got it! Removing one occurrence of " + numRemoveChoice + " from the list...");
                    else
                        Console.WriteLine("Failed top remove number as " + numRemoveChoice + " does not exist anywhere in the list.");

                    Console.WriteLine();

                    Console.WriteLine("Printing the list...");
                    for (int i = 0; i <= numList.Count() - 1; i++)
                    {
                        Console.Write(numList[i] + ", ");
                    }

                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
            }
        }
    }
}
