using System;
using System.Collections.Generic;

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
            Console.WriteLine($"The product of 5 power 3 is {XToTheYPowerRecursive(5, 3)}.");

            var nums = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine($"The product of integers in the list nums is {MultiplyListRecursive(nums)}.");
        }

        // Brute force (linear search)
        // Write a function called IsFirstCharRepeated that takes in a string and returns a bool.
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

        // Write a function called XToTheYPower that takes in an int x and an int y, and returns int. The function should return x^y.Solve this using iteration, don’t use Math.Pow()
        // Write a unit test and test this function.
        // Solve the same problem using recursion and test it again.

        static int XToTheYPower(int x, int y)
        {
            int product = 1;

            for (int i = 0; i < y; i++)
            {
                product *= x;
            }

            return product;
        }

        static int XToTheYPowerRecursive(int x, int y)
        {
            // base case
            if (y == 0) return 1;

            // recursive case
            return x * XToTheYPowerRecursive(x, y - 1);
        }

        // Divide-and-conquer
        // Write a function called MultiplyList that takes in a List<int>.It should return the product of all numbers in the list. Solve this problem using iteration.
        // Write a unit test and test this function.
        // Solve the same problem using a recursive divide-and-conquer algorithm and test it again.

        static int MultiplyList(List<int> nums)
        {
            int product = 1;

            for (int i = 0; i < nums.Count; i++)
            {
                product *= nums[i];
            }

            return product;
        }

        static int MultiplyListRecursive(List<int> nums)
        {
            // base case
            if (nums.Count == 0) return 1;

            // obaining the current element and removing it from the list
            int currentElement = nums[0];
            nums.RemoveAt(0);

            // recursive case
            return currentElement * MultiplyListRecursive(nums);
        }
    }
}
