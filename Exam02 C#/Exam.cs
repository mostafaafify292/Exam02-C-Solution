using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C_
{
    internal class Exam 
    {
        public Question[] Question { get; set; }
        public int TimeOfExam { get; set; }
        public int NumOfQuestion { get; set; }
        public Exam(int _TimeOfExam , int _NumOfQuestion , Question[] _Question)
        {
            TimeOfExam = _TimeOfExam;
            NumOfQuestion = _NumOfQuestion;
            Question = _Question;
            //Question = new Question[_NumOfQuestion];
            
            
        }
       
        public virtual void ShowExam()
        { }
      
    }
}
