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

            var nums = new List<int>() { 2, 2, 3, 4, 2, 2, 2 };
            Console.WriteLine($"The product of integers in the list nums is {MultiplyListRecursive(nums, 0, nums.Count - 1)}.");

            //possible sizes list contained 7, 3, 1, and your roomSize was 25
            var boxes = new List<int>();
            var possibleSizes = new List<int>() { 7, 3, 1 };
            FillRoomWithBoxes(25, possibleSizes, boxes, 0);

            Console.WriteLine($"The boxes are: {boxes[0]}, {boxes[1]}, {boxes[2]}, {boxes[3]}, {boxes[4]}");
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

        // O(n/2) => O(n) time | O(1) space
        static int MultiplyList(List<int> nums)
        {
            int left = 0, right = nums.Count - 1, product = 1;

            while (left <= right)
            {
                Console.WriteLine($"left: {nums[left]}, right: {nums[right]} ");
                if (left < right)
                {
                    product *= nums[left];
                    left++;
                }

                if (right >= left)
                {
                    product *= nums[right];
                    right--;
                }
            }

            return product;
        }

        // O(n/2) => O(n) time | O(n/2) => O(n) space
        static int MultiplyListRecursive(List<int> nums, int first, int last)
        {
            // base case
            if (first > last) return 1;

            int firstNum, lastNum;

            if (first < last) firstNum = nums[first];
            else firstNum = 1;

            if (last >= first) lastNum = nums[last];
            else lastNum = 1;

            // recursive case
            return firstNum * lastNum * MultiplyListRecursive(nums, ++first, --last);
        }

        // Greedy
        // Write a function called FillRoomWithBoxes that takes in an int called roomSize, a List<int> called possibleSizes, and a List<int> called boxes.
        // The possibleSizes list should contain all possible box sizes.You can assume this list is sorted in descending order.
        // The function should implement a greedy recursive algorithm to fill the room as full as it can get with the least number of boxes, and should store the size of each box used in the boxes list, one entry per box
        // For example, if your possible sizes list contained 7, 3, 1, and your roomSize was 25, the boxes list should contain 7, 7, 7, 3, 1 when your function exits
        // Write a unit test and test this function

        static void FillRoomWithBoxes(int roomSize, List<int> possibleSizes, List<int> boxes, int indexCurrentSize)
        {
            // base case
            if (possibleSizes[possibleSizes.Count - 1] > roomSize ) return;

            // base case
            if (indexCurrentSize > possibleSizes.Count - 1) return;

            // recursive case
            if (possibleSizes[indexCurrentSize] <= roomSize)
            {
                boxes.Add(possibleSizes[indexCurrentSize]);
                FillRoomWithBoxes(roomSize - possibleSizes[indexCurrentSize], possibleSizes, boxes, indexCurrentSize);
            }

            // recursive case
            if (possibleSizes[indexCurrentSize] > roomSize)
            {
                FillRoomWithBoxes(roomSize, possibleSizes, boxes, ++indexCurrentSize);
            }
        }
    }
}
