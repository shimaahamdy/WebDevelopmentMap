using answers;
namespace Questions
{
    // abstract class (base quesion class that different question types inhirt from
    public abstract class Question  : IComparable
    {
        protected QuestionHeader header;
        protected string body;
        protected int mark;
        protected int id;
        static int questionID;

        public Question(QuestionHeader _header, string _body, int _mark)
        {
            header = _header;
            body = _body;
            mark = _mark;
            id = questionID++;
        }

        public abstract void show();
        public abstract void shoWithAnswer();

        public int CompareTo(object obj)
        {
            if (obj is Question RQuest)
            {
                if (id == RQuest.id) return 0;
                else return id.CompareTo(RQuest.id);
            }
            else
                return 1;
        }

    
    }
}