using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C_
{
    internal class MCQ_Question : Question
    {
        public Answer[] Answers { get; set; }
        public int CorrectAnswerID { get; set; }
        
        public MCQ_Question(string HeaderOfQ, string BodyOfQ, int Mark , Answer[] _answers, int _correctAnswerID)
            :base(HeaderOfQ, BodyOfQ, Mark)
        {
            Answers = _answers;
            CorrectAnswerID = _correctAnswerID;
            _answers = new Answer[3];
        }
        public MCQ_Question()
        {
            
        }
        public override string ToString()
        {
            return $"HeaderOfQ = {HeaderOfQ} , BodyOfQ = {BodyOfQ} , Mark = {Mark} ,Answer = {Answers[0].AnswerText} ";
        }


    }
}
