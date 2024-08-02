using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C_
{
    internal class Question 
    {

        public string HeaderOfQ { get; set; }
        public string BodyOfQ { get; set; }
        public int Mark { get; set; }

        public Question(string _HeaderOfQ, string _BodyOfQ, int _Mark )
            
        {
            HeaderOfQ = _HeaderOfQ;
            BodyOfQ = _BodyOfQ;
            Mark = _Mark;
        }
        public Question()
        {
            
        }
        public override string ToString()
        {
            return $"HeaderOfQ = {HeaderOfQ} , BodyOfQ = {BodyOfQ} , Mark = {Mark} , ";
        }


        public void headerOfQ(int x)
        {
            if (x == 1)
            {
                HeaderOfQ = "MCQ Question";
            }
            else if (x == 2)
            {
                HeaderOfQ = "True | False Question";
            }
        }
        //public void bodyOfQ(string x)
        //{
        //    BodyOfQ = x;
        //}
        //public void mark(int x)
        //{
        //    Mark = x;      
        //}







    }
}
