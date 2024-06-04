﻿using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
            2) The list increase capacity once the final element in the array has been written to.

            3) I observed that it will increase by 4 two times and then it doubled that to 8 for each increase.
            So i assume its exponential growth.

            4) Its expensive to resize the list, because it has to create a new array and copy the elements over
            for each size increase.

            5) No, a list will retain its size when elements are removed

            6) When you know the how large of an array you need beforehand, it can be advantages to use a an array with
            specific size so as to avoid re-allocating the array and unnecessary memory overhead.
            */

            var theList = new List<string>();

            Console.Clear();

            Console.WriteLine("\nList initalized");
            Console.WriteLine($"Capacity: {theList.Capacity} Count: {theList.Count}\n");

            var running = true;
            while(running)
            {
                Console.WriteLine("\nPlease enter some input!");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                var capacityBefore = theList.Capacity;
                var countBefore = theList.Count;

                char op = input[0];
                string value = input.Substring(1);

                switch (op)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    case '0':
                    case 'e':
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please use only \"+\" or \"-\" as an operator");
                        Console.WriteLine("If you want to return to the main menu, please enter \"0\"");
                        continue;
                }

                if (!running) break;

                var capacityAfter = theList.Capacity;
                var countAfter = theList.Count;

                Console.Write("\n");

                if (GetChangeAmount(capacityBefore, capacityAfter, out int capacityChange))
                    Console.WriteLine($"Capacity {(capacityChange > 0 ? "decreased" : "increased")} by {(capacityChange < 0 ? -1 : 1) * capacityChange}");
                else 
                    Console.WriteLine("Capacity did not change");

                if (GetChangeAmount(countBefore, countAfter, out int countChange))
                    Console.WriteLine($"Count {(countChange > 0 ? "decreased" : "increased")} by {(countChange < 0 ? -1 : 1) * countChange}");
                else
                    Console.WriteLine("Count did not change");


            }

            Console.WriteLine("\n\nFinal list size");
            Console.WriteLine($"Capacity: {theList.Capacity} Count: {theList.Count}");

            Console.WriteLine("\nPress any key to return to main menu...");
            Console.ReadKey();
        }

        private static bool GetChangeAmount(int value1, int value2, out int change)
        {
            change = value1 - value2;
            return change != 0;
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

