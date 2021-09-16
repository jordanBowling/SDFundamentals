using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Conditionals
{
    [TestClass]
    public class Switch
    {
        enum PastryType { Eclair, Croissant, PetitFour, Cake, Cupcake }

        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Goodbye");
                    break;
                case 22:
                    Console.WriteLine("You skipped a few options");
                    break;
                default:
                    Console.WriteLine("You didn't pick any of my numbers");
                    break;
            }

            PastryType pastry = PastryType.Cake;

            switch (pastry)
            {
                case PastryType.Cake:
                    Console.WriteLine("That is $30");
                    break;

                case PastryType.Croissant:
                case PastryType.Eclair:
                case PastryType.Cupcake:
                    Console.WriteLine("That is $4");
                    break;

            }
        }
    }
}
