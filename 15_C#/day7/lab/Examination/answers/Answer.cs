namespace answers
{
    public class Answer
    {

        string answer;
        int answerID;


        public Answer(string _answer, int _answerID)
        {
            answer = _answer;
            answerID = _answerID;

        }

        public override string ToString()
        {
            return $"{answerID}: {answer}";
        }

        //edit answer or display
        public string ANS
        {
            set { answer = value; }
            get { return answer; }
        }
        public void show()
        {
            Console.WriteLine($"{answerID}:{answer}");
        }


    }
}