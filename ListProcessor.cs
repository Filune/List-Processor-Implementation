using System;
using System.Collections.Generic;

namespace List_Processor
{
    /// <summary>
    /// Author: Filune
    /// Original java version: 2020-11-20
    /// C# version: 2021-10-11
    /// </summary>
    class ListProcessor
    {
        /// <summary>
        /// Takes two numbers and creates a sorted array from them.
        /// </summary>
        /// <param name="from">First number in array</param>
        /// <param name="to">Last number in array</param>
        /// <returns>array</returns>
        public int[] arraySequence(int from, int to)
        {
            int[] array = new int[to];

            if (to > from)
            {
                for (int i = from; i < array.Length; i++)
                {
                    array[i] = i;
                }
            }
            else if (to == from)
            {
                Console.WriteLine("{}");
                return new int[0];
            }
            else if (to < from)
            {
                throw new ArgumentException();
            }

            return array;
        }

        /// <summary>
        /// Takes two numbers and creates an integer list from them.
        /// </summary>
        /// <param name="from">First number in list</param>
        /// <param name="to">Last number in list</param>
        /// <returns>list</returns>
        public List<int> listSequence(int from, int to)
        {
            List<int> list = new List<int>();

            if (to > from)
            {
                for (int i = from; i < to; i++)
                {
                    list.Add (i);
                }
            }
            else if (to == from)
            {
                Console.WriteLine("[]");
                return new List<int>();
            }
            else if (to < from)
            {
                throw new ArgumentException();
            }
            return list;
        }

        /// <summary>
        /// Shuffles input array and returns.
        /// </summary>
        /// <param name="numbers">Input array to be shuffled</param>
        /// <returns>array</returns>
        public int[] shuffled(int[] numbers)
        {
            int[] array = numbers;
            Random rnd = new Random();
            int index = 0;
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                index = rnd.Next(array.Length - 1);
                temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
            return array;
        }

        /// <summary>
        /// Shuffles input integer list.
        /// </summary>
        /// <param name="numbers">Input list to be shuffled</param>
        /// <returns>list</returns>
        public List<int> shuffled(List<int> numbers)
        {
            List<int> list = numbers;
            Random rnd = new Random();
            int index = 0;
            int temp;

            for (int i = 0; i < list.Count; i++)
            {
                index = rnd.Next(list.Count - 1);
                temp = list[i];
                list[i] = list[index];
                list[index] = temp;
            }
            return list;
        }

        /// <summary>
        /// Takes an array and sums it iteratively.
        /// </summary>
        /// <param name="numbers">Array to be summed</param>
        /// <returns>sumResult</returns>
        public int sumIterative(int[] numbers)
        {
            int[] array = numbers;
            int sumResult = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sumResult += array[i];
            }
            return sumResult;
        }

        /// <summary>
        /// Takes an integer list and sums it iteratively.
        /// </summary>
        /// <param name="numbers">List to be summed</param>
        /// <returns>sumResult</returns>
        public int sumIterative(List<int> numbers)
        {
            List<int> list = numbers;
            int sumResult = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sumResult += list[i];
            }
            return sumResult;
        }

        /// <summary>
        /// Takes an array and sums it recursively.
        /// </summary>
        /// <param name="numbers">Array to be summed</param>
        /// <returns>sumRecursiveHelper()</returns>
        public int sumRecursive(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            return sumRecursiveHelper(numbers, numbers.Length - 1);
        }

        /// <summary>
        /// Helper for recursive array summation.
        /// </summary>
        /// <param name="numbers">Array to be summed</param>
        /// <param name="n">Length of array minus one</param>
        /// <returns>Value of nth index</returns>
        public int sumRecursiveHelper(int[] numbers, int n)
        {
            if (n < 1)
            {
                return numbers[n];
            }
            return numbers[n] + sumRecursiveHelper(numbers, n - 1);
        }

        /// <summary>
        /// Takes a list and sums it recursively.
        /// </summary>
        /// <param name="numbers">Integer list to be summed</param>
        /// <returns>sumRecursiveHelper()</returns>
        public int sumRecursive(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return 0;
            }

            int result = sumRecursiveHelper(numbers, numbers.Count - 1);
            return result;
        }

        /// <summary>
        /// Helper for recursive sum of integer list.
        /// </summary>
        /// <param name="numbers">Integer list to be summed</param>
        /// <param name="n">Length of list minus one</param>
        /// <returns>Value of nth index</returns>
        public int sumRecursiveHelper(List<int> numbers, int n)
        {
            if (n < 1)
            {
                return numbers[n];
            }
            return numbers[n] + sumRecursiveHelper(numbers, n - 1);
        }
    }
}
