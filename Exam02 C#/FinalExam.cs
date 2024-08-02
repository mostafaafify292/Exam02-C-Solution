using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C_
{
    internal class FinalExam : Exam
    {
        public FinalExam(int _TimeOfExam, int _NumOfQuestion, Question[] _Question)
            : base(_TimeOfExam, _NumOfQuestion, _Question)
        {

        }

        public override void ShowExam()
        {
            for (int i = 0; i < Question.Length; i++)
            {

                Console.WriteLine($"Please Enter Type Of Question {i+1} (1 For MCQ  | 2 For True&False)");
                int x03 = int.Parse(Console.ReadLine());
                string z;
                if (x03 == 1)
                {
                    z = "MCQ - Question";
                }
                else if (x03 == 2)
                {
                    z = "True | False Question";
                }
                else
                {
                    z = "error";
                }
                Console.WriteLine("Please Enter Question Body");
                string x04 = Console.ReadLine();
                Console.WriteLine("Please Enter Question Mark");
                int x05 = int.Parse(Console.ReadLine());
                if (x03 == 1)
                {
                    int x = 0;
                    MCQ_Question q = new MCQ_Question(z, x04, x05, new Answer[3], x);                 
                    Question[i] = q;
                    Console.WriteLine("choices Of Question");
                    for (int j = 0; j < q.Answers.Length; j++)
                    {
                        q.Answers[j] = new Answer();
                        q.Answers[j].answerID(j);
                        q.Answers[j].answerText();
                       
                    }
                    Console.WriteLine("Please Enter The Right Answer ID");
                    x = int.Parse(Console.ReadLine());
                    q.CorrectAnswerID = x;

                }
                else if (x03 == 2)
                {
                    int x = 0;
                    True_False_Question true_False_Question = new True_False_Question(z , x04 , x05 ,x );
                    Question[i] = true_False_Question;
                    Console.WriteLine("Please Enter the right Answer id (1 for True  | 2 for False)");
                    x = int.Parse(Console.ReadLine());
                }

            }
        }

    }
}
