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
            :base(quesitionsNum,subID,subName)
        {

        }

        public override void show()
        {
            for (int i = 0; i < base.currentQuesNum; i++)
            {
                questions[i].shoWithAnswer();
            }
;
        }
    }
}
