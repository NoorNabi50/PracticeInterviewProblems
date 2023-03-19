using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PracticeInterviewProblems.StringProblems
{
    internal class StringUtility
    {


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
            System.Array.Sort(text1Array);
            System.Array.Sort(text2Array);

            return string.Join("", text1Array) == string.Join("", text2Array);

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

        /// <summary>
        /// Method to find the first non-repeating character in a string
        /// </summary>
        /// 
        public void FirstNonRepeatingChar(string s)
        {
            Dictionary<char, int> dict = new();
            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                    dict[c]++;
            }

            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine($"The first non repeating Char  = ${item.ToString()}");
                    break;
                }
            }
        }

        public void AlterCollectionByReference(List<string> names)
        {
            names.RemoveAt(0);
            names.Insert(0, "Modified Name");
        }
    }
}
