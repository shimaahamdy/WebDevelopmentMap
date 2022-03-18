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

        internal string Header
        {
            get
            {
                if (header == QuestionHeader.MCQ)
                    return "MCQ: choose the correct answer";
                if (header == QuestionHeader.TF)
                    return "True or Fasle";
                else return "";
            }
        }
        internal string Body
        {
            get
            {
                return id.ToString() + "- " + body;
            }
        }

        public override bool Equals(object obj)
        {

            Question Right = obj as Question; // if casting fails , return null , no exceptions will be thrown

            if (Right == null) return false;

            if (object.ReferenceEquals(Right, this)) return true;

            return id == Right.id;
        }
        public override int GetHashCode()
        {
            return id;
        }
        public abstract int getAnswer();

        public int Mark
        {
            get {
                return mark
                  ;
            }
        }
        public abstract List<string> writeQuestionsAns();


    }
}