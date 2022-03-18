using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Questions
{
    public class QuestionList: List<Question>
    {
        public bool saveQuestions(int id)
        {
            try
            {
                string path = @"E:\software engineering\ITI\tasks\15_C#\day7\lab\Examination\Questions\questionsFiles\"+id.ToString() +".txt";
                using (StreamWriter sw = File.CreateText(path))
                {

                    for (int i = 0; i < base.Count; ++i)
                    {
                        sw.WriteLine(base[0].Header);
                        sw.WriteLine(base[i].Body);
                        List<string> answers = base[0].writeQuestionsAns();
                        for (int j = 0; j < answers.Count; ++j)
                            sw.WriteLine(answers[i]);
                    }
                    return true;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }   
        
    }
}
