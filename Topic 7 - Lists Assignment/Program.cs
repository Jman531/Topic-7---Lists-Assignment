using System;

namespace Topic_7___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            List<int> numModeList = new List<int>();
            List<string> vegetables = new List<string>() {"CARROT", "BEET", "CELERY", "RADISH", "CABBAGE" };

            Random generator = new Random();

            string userChoice, vegetableRemove, vegetableSearch, vegetableAdd;
            int numRemoveChoice, numAddChoice, numOccurrenceChoice, numOccurrenceCount, numMaxCount, numCurrentCount, indexRemove;
            bool done = false, sameAsList = false;

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
                else if (userChoice == "5" || userChoice.ToLower() == "add number")
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
                    numMaxCount = 0;
                    numCurrentCount = 1;

                    Console.WriteLine("Finding the most frequent value...");
                    for (int i = 1; i <= numList.Count() - 1; i++)
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
                                numModeList.Clear();
                                numModeList.Add(numList[i - 1]);
                            }
                            else if (numCurrentCount == numMaxCount)
                            {
                                numModeList.Add(numList[i - 1]);
                            }
                            numCurrentCount = 1;
                        }
                    }

                    Console.WriteLine();

                    Console.Write("The mode is ");
                    for (int i = 0; i <= numModeList.Count() - 1; i++)
                    {
                        Console.Write(numModeList[i] + ", ");
                    }
                    Console.WriteLine();

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
                else if (userChoice == "12" || userChoice.ToLower() == "quit")
                {
                    Console.WriteLine("Quitting the program now...");

                    Thread.Sleep(500);

                    Console.Clear();

                    done = true;
                }
                else
                {
                    Console.WriteLine("That's not an option, please enter a valid option");

                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
            }
            done = false;

            while (!done)
            {
                Console.WriteLine("Here is a list of vegetables:");

                Console.WriteLine();

                for (int i = 0; i <= vegetables.Count() - 1; i++)
                {
                    Console.WriteLine((i + 1) + ". " + vegetables[i]);
                }

                Console.WriteLine();

                Console.WriteLine("What do you want to do:");

                Console.WriteLine();

                Console.WriteLine("1. Remove a vegetable by index");
                Console.WriteLine("2. Remove a vegetable by value");
                Console.WriteLine("3. Search for a vegetable");
                Console.WriteLine("4. Add a vegetable");
                Console.WriteLine("5. Sort the list");
                Console.WriteLine("6. Clear the list");
                Console.WriteLine("7. Quit");
                userChoice = Console.ReadLine();

                Console.WriteLine();

                if (userChoice == "1" || userChoice.ToLower() == "remove vegetable by index")
                {
                    Console.WriteLine("Please enter the index of the vegetable you want to remove: ");
                    while (!Int32.TryParse(Console.ReadLine(), out indexRemove))
                        Console.WriteLine("That is not a valid number, please try again");

                    Console.WriteLine();

                    if (indexRemove > (vegetables.Count() - 1))
                    {
                        Console.WriteLine("Cannot remove item from list as the index value you gave is bigger than the list...");
                    }
                    else if (indexRemove < 0)
                    {
                        Console.WriteLine("Cannot remove item from list as the index value you gave is less than zero...");
                    }
                    else
                    {
                        Console.WriteLine("Successfully removed " + vegetables[indexRemove] + " from the list!");

                        vegetables.RemoveAt(indexRemove);
                    }
                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
                else if (userChoice == "2" || userChoice.ToLower() == "remove vegetable by value")
                {
                    Console.WriteLine("Pick an item from the list to remove:");
                    vegetableRemove = Console.ReadLine();

                    Console.WriteLine();

                    if (vegetables.Remove(vegetableRemove))
                    {
                        Console.WriteLine("Successfully removed " + vegetableRemove.ToUpper() + " from the list!");
                    }
                    else if (!vegetables.Remove(vegetableRemove))
                    {
                        Console.WriteLine("Failed to remove " + vegetableRemove.ToUpper() + " from the list as it isn't part of the list");
                    }
                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
                else if (userChoice == "3" || userChoice.ToLower() == "search for vegetable")
                {
                    Console.WriteLine("What vegetable do you want to search for in the list: ");
                    vegetableSearch = Console.ReadLine();

                    Console.WriteLine();

                    for (int i = 0; i <= vegetables.Count() - 1; i++)
                    {
                        if (vegetableSearch == vegetables[i])
                        {
                            Console.WriteLine("The index of the vegetable " + vegetables[i] + " is " + i + "!");
                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
                else if (userChoice == "4" || userChoice.ToLower() == "add vegetable")
                {
                    Console.WriteLine("What vegetable do you want to add to the list: ");
                    vegetableAdd = Console.ReadLine();

                    Console.WriteLine();

                    vegetableAdd = vegetableAdd.ToUpper();

                    sameAsList = false;

                    for (int i = 0; i <= vegetables.Count() - 1; i++)
                    {
                        if (vegetableAdd == vegetables[i])
                        {
                            Console.WriteLine("You cannot add a vegetable that's already in the list...");
                            sameAsList = true;
                        }
                    }
                    if (!sameAsList)
                    {
                        Console.WriteLine("Successfully added " + vegetableAdd + " to the list!");

                        vegetables.Add(vegetableAdd);
                    }
                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
                else if (userChoice == "5" || userChoice.ToLower() == "sort list")
                {
                    vegetables.Sort();

                    Console.WriteLine("List sorted!");

                    Thread.Sleep(500);

                    Console.Clear();
                }
                else if (userChoice == "6" || userChoice.ToLower() == "clear list")
                {
                    vegetables.Clear();

                    Console.WriteLine("List cleared!");

                    Thread.Sleep(500);

                    Console.Clear();
                }
                else if (userChoice == "7" || userChoice.ToLower() == "quit")
                {
                    Console.WriteLine("Quitting the program now...");

                    Thread.Sleep(500);

                    Console.Clear();

                    done = true;
                }
                else
                {
                    Console.WriteLine("That's not an option, please enter a valid option");

                    Console.WriteLine();

                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                    Console.Clear();
                }
            }
        }
    }
}
