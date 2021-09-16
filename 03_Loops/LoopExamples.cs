using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        //While for foreach do while
        [TestMethod]
        public void WhileLoops()
        {
            // while (condition) { Body of code that will be looped }

            int counter = 1;
            while (counter != 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            counter = 1;
            while (true)
            {
                Console.WriteLine(counter);
                if(counter == 7)
                {
                    Console.WriteLine("Goal Reached!");
                    break;
                }

                counter++;
            }

            Random rng = new Random();
            bool isRunning = true;
            int someCount;

            while (isRunning)
            {
                someCount = rng.Next(0, 21);

                if (someCount == 13 || someCount < 5)
                {
                    // Contines the loop without progressing in code
                    continue;
                }

                Console.WriteLine(someCount);

                if (someCount == 17)
                {
                    isRunning = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int targetNumber = 21;

            for (int i = 0; i < targetNumber; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "David", "Jordan", "Nate", "Anastacia", "Jeffrey" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Good Morning, {students[i]}");
            }

        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "David", "Jordan", "Nate", "Anastacia", "Jeffrey" };

            //1 foreach keyword
            //2 type of collection
            //3 name if the current iteration
            //4 in keyword seperate the individual item and the collection
            //5 collection being iterated through
            //6 body of code to loop through
            //1       //2      //3     //4  //5
            foreach(string studentName in students)
            {
                //6
                Console.WriteLine(studentName + ", is in class today.");
            }

            string myName = "Jordan Thomas Bowling";
            foreach (char letter in myName)
            {
                if(letter != ' ' && letter != 'a')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoop()
        {
            int counter = 0;

            do
            {
                Console.WriteLine("Ciao Bella " + counter);
                counter++;
            }
            while (counter < 5);
        }

        //goto keyword
        //Goes to specific line in code
    }
}
