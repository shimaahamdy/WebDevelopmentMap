using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(int quesNum, int subjectID, string subjectName) 
            :base(subjectID,subjectName)
        {

        }
        public override void show()
        {
            for (int i = 0; i < base.questions.Count; i++)
            {
                questions[i].show();
            }
;
        }

       
    }
}
