using System;

namespace Topic_7___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();

            Random generator = new Random();

            string userChoice;
            int numRemoveChoice, numAddChoice, numOccurrenceChoice, numOccurrenceCount, numMode, numMaxCount, numCurrentCount;
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
                Console.WriteLine("7. Print largest number");
                Console.WriteLine("8. Print smallest number");
                Console.WriteLine("9. Print the sum of the numbers");
                Console.WriteLine("10. Print the average of the numbers");
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

                    if (numList.Remove(numRemoveChoice))
                    {
                        Console.WriteLine("Removing all occurrences of the number " + numRemoveChoice + " from the list");
                        while (numList.Remove(numRemoveChoice))
                        {
                            numList.Remove(numRemoveChoice);
                        }
                    }
                    else if (!numList.Remove(numRemoveChoice))
                        Console.WriteLine("Failed to remove number as " + numRemoveChoice + " does not exist anywhere in the list.");

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
                else if(userChoice == "5" || userChoice.ToLower() == "add number")
                {
                    Console.WriteLine("Pick a number do you want to add to the list: ");
                    while (!Int32.TryParse(Console.ReadLine(), out numAddChoice))
                        Console.WriteLine("That's not a valid integer, please try again...");

                    Console.WriteLine();

                    numList.Add(numAddChoice);

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
                else if (userChoice == "6" || userChoice.ToLower() == "count occurrences")
                {
                    numOccurrenceCount = 0;

                    Console.WriteLine("Pick a number to count how many times it shows up in the list: ");
                    while (!Int32.TryParse(Console.ReadLine(), out numOccurrenceChoice))
                        Console.WriteLine("Invalid input, please try again...");

                    Console.WriteLine();

                    for (int i = 0; i <= numList.Count() - 1; i++)
                    {
                        if (numList[i] == numOccurrenceChoice)
                        {
                            numOccurrenceCount++;
                        }
                    }

                    Console.WriteLine();

                    Console.WriteLine("The number " + numOccurrenceChoice + " shows up in the list " + numOccurrenceCount + " times!");

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
                else if (userChoice == "7" || userChoice.ToLower() == "print largest number")
                {
                    numList.Sort();

                    Console.WriteLine("The largest number in the list is " + numList[numList.Count() - 1] + "!");

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
                else if (userChoice == "8" || userChoice.ToLower() == "print smallest number")
                {
                    numList.Sort();

                    Console.WriteLine("The smallest number in the list is " + numList[0] + "!");

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
                else if (userChoice == "9" || userChoice.ToLower() == "sum of numbers")
                {
                    Console.WriteLine("The sum is " + numList.Sum() + "!");

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
                else if (userChoice == "10" || userChoice.ToLower() == "average of numbers")
                {
                    Console.WriteLine("The average is " + numList.Average() + "!");

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
                else if (userChoice == "11" || userChoice.ToLower() == "most frequent value")
                {
                    numList.Sort();
                    numMode = 0;
                    numMaxCount = 0;
                    numCurrentCount = 0;

                    Console.WriteLine("Finding the most frequent value...");
                    for (int i = 0; i <= numList.Count() - 1; i++)
                    {
                        if (numList[i] == numList[i - 1])
                        {
                            numCurrentCount++;
                        }
                        else
                        {
                            if (numCurrentCount > numMaxCount)
                            {
                                numMaxCount = numCurrentCount;
                                numMode = numList[i - 1];
                            }
                            numCurrentCount = 0;
                        }
                    }

                    Console.WriteLine();

                    Console.WriteLine("The mode is " + numMode + "!");

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
