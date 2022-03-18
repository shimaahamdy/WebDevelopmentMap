using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using answers;
namespace Questions
{
    public class MCQ : Question
    {
        AnserList answers; //list of answers in MCQ
        int rightAnswer;   // right choice num

        public MCQ(string _body, string[] _answers, int _mark, int _right) : base(QuestionHeader.MCQ, _body, _mark)
        {
            answers = new AnserList(_answers);
            if (_right < _answers?.Length) rightAnswer = _right;

          
        }
        
     

        //edit or display right answer
        public int RightAnswer
        {
            get { return rightAnswer; }
            set { if (value < answers.AnswerNum) rightAnswer = value; }
        }

    

        public override void show()
        {
            Console.WriteLine(base.header + ":");
            Console.WriteLine(base.body);
            answers.show();
        }
        public override void shoWithAnswer()
        {
            Console.WriteLine(base.header + ":");
            Console.WriteLine(base.body);
            answers.show();
            Console.WriteLine($"answer: {rightAnswer}");
        }

     
     
    



    }
}
