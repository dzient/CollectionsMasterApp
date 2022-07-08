using System;
using System.Collections.Generic;

//-----------------------------------------------------------------
//ArraysAndLists
//
// Name: David Zientara
// Date: 7-8-2022
// Comments: An exercise in arrays and lists, part two
// Added methods per the instructions
//-----------------------------------------------------------------

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
           
            int[] ar = new int[50];
            
            ar.L

            Populater(ar);
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50


            //TODO: Print the first number of the array

            //TODO: Print the last number of the array            

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(ar);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            ar = ReverseArray(ar);

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            ThreeKiller(ar);
            Console.WriteLine("Multiple of three = 0: ");
            

            Console.WriteLine("-------------------");
            ar = SortArray(ar);
            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(ar);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> list = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"List size = {list.Count}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(list);

            //TODO: Print the new capacity
            Console.WriteLine($"New list size = {list.Count}");
           

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            string str;
            int x;
            do
            {
                str = Console.ReadLine();
            } while (!int.TryParse(str, out x));
            NumberChecker(list, x);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(list);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(list);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            list.Sort();
            NumberPrinter(list);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] array = list.ToArray();

            //TODO: Clear the list
            list.Clear();

            #endregion
        }
        //ThreeKiller
        //Given an array of integers, find all #s
        //divisible by three and set the array to zero
        //PARAMS: numbers (array of integers)
        //RETURNS: Nothing
        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                if ((numbers[i]%3) == 0)
                        numbers[i] = 0;
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine($"{numbers[i]}");
        }
        //OddKiller
        //Given a list of integers, find all odd
        //#s and delete from the array
        //PARAMS: numberList (List of integers)
        //RETURNS: Nothing
        private static void OddKiller(List<int> numberList)
        {
            //foreach (int n in numberList)
            int count = numberList.Count;
            //for (int i = 0; i < count; i++)
            int i = 0;
            while (i < count)
            {
                if ((numberList[i] % 2) != 0)
                {
                    numberList.Remove(numberList[i]);
                    count--;
                }
                else
                    i++; 
            }
        }
        //NumberChecker
        //Given a list of integers, search the list
        //and if the searchNumber is found, print it out
        //PARAMS: numberList (list of integers)
        //          searchnumber (int)
        //RETURNS: Nothing
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            foreach (int n in numberList)
                if (n == searchNumber)
                    Console.WriteLine($"Found {searchNumber}");
        }
        //Populater
        //Given an empty list of integers, fill the list
        //with 50 random #s
        //PARAMS: numberList (list of integers)
        //RETURNS: Nothing
        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            const int MAX = 50;
            for (int i = 0; i < MAX; i++)
                numberList.Add(rng.Next(0, 50));

            Console.WriteLine($"{numberList[0]}");
            Console.WriteLine($"{numberList[numberList.Count - 1]}");

        }
        //Populater
        //Given an empty array of integers, fill the list
        //with 50 random #s
        //PARAMS: numbers (array of integers)
        //RETURNS: Nothing
        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            const int MAX = 50;
            for (int i = 0; i < MAX; i++)
                numbers[i] = rng.Next(0, 50);

            Console.WriteLine($"{numbers[0]}");
            Console.WriteLine($"{numbers[numbers.Length - 1]}");

        }        
        //ReverseArray 
        //Given an array of integers, reverse it
        //PARAMS: array (array of integers)
        //RETURNS: The array, reversed
        private static int[] ReverseArray(int[] array)
        {
            //Make this a list
            List<int> list = new List<int>();
            
            for (int i = array.Length-1; i >= 0; i--)
                list.Add(array[i]);
            array = list.ToArray();
            return array;
        }
        //SortArray
        //Given an array of integers, sort it
        //PARAMS: array (array of integers)
        //RETURNS: The sorted array
        private static int[] SortArray(int[] array)
        {
            //Convert to a list because I can't 
            //think of another way to do this
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
                list.Add(array[i]);

            list.Sort();
            array = list.ToArray();
            return array;
        }

        


        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
