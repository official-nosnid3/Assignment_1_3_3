using System.Runtime.InteropServices;

namespace Assignment_1_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 1.3.3
             * Write a program in C# to read n number of values in an array and display it in reverse order.
             * Test Data :
             * Input the number of elements to store in the array :3
             * Input 3 number of elements in the array :
             * element - 0 : 2
             * element - 1 : 5
             * element - 2 : 7
             * Expected Output:
             * The values store into the array are:
             * 2 5 7
             * The values store into the array in reverse are :
             * 7 5 2 
             */

            int[] myNumberArray = new int[5] { 1, 2, 3, 4, 5 };

            string values = "";
            foreach (int number in myNumberArray)
                values += number + " ";

            Console.WriteLine($"The values store into the array are:\n{values}");

            // Reversed
            ReverseArray(myNumberArray);
            string reversedValues = "";
            foreach (int number in myNumberArray)
                reversedValues += number + " ";

            Console.WriteLine($"\nThe values store into the array in reverse are:\n{reversedValues}");
        }

        static void ReverseArray(int[] array)
        {
            /* This code will swap the first value in the array with the last value
             * then it will swap the second with the second to last, and so on.
             * 
             * Before losing the original value of the first value in the array
             * we store it in a temporary variable.
             */

            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                int temp = array[start];

                // swap
                array[start] = array[end];
                array[end] = temp;

                start++; end--;
            }
        }
    }
}
