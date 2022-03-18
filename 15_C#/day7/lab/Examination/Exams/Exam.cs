using Questions;
using subjects;
namespace Exams
{
    public abstract class Exam: Ishow
    {
        DateTime date;
        protected int id;
        Subject subject;
        protected QuestionList questions;
        Dictionary<Question, int> QuestionsAnswer;

        static int ExamID; //unique id for each created exam

        //static Ctor initilize static field Examid = 0
        static Exam()
        {
            ExamID = 0;
        }
        public Exam(int subjectID ,string subjectName)
        {
           
            date = DateTime.Now;
            questions = new QuestionList();
            id = ExamID++;
            subject = new Subject(subjectID, subjectName);
            QuestionsAnswer =new Dictionary<Question, int>();
        }
        public int ID
        {
            get { return id; }
        }


        public string Date
        {
            get { return date.ToString(); }
        }
        public void addMCQ(string body, int mark, string[] answer, int right)
        {
            Question q=  new MCQ(body, answer, mark, right);
            questions.Add(q);
   
            
     
        }
        public void addTF(string body, int mark, bool right)
        {
            questions.Add(new TF(body, mark, right));
            
        }

        public abstract void show();

        public bool setAnswer(int _qusID,int _answer)
        {
            return QuestionsAnswer.TryAdd(questions[_qusID], _answer);
        }

        public int correctExam()
        {
            int mark = 0;
            for(int i=0;i<questions.Count; i++)
            {
                if (QuestionsAnswer[questions[i]] == questions[i].getAnswer())
                    mark += questions[i].Mark;
            }
            return mark;

        }

        public void saveQuestions()
        {
            questions.saveQuestions(id);
        }
    }
}