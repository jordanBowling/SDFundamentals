using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // Decalring a variable
            bool isDeclared;

            // Initializing
            isDeclared = true;

            bool isDeclaredAndInitialized = true;

            isDeclaredAndInitialized = false;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            // 2 ^ 8
            byte byteExample = 255;
            sbyte sByteExample = -128;

            // 2 ^ 16
            short shortexample = 32767;
            Int16 anotherShortExample = -32768;

            // 2 ^ 32
            int intMax = 2147483647;
            Int32 intMin = -2147483648;
            uint inSignedInt = 2147483648;

            // 2 ^ 64
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.9238575f;
            double doubleExample = 1.9238575d; // you don't need the d on a double.
            double doubleNoD = 1.9238575;
            decimal deciamlExample = 881.6564516941964449m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(doubleNoD);
            Console.WriteLine(deciamlExample);
        }

        //Enum
        enum PastryTypes { Eclair, Croissant, PetitFour, Cake, Cupcake }
        [TestMethod]
        public void Enums()
        {
            PastryTypes myPastry = PastryTypes.Croissant;
            PastryTypes anotherOne = PastryTypes.Cake;
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.Today;

            DateTime specificDate = new DateTime(2021, 9, 14);

            DateTime todayTwo = today;

            var variable = today;
            // var will designate the input type based on what is to the right of the equal sign
           
        }
    }
}
