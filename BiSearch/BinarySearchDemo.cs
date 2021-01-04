using System;

namespace BiSearch
{

    /*
     * Binary Sear Demo
     * 1/4/2020
     * Example of a Binary Search for integers, does the same
     * thing as the built in function.
     */
    class BinarySearchDemo
    {
        static void Main(string[] args)
        {
            

            int[] demoArray = { 1, 2, 4, 8, 16, 32, 64, 128, 256 };

            //Array.Sort(demoArray);
            foreach (int x in demoArray) Console.Write("{0} ", x);
            Console.WriteLine("\nRUN SEARCH");
            Console.WriteLine(BinarySearch(demoArray, 8));

            
        }

        private static int BinarySearch(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
