using PracticeInterviewProblems.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeInterviewProblems
{


    internal class Program
    {
        public static int sum { get; set; } = 0;
        static void Main(string[] args)
        {
            #region PROBLEMS
            // MaxCharacterInString("NooorNabi");
            //FindMax(new int[] { 88, 119, 11, 22, 81, 22, 117, 228, 11 });
            // FindMin(new int[] { 88, 119, 11, 22, 81, 22, 117, 228, 11 });
            //RemoveElem(new int[] { 88, 119, 11, 22, 81, 22, 117, 228, 11 });
            // Console.WriteLine(IsPalindrome("123"));
            //int a = 5;
            ////   a++;
            //++a;
            //Console.WriteLine(a++);
            //Console.WriteLine(a++);

            //InsertString("I am a student of second year science", 30, " computer");
            //PrintEvenNumbersReverse();
            //  CalculateVowelsConsonants("aeioub");
            //  Console.WriteLine(IsAnagram("brush", "shrub"));

            //  PrintFabonaciSeries(15);
            // OccurenceOfCharacter("Noor", 'o');
            // ReverseArray(new int[] { 10,18,15,36,24,50,38,49 });

            //  ArrayClass.Data = new int[8] { 10, 20, 30, 40, 50, 86, 11, 32 };
            //  ArrayClass.Insert(100, 8);
            // ArrayClass.Search(100);
            //ArrayClass.Delete(40);

            int num1 = 10;
            int num2;

            // PassByReferenceParameters(ref num1, out num2);
            //  PrintFactorial(5);
            // SumOfDigits();
            //  SumofDigit(123);


            //  TryCatchWork();

            //Console.WriteLine(IsIncreasingsortedArray(new int[] { 1, 2, 2, 4 }));

            //   Console.WriteLine(isIncreasinglySorted(new int[] { 1, 2, 3, 4 }, 0));

            // MovechartoEnd("abxuauxbx", 'x');
            // RemoveDuplicates("abbccda");
            //  DecimalToBinary(4);
            // Console.WriteLine(5 / 2);
            //  ReverseStringBuilder(new StringBuilder().Append("Hello"));

            // PowerOfN(2, 5);

            //   MaxCharacterInstring("aaahahbccdefggg");
            // CountNegativeElements(new int[] { 1, 2, 3, -4, -6, -2, -4 });
            //int a = 0;
            //int b = 1;
            //Console.Write(a + "  " + b + " ");
            // PrintFabonaciSeriesRecrusion(10-2,a,b);

            #endregion


            #region Student
            //Student s1 = new Student();
            //s1.SetName("Noor Nabi");
            //Student s2 = new Student();
            //s1.StudentId = 110;
            //s2.StudentId = 16;
            //Console.WriteLine("S1.StudentId = {0} S2.StudentId = {1} S1.Name {2} S2.Name {3} ", s1.StudentId, s2.StudentId, s1.GetName(), s2.GetName());
            //   S1.StudentId = 110 S2.StudentId = 16 S1.Name = Moiz S1.Moiz

            #endregion


            #region Sorting

            //   Sorting sorting = new Sorting();
            //   sorting.BubbleSort();
            //  sorting.SelectionSort();

            #endregion




            #region Patterns

            // Patterns.HalfPyramid();
            //   Patterns.InvertedHalfPyramid();

            #endregion



            #region LinkedList
            //string type Linkedlist
            //Node<string> node = new();
            //node.AddFirst("Awais");
            //node.AddFirst("Moiz");
            //node.AddLast("Athar");
            //node.AddLast("Mazahar");
            //node.PrintList();

            //int type linkedList

            //Node<int> ll = new();
            //ll.AddLast(1);
            //ll.AddLast(5);
            //ll.AddLast(7);
            //ll.AddLast(3);
            //ll.AddLast(8);
            //ll.AddLast(2);
            //ll.AddLast(3);

            //ll.PrintList();
            //ll.SearchElem(8);
            #endregion


            #region Stack using ArrayList
            StackByArrayList mystack = new();
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            Console.WriteLine("Size of Stack : {0} : ", mystack.Size);
            mystack.PushAtend(4);
            mystack.PushAtEndRecrusive(5);
            while (!mystack.Isempty())
            {
                Console.WriteLine(mystack.Peek());
                mystack.Pop();
            }

            Console.WriteLine("Size of Stack : {0} : ", mystack.Size);


            #endregion

        }



    }


}

