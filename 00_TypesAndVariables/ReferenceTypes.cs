using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            //Declaration
            string thisIsDeclartation;

            //Initialization
            thisIsDeclartation = "This is initialized!";

            string declarationAndInitialization = "This does both!";

            string singleLetter = "a";

            //String Manipulation
            string firstName = "Jordan";
            string lastName = "Bowling";

            //Concatenation
            string concatFullName = firstName + " " + lastName;
           
            //Composite Formatting
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            //Interpolation
            string interpolatedFullName = $"{firstName} {lastName}";

            Console.WriteLine(compositeFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collection()
        {
            // Arrays
            string stringExample = "Hello World!";
            
            string[] stringArray = { "Hello", "What", "Why", "When", stringExample };
            
            // This array will always have 3 places because we created it with three spaces. 
            string[] threeSpaces = new string[3];

            Console.WriteLine(stringArray[4]);

            stringArray[4] = "World";

            Console.WriteLine(stringArray[4]);

            // Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfNumbers = new List<int>();

            listOfStrings.Add("Hello");
            listOfStrings.Add("Two");

            Console.WriteLine(listOfStrings[0]);

            int a = 5;
            int b = a;

            a = 7;
            Console.WriteLine(a + " " + b);

            listOfNumbers.Add(a);
            listOfNumbers.Add(b);

            List<int> secondListOfNumbers = listOfNumbers;

            Console.WriteLine(listOfNumbers[0] + " " + secondListOfNumbers[0]);

            listOfNumbers[0] = 13;
            Console.WriteLine(listOfNumbers[0] + " " + secondListOfNumbers[0]);

            string firstName = "Jordan";
            string lastName = firstName;

            lastName = "Bowling";
            Console.WriteLine($"{firstName} {lastName}");

            //Queues
            //FirstInFirstOut
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm second");

            Console.WriteLine(firstInFirstOut.Dequeue());
            Console.WriteLine(firstInFirstOut.Dequeue());

            //Stacks
            //Last In First Out
            Stack<string> lIFO = new Stack<string>();
            lIFO.Push("I'm first");
            lIFO.Push("I'm second");

            Console.WriteLine(lIFO.Pop());
            Console.WriteLine(lIFO.Pop());

            //Dictionaries
            Dictionary<string, string> dictionaryExample = new Dictionary<string, string>();

            dictionaryExample.Add("Bee", "Pointy string ouchy");

            string bee = dictionaryExample["Bee"];
            Console.WriteLine(bee);

            Dictionary<int, string> numberDictionary = new Dictionary<int, string>();

            numberDictionary.Add(7, "Bond");

            Console.WriteLine(numberDictionary[7]);
            // int lists can hold negative ints

            //Linked List
            // Contains Value and pointer to next list item
            //HashSet
            // stores UNIQUE values (AKA is it has 7 stored cannot store 7 again

        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next(0, 10);

            Console.WriteLine(randomNumber);
            Console.WriteLine(randomNumber);
            Console.WriteLine(randomNumber);
            // Its the same number becasue it has already establisted what randomNumber = when you try to write it.
        }
    }
}
