using Questions;
using subjects;
namespace Exams
{
    public abstract class Exam: Ishow
    {
        DateTime date;
        protected int id;
        Subject subject;
        protected Question[] questions;
        int quesNum;
        protected int currentQuesNum; //track current question number
        static int ExamID; //unique id for each created exam

        //static Ctor initilize static field Examid = 0
        static Exam()
        {
            ExamID = 0;
        }
        public Exam(int _quesNum,int subjectID ,string subjectName)
        {
            quesNum = _quesNum;
            date = DateTime.Now;
            questions = new Question[quesNum];
            id = ExamID++;
            subject = new Subject(subjectID, subjectName);
        }
        public int ID
        {
            get { return id; }
        }


        public string Date
        {
            get { return date.ToString(); }
        }
        public bool addMCQ(string body, int mark, string[] answer, int right)
        {
            if (currentQuesNum < quesNum)
            {
                questions[currentQuesNum++] = new MCQ(body, answer, mark, right);
                return true;
            }
            else return false;
        }
        public bool addTF(string body, int mark, bool right)
        {
            if (currentQuesNum < quesNum)
            {
                questions[currentQuesNum++] = new TF(body, mark, right);
                return true;
            }
            else return false;

        }

        public abstract void show();
    }
}