using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int quesitionsNum, int subID, string subName) 
            :base(subID,subName)
        {

        }

        public override void show()
        {
            for (int i = 0; i < base.questions.Count; i++)
            {
                questions[i].shoWithAnswer();
            }
;
        }
    }
}
