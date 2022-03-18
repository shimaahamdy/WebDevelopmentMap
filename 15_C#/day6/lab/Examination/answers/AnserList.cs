using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answers
{
    public class AnserList
    {
        int answerNumID = 0;  //track answer number ID
        Answer[] answers;     //list of answers

        public AnserList(string[] _answers)
        {
            if (_answers != null)
            {
                answers = new Answer[_answers.Length];
                for (int i = 0; i < answers.Length; i++)
                {
                    if (_answers[i] == null) continue;
                    answers[i] = new Answer(String.Copy(_answers[i]), answerNumID++);
                }
            }

        }
        // return answers num
        public int AnswerNum
        {
            get { return answerNumID; }
        }

        //retrun answers 
        public void show()
        {
            for (int i = 0; i < answers?.Length; i++)
                answers[i].show();

        }
        /*edit specific answer
         true: successed
         false: fail
         */

        public bool editAnswer(int id, string answer)
        {
            if (id < answerNumID)
            {
                answers[id].ANS = answer;
                return true;
            }
            else return false;
        }

    }
}
