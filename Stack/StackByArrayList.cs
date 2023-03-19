using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems.Stack
{
    internal class StackByArrayList
    {
        private ArrayList arrayList = new();
        public int Size => arrayList.Count;

        public void Push(int number) => arrayList.Add(number);

        public bool Isempty() => Size == 0;

        public int Pop()
        {
            int top = Convert.ToInt32(arrayList[Size - 1]);
            arrayList.Remove(top);
            return top;
        }

        public int Peek() => Isempty() ? -1 : Convert.ToInt32(arrayList[Size - 1]);


        //using loop 
        public void PushAtend(int elem = 0)
        {
            ArrayList tempArrayList = new();

            while (!Isempty())
            {
                tempArrayList.Add(Peek());
                Pop();
            }

            Push(elem);
            while (tempArrayList.Count != 0)
            {
                int top = (int)tempArrayList[tempArrayList.Count - 1];
                Push(top);
                tempArrayList.Remove(top);
            }

        }

        //using recrusion Efficient/Optimized way

        public void PushAtEndRecrusive(int elem = 0)
        {
            if (Isempty())
            {
                Push(elem);
                return;
            }
            int top = Pop();
            PushAtEndRecrusive(elem);
            Push(top);

        }

    }
}
