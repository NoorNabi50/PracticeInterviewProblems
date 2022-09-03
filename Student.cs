using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems
{
    internal class Student
    {

        public int StudentId { get; set; }

        private static string StudentName { get; set; }

        public void SetName(string name) {

            StudentName = name;    
        }

        public string GetName()
        {
            return StudentName;
        }
    }
}
