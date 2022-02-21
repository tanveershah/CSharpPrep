using System;

namespace AlgorithmsExcercisesNS
{
    class Algos
    {
        static void Main(string[] args)
        {
            bool returnedValue = IsFirstCharRepeated("HelloH");
            Console.WriteLine($"The returned value is {returnedValue}.");
            string returnedString = ReverseStringRecursion("tanveer");
            Console.WriteLine(returnedString);
        }

        // Brute force (linear search)
        // 1. Write a function called IsFirstCharRepeated that takes in a string and returns a bool.
        // 2. The function should return true if the first character is repeated anywhere else in the string
        // 3. Write a unit test and test this function.

        static bool IsFirstCharRepeated(string inputString)
        {
            var firstChar = inputString[0];

            for (int i = 1; i < inputString.Length; i++)
            {
                if (firstChar == inputString[i]) return true;
            }

            return false;
        }

        // Recursion

        // 1. Write a function called ReverseString that takes in a string and returns a string. The function should return the string passed in, but in reverse.The function should solve the problem using iteration.

        // 2. Write a unit test and test this function.

        // 3. Solve the same problem using recursion and test it again.

        static string ReverseString(string myString)
        {
            string reversedString = string.Empty;

            for (int i = myString.Length - 1; i >= 0; i--)
            {
                reversedString += myString[i];
            }

            return reversedString;
        }

        static string ReverseStringRecursion(string myString)
        {
            // base case
            if (myString.Length < 1) return "";

            // recursive case
            return myString[myString.Length - 1] + ReverseStringRecursion(myString.Substring(0, myString.Length - 1));
        }
    }
}
