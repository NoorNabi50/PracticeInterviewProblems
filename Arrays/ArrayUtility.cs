using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems.Array
{
    internal  class ArrayUtility
    {

        public static int[] Data { get; set; }
        private int sum { get; set; } = 0;

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



        //find the max element of the array --for loop approach

        void FindMax(int[] marks)
        {
            int max = marks[0];

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }

            Console.WriteLine(max);
        }
        //find the min element of the array --for loop approach
        void FindMin(int[] marks)
        {
            int min = marks[0];

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < min)
                {
                    min = marks[i];
                }
            }

            Console.WriteLine(min);
        }

        //Delete an Element of array at the specified position

        // void RemoveElem(int[] array, int position=3)
        //{

        //    for (int i = position-1; i < array.Length; i++)
        //    {
        //        try
        //        {
        //            array[i] = array[i + 1];
        //        }
        //        catch(Exception)
        //        {
        //            break;
        //        }
        //    }

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}


        bool IsPalindrome(string name)
        {
            string Reversedstring = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Reversedstring += name[i];
            }
            return Reversedstring == name;
        }


        void InsertString(string T, int R, string P)
        {
            string temp1 = T.Substring(0, R - 1);

            string temp2 = T.Substring(R, T.Length - (R + 1));
            temp1 += P;
            temp1 += temp2;
            Console.WriteLine(temp1);
        }

        void PrintEvenNumbersReverse(int n = 1000)
        {
            if (n < 0)
                return;

            if (n % 2 == 0)
                Console.WriteLine(n);

            PrintEvenNumbersReverse(n - 1);
        }


        //Print fabonaci series -- loop approach
        void PrintFabonaciSeries(int numberofElements)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int Sum;
            Console.Write("{0} , {1}", firstNumber, secondNumber);

            for (int i = 2; i <= numberofElements; i++)
            {
                Sum = firstNumber + secondNumber;
                Console.Write(", {0}", Sum);
                firstNumber = secondNumber;
                secondNumber = Sum;
            }
        }

        //Print fabonaci series -- recursive approach
        void PrintFabonaciSeriesRecursive(int n, int a, int b)
        {
            if (n == 0)
                return;
            int sum = a + b;
            Console.Write(sum + " ");
            PrintFabonaciSeriesRecursive(n - 1, b, sum);
        }

        //Reverse the given array
        void ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            int c;
            //using swap with third variable
            //for(int i = 0; i< array.Length / 2; i++)
            //{
            //    c = array[start];
            //    array[start] = array[end];
            //    array[end] = c;
            //    start++;
            //    end--;
            //}

            //swaping without third variable

            for (int i = 0; i < array.Length / 2; i++)
            {
                array[start] += array[end];
                array[end] = array[start] - array[end];
                array[start] -= array[end];
                start++;
                end--;
            }

            Console.Write(string.Join(",", array));
        }


        void PassByReferenceParameters(int num1, int num2)
        {
            num1 = num1 + 5;
            num2 = num2 + 5;

        }

        //Print factorial of a given number - For Loop approach
        void PrintFactorial(int number)
        {
            ////using for loop
            // int sum = 1;
            //for(int i = 1; i <= number;  i++)
            //{
            //    sum *= i;
            //}
            //Console.WriteLine("Factorial of {0} = {1}", number, sum);


            // using Recursive

            if (number == 0)
            {
                Console.WriteLine("Factorial = {0} ", sum);
                return;
            }
            sum *= number;
            PrintFactorial(number - 1);
        }

        //Print sum of digits - For Loop approach
        void SumOfDigits(int number = 123)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.Write(sum);

        }

        //Print sum of digits - Recursive approach


        void SumofDigit(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Sum = {0}", sum);
                return;
            }
            sum += number % 10;
            SumofDigit(number / 10);
        }


        //Working of Try catch
        void TryCatchWork()
        {
            try
            {
                int number = 50;
                int a = number / 0;
            }

            catch (Exception e)
            {
                Console.WriteLine("I caught error {0}", e.ToString());
            }


            Console.WriteLine("check me ");
        }


        //  To check whether the given array is sorted increasingly      --    using for loop

        bool IsIncreasingsortedArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    continue;
                }
                else
                    return false;
            }

            return true;




        }

        // To check whether the given array is sorted increasingly  -- using Recursive 
        bool isIncreasinglySorted(int[] array, int indx)
        {
            if (indx == array.Length - 1)
                return true;

            if (array[indx] < array[indx + 1])
                return isIncreasinglySorted(array, indx + 1);

            else
                return false;
        }





        void DecimalToBinary(int number)
        {
            //store result in array
            int[] result = new int[15];
            int i = 0;
            while (number > 0)
            {
                result[i] = number % 2;
                number /= 2;
                i++;
            }

            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(result[i]);

            }
        }



        //Print the power of Number - recursive method
        void PowerOfN(int @base, int exponent, int result = 1)
        {
            //2^3 = 2 * 2 * 2

            if (exponent == 0)
            {
                Console.WriteLine(result);
                return;
            }

            PowerOfN(@base, exponent - 1, result * @base);
        }



        // Print Count of negative elements present in an array
        void CountNegativeElements(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    count++;

            }

            Console.WriteLine("Total Negative Elements : {0}", count);
        }


        ///<summary>
        /// Method to find the intersection of two arrays
        /// <param>arra1, arrr2</param>
        /// </summary>
        /// 

        public void FindIntersection(int[] arr1, int[] arr2)
        {
            ArrayList result = new ArrayList();
            int i = 0, j = 0;

            //need to sort both arrays before finding intersection

            ArrayList sortedArrays = sortArrays(new ArrayList() { arr1, arr2 });
            arr1 = (int[])sortedArrays[0];
            arr2 = (int[])sortedArrays[1];

            //Now finding intersection of two arrays

            for (; i < arr1.Length && j < arr2.Length;)
            {
                if (arr1[i] == arr2[j])
                {
                    result.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] < arr2[j])
                    i++;
                else
                    j++;
            }
            foreach (var item in result)
                Console.WriteLine(item.ToString());
        }

        private ArrayList sortArrays(ArrayList arrays)
        {
            ArrayList result = new();
            foreach (int[] array in arrays)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            array[i] = array[i] + array[j];
                            array[j] = array[i] - array[j];
                            array[i] = array[i] - array[j];
                        }
                    }
                }
                result.Add(array);
            }
            return result;
        }


    }
}
