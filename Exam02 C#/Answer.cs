    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C_
{
    internal class Answer :MCQ_Question
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer(string HeaderOfQ, string BodyOfQ, int Mark, Answer[] _answers, int _correctAnswerID , int answerId , string answerText)
            : base(HeaderOfQ, BodyOfQ, Mark, _answers, _correctAnswerID)
        {
            AnswerId = answerId;
            AnswerText = answerText;

        }
        public Answer()
        {
            
        }
        public void answerID(int i) 
        {
            Console.WriteLine($"Please Enter Choise Number {i +1}");
            AnswerId = i+1;
        }
        public void answerText() 
        {
            string z = Console.ReadLine();
            AnswerText = z;
            
        }



    }
}
