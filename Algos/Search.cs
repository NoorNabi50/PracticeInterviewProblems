using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems.Algos
{
    internal class Search
    {

        public void LinearSearch(int[] array, int elementToFind)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elementToFind)
                {
                    Console.WriteLine($"Element {elementToFind} Found at Index {i} ");
                    return;
                }
            }
            Console.WriteLine($"Element {elementToFind} Not Found");
        }

        public void BinarySearch(int[] array, int elementToFind)
        {
            int left = 0;
            int right = array.Length - 1;
            int middleIndex = 0;
            while (left <= right)
            {
                middleIndex = left + (left - right) / 2;
                if (array[middleIndex] == elementToFind)
                {
                    Console.WriteLine($"Element {elementToFind} Found at Index {middleIndex} ");
                    return;
                }
                else if (array[middleIndex] < elementToFind)
                {
                    left = middleIndex + 1;
                }
                else
                    right = middleIndex - 1;
            }

        }

        public void FindFirstandLastOccuranceUsingLinearSearch(int[] array, int elementToFind)
        {
            int[] result = new int[] { -1, -1 };
            //starting searching element's first and last occurance
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elementToFind)
                {
                    if (result[0] == -1)
                    {
                        result[0] = i;
                    }
                    else { result[1] = i; }
                }
            }

            if (result[0] != -1 && result[1] != -1)
            {
                Console.WriteLine($"Element found at {result[0]} and {result[1]}");
            }
            else if (result[0] != -1)
            {
                Console.WriteLine($"Element Only found at {result[0]}");
            }
            else
            {
                Console.WriteLine("Element Not Found in Array at any position");
            }
        }


    }
}
