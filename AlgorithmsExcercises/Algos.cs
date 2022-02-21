using System;

namespace AlgorithmsExcercisesNS
{
    class Algos
    {
        static void Main(string[] args)
        {
            bool returnedValue = IsFirstCharRepeated("HelloH");
            Console.WriteLine($"Is first character is repeated in the input string? {returnedValue}.");
            string returnedString = ReverseStringRecursive("tanveer");
            Console.WriteLine($"The reversed of my name tanveer is: {returnedString}.");
            Console.WriteLine($"The sum of numbers between 5 and 10 (inclusive) is {GetSumBetweenNumbersRecursive(5, 10)}.");
        }

        // Brute force (linear search)
         //Write a function called IsFirstCharRepeated that takes in a string and returns a bool.
        // The function should return true if the first character is repeated anywhere else in the string
        // Write a unit test and test this function.

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

        // Write a function called ReverseString that takes in a string and returns a string. The function should return the string passed in, but in reverse.The function should solve the problem using iteration.

        // Write a unit test and test this function.

        // Solve the same problem using recursion and test it again.

        static string ReverseString(string myString)
        {
            string reversedString = string.Empty;

            for (int i = myString.Length - 1; i >= 0; i--)
            {
                reversedString += myString[i];
            }

            return reversedString;
        }

        static string ReverseStringRecursive(string myString)
        {
            // base case
            if (myString.Length < 1) return "";

            // recursive case
            return myString[myString.Length - 1] + ReverseStringRecursive(myString.Substring(0, myString.Length - 1));
        }

        // Write a function called GetSumBetweenNumbers that takes in an int min and an int max and returns an int. The function should get the sum of all the numbers between (and including) min and max. The function should solve the problem using iteration.

        // If min > max, the function should return 0

        // Write a unit test and test this function.

        // Solve the same problem using recursion and test it again.

        static int GetSumBetweenNumbers(int min, int max)
        {
            if (min > max) return 0;

            int sum = 0;

            for (int i = min; i <= max; i++)
            {
                sum += i;
            }

            return sum;
        }

        static int GetSumBetweenNumbersRecursive(int min, int max)
        {
            // base case
            if (min > max) return 0;

            // recursive case
            return max + GetSumBetweenNumbersRecursive(min, max - 1);
        }
    }
}
