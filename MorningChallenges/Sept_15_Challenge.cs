using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallenges
{
    [TestClass]
    public class Sept_15_Challenge
    {
        [TestMethod]
        public void BigWordChallenge()
        {
            
            string bigWord = "Supercalifragilisticexpialidocious";
            
            foreach (char letter in bigWord)
            {
                Console.WriteLine(letter);
            }
            
            foreach (char letter in bigWord)
            {
                if (letter != 'i' && letter != 'l')
                {
                    Console.WriteLine("Not an i");
                }
                else
                {
                    Console.WriteLine(letter);
                }
            }

            Console.WriteLine(bigWord.Length);
        }
    }
}
