namespace Exam02_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Please Enter The Type Of Exam (1 for Practical  | 2 for Final)");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("Please Enter The Time Of Exam from (30 min to 180 min)");
                int x01 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Number Of Question");
                int x02 = int.Parse(Console.ReadLine());
                Exam exam = new PracticalExam(x01 , x02 , new Question[x02]);
                exam.ShowExam();

            }
            else if (x == 2)
            {
                Console.WriteLine("Please Enter The Time Of Exam from (30 min to 180 min)");
                int x01 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Number Of Question");
                int x02 = int.Parse(Console.ReadLine());
                Exam exam = new FinalExam(x01, x02, new Question[x02]);
                exam.ShowExam();
                
                
                //MCQ_Question q2 = new MCQ_Question();
                //q2.Answers[0].AnswerText = "tw";
            }
            
            
            


           











        }
    }
}
