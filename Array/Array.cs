using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems.Array
{
    internal static class ArrayClass
    {

        public static int[] Data { get; set; }


        public static void Insert(int item, int index)
        {
            if (index > Data.Length - 1)
            {
                Console.WriteLine("Can not be inseterd");
                return;
            }

            Data[index] = item;
            Console.WriteLine(string.Join(",", Data));
        }



        public static void Search(int item)
        {
            for (int i = 0; i < Data.Length; i++)
            {
                if (Data[i] == item)
                {
                    Console.WriteLine("Element found");
                    return;
                }
            }

            Console.WriteLine("Element Not found");


        }




        public static void Delete(int item)
        {
            for (int i = 0; i < Data.Length; i++)
            {
                if (Data[i] == item)
                {
                    for (int j = i; j < Data.Length - 1; j++)
                    {
                        Data[j] = Data[j + 1];
                    }
                    Console.WriteLine(string.Join(",", Data));
                    return;
                }
            }
            Console.WriteLine("Element is not found to delete");


        }
    }
}
