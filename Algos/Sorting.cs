using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems.Algos
{
    internal class Sorting
    {
        private int[] Data { get; set; } = new int[] { 7, 8, 3, 2, 1 };

        //Time complexity = O(n ^ 2)
        public void BubbleSort()
        {
            for (int i = 0; i < Data.Length - 1; i++)
            {
                for (int j = 0; j < Data.Length - i - 1; j++)
                {
                    if (Data[j] > Data[j + 1]) // check if number is greater than its next number
                    {
                        //swap elements
                        Data[j] = Data[j] + Data[j + 1];
                        Data[j + 1] = Data[j] - Data[j + 1];
                        Data[j] = Data[j] - Data[j + 1];
                    }
                }
            }
            PrintArray();
        }

        public void SelectionSort()
        {
            // O(n^2)
            for (int i = 0; i < Data.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < Data.Length; j++)
                {
                    if (Data[smallest] > Data[j + 1]) // check if number is greater than its next number
                        smallest = j; ;
                }

                //swap
                Data[i] = Data[i] + Data[smallest];
                Data[smallest] = Data[i] - Data[smallest];
                Data[i] = Data[i] - Data[smallest];
            }
            PrintArray();
        }


        public void InsertionSort()
        {

        }


        public void PrintArray()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item);
            }
        }


    }
}
