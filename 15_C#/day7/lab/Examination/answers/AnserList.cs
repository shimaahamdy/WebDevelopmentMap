using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answers
{
    public class AnserList
    {
        List<Answer> answers;     //list of answers

        public AnserList(string[] _answers)
        {
            if (_answers != null)
            {
                answers = new List<Answer>();
                for (int i = 0; i < _answers.Length; i++)
                {
                    if (_answers[i] == null) continue;
                    Console.WriteLine(answers.Count);
                    answers.Add(new Answer(String.Copy(_answers[i]), answers.Count+1));
                }
            }

        }
        // return answers num
        public int AnswerNum
        {
            get { return answers.Count; }
        }

        //retrun answers 
        public void show()
        {
            for (int i = 0; i < answers.Count; i++)
                answers[i].show();

        }
        /*edit specific answer
         true: successed
         false: fail
         */

        public bool editAnswer(int id, string answer)
        {
            if (id < answers.Count)
            {
                answers[id].ANS = answer;
                return true;
            }
            else return false;
        }
        public List<string> writeAnswers()
        {
            List<string> ans = new List<string>();
            for (int i = 0; i < answers.Count; i++)
                ans.Add(answers[i].ToString());
            return ans;

            
        }

    }
}
