using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using answers;
namespace Questions
{
    public class TF : Question
    {
        bool rightAnswer;
        public TF(string _body, int _mark, bool _right) : base(QuestionHeader.TF, _body, _mark)
        {
            rightAnswer = _right;
        }
        public override void show()
        {
            Console.WriteLine(base.header + ":");
            Console.WriteLine(base.body);

        }
        public override void shoWithAnswer()
        {
            Console.WriteLine(base.header + ":");
            Console.WriteLine(base.body);
            Console.Write($"answer: {rightAnswer}");
            
        }


    }
}
