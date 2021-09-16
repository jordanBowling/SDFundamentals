using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Classes
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddMethods()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Add(573, 892);
            Console.WriteLine(result);

            double sum = calculator.Add(6.5, 12.8);
            Console.WriteLine(sum);

            int age = calculator.CalculateAge(new DateTime(1990, 2, 20));
            Console.WriteLine(age);
        }
    }
}
