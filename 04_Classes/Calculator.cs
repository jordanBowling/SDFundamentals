using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes
{
    class Calculator
    {
        //Add
        //1 Access Modifier
        //2 return type
        //3 Method Name
        //4 Parameter
        //5 Method Body (Code method will run)
        //6 return keyword(what method sends back)

        //1   //2  //3   //4
        public int Add(int numOne, int numTwo)
        {
            //5
            int sum = numOne + numTwo;
            //6
            return sum;
        }

        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        //Subtract

        //Multiply

        //Divide

        //Remainder

        //Calculate Age
        public int CalculateAge(DateTime birthdate)
        {
            TimeSpan span = DateTime.Now - birthdate;
            double totalAgeDouble = span.Days / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeDouble));
            return years;

        }
    }
}
