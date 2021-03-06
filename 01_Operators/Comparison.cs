using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int year = 2021;
            string name = "Jordan";

            // Equal ==
            bool equal = year == 3000;
            bool isThisBob = name == "Bob";
            Console.WriteLine(equal);
            Console.WriteLine(isThisBob);

            //Inequality !=
            bool notEqual = year != 2021;
            bool isNotBob = name != "Bob";

            Console.WriteLine(notEqual);
            Console.WriteLine(isNotBob);

            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            //Stored values at different locations
            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            //Same Value
            bool listsItemsAreEqual = firstList[0] == secondList[0];
            Console.WriteLine(listsItemsAreEqual);

            //Greater
            bool isTwentyFirstCentury = year > 2000;

            //Less than
            bool isLessThan = year < 3000;

            //Greater or equal
            bool isGreaterThanOrEqual = year >= 2021;

            //Less or equal
            bool isLessThanOrEqual = year <= 1990;

            bool trueValue = true;
            bool falseValue = false;

            //Or ||
            bool tOrT = trueValue || trueValue;   // true
            bool tOrF = trueValue || falseValue;  // true
            bool fOrT = falseValue || trueValue;  // true
            bool fOrF = falseValue || falseValue; // false

            //And &&
            bool tAndT = trueValue && trueValue;    // true
            bool tAndF = trueValue && falseValue;   // false
            bool fAndT = falseValue && trueValue;   // false
            bool fAndF = falseValue && falseValue;  // false

        }
    }
}
