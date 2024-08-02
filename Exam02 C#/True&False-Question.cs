using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C_
{
    internal class True_False_Question : Question
    {
        public int CorrectAnswerIDForTAndF { get; set; }
        public True_False_Question(string HeaderOfQ , string BodyOfQ ,int Mark,int _CorrectAnswerIDForTAndF) 
            : base(HeaderOfQ , BodyOfQ ,Mark) 
        {
            CorrectAnswerIDForTAndF = _CorrectAnswerIDForTAndF;
        }
      
    }
}
