using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems
{
    internal class Problems
    {
           public  int sum = 1;
        #region Methods
        //find the maximum occurring character in given string
        void MaxCharacterInString(string param)
        {
            Dictionary<char, int> charVals = new Dictionary<char, int>();
            foreach (char c in param)
            {
                if (charVals.ContainsKey(c))
                {
                    charVals[c]++;
                }
                else
                {
                    charVals.Add(c, 1);
                }
            }
            //using LINQ method to calculate max character in the string
            string charcter = charVals.Aggregate((x, y) => x.Value > y.Value ? x : y).ToString();
            Console.WriteLine(charcter);


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

        //Print number of Vowels and Consonants in the string
         void CalculateVowelsConsonants(string text)
        {
            int Consonants = 0, Vowels = 0;
            char temp;
            for (int i = 0; i < text.Length; i++)
            {
                temp = text[i];
                if (temp == 'a' || temp == 'e' || temp == 'i' || temp == 'o' || temp == 'u')
                    Vowels++;
                else
                    Consonants++;
            }


            Console.Write("Voewls : {0} Consonants : {1} ", Vowels, Consonants);
        }

        //without using builtin functions
         bool IsAnagram(string text1, string text2)
        {
            if (text1.Length != text2.Length)
                return false;

            char[] text1Array = new char[text1.Length];
            char[] text2Array = new char[text1.Length];
            //store strings in two arrays
            for (int i = 0; i < text1.Length; i++)
            {
                text1Array[i] = text1[i];
                text2Array[i] = text2[i];
            }

            // sort both arrays
            Array.Sort(text1Array);
            Array.Sort(text2Array);
            return string.Join("", text1Array) == string.Join("", text2Array);

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

        //Print Occurence of character in the string
        void OccurenceOfCharacter(string text, char character)
        {
            int numberofOccurences = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (character == text[i])
                    numberofOccurences++;

            }

            Console.Write(numberofOccurences);
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


        //Move character to the end of string -- for loop approach

        void MovechartoEnd(string str, char target)
        {
            int count = 0;
            string newstr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == target)
                    count++;
                else
                    newstr += str[i];
            }

            for (int i = 0; i < count; i++)
            {
                newstr += target;
            }

            Console.WriteLine(newstr);

        }

        // Remove duplicate characters in a string 
         void RemoveDuplicates(string str)
        {
            StringBuilder newstr = new StringBuilder();
            //using the map of bool array  type
            //bool[] map = new bool[26]; // an array of bool type store false value in default


            //for(int i = 0; i < str.Length; i++)
            //{
            //    int mapindex = str[i] - 'a';
            //    if (map[mapindex] == false)
            //    {
            //        newstr.Append(str[i]);
            //        map[mapindex] = true;
            //    }


            // }

            //using the map of  dictionary type

            Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
            for (int i = 0; i < 26; i++)
                dictionary.Add(i, false);

            for (int i = 0; i < str.Length; i++)
            {
                int aa = str[i] - 'a';
                Console.WriteLine(aa);
                if (dictionary[str[i] - 'a'] == false)
                {
                    dictionary[str[i] - 'a'] = true;
                    newstr.Append(str[i]);
                }
            }

            Console.WriteLine(newstr);

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

        // Reverse the stringbuilder  
         void ReverseStringBuilder(StringBuilder str)
        {
            //H E L L O


            for (int i = 0; i < str.Length / 2; i++)
            {
                int end = str.Length - i - 1; // 5 - 0 -1 = 4, 5 - 1 - 2 = 4-2 = 2
                Console.WriteLine(i);
                char frontchar = str[i];
                char endchar = str[end];

                str[i] = endchar;
                str[end] = frontchar;
            }

            Console.WriteLine(str.ToString());
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


        //Find most repeated character in a string - loop and dictionary approach

         void MaxCharacterInstring(string s = "abccc")
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            //time complexity n + n =  2n O(N)
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                    map[s[i]]++;
                else
                    map.Add(s[i], 1);
            }

            int maxOccurance = 0;
            char Maxoccurchar = s[0];

            for (int i = 0; i < s.Length; i++) // to find max number in collections
            {
                if (map[s[i]] > maxOccurance)
                {
                    maxOccurance = map[s[i]];
                    Maxoccurchar = s[i];
                }
            }

            Console.WriteLine("Character : {0} Value : {1}", Maxoccurchar, maxOccurance);

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


        #endregion
    }
}
