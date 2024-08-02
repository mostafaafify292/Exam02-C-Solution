using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C_
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int _TimeOfExam, int _NumOfQuestion, Question[] _Question) 
            : base(_TimeOfExam, _NumOfQuestion, _Question)
        {

        }
       
        public override void ShowExam()
        {
            for (int i = 0; i < Question.Length; i++)
            {
                string z = "True&False - Question";
                Console.WriteLine("Please Enter Question Body");
                string x04 = Console.ReadLine();
                Console.WriteLine("Please Enter Question Mark");
                int x05 = int.Parse(Console.ReadLine());
                int x = 0;
                True_False_Question true_False_Question = new True_False_Question(z, x04, x05, x);
                Question[i] = true_False_Question;
                Console.WriteLine("Please Enter the right Answer id (1 for True  | 2 for False)");
                x = int.Parse(Console.ReadLine());
            }
          
        }

    }
}
