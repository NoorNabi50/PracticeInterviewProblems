using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems.Stack
{
    internal class StackByArray
    {

        private int Top { get; set; } = -1;
        public int[] StackData { get; set; }
        private int MaxSize { get; set; }
        public void IntializeStack()
        {
            Console.WriteLine("Enter the information of Stack : Enter Size of Stack : ");
            MaxSize = int.Parse(Console.ReadLine());
            StackData = new int[MaxSize];

        }

        public bool CheckOverFlow() => Top >= MaxSize;


        public void Push(int number)
        {
            if (CheckOverFlow())
            {
                Console.WriteLine("Stack is Full");
                return;
            }

            Top++;
            StackData[Top] = number;

        }

        public int Pop()
        {
            if (Top < 0)
            {
                Console.WriteLine("Stack is Underflow");
            }
            Top--;
            return StackData[Top];
        }

        public int TopElement()
        {
            return StackData[Top];
        }

        public void PrintStack()
        {
            for (int i = 0; i < StackData.Length; i++)
            {
                Console.WriteLine(StackData[i]);
            }
        }



    }
}
