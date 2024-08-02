using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_C_
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        public Subject(int subjectId, string subjectName, Exam exam)
        {
            SubjectId = subjectId; SubjectName = subjectName; Exam = exam;
        }
        public void CreateExam()
        {
            Exam.ShowExam();
        }
    }
}
