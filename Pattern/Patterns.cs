using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems.Pattern
{
    internal class Patterns
    {

        static public void HalfPyramid()
        {
            /*
             **
             ***
             ****/
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

        }

        static public void InvertedHalfPyramid()
        {
            //****
            //***
            //**
            //*

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

        }

    }
}
