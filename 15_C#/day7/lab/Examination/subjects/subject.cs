namespace subjects
{
    public class Subject
    {
        int id;
        public Subject(int _id,string _name)
        {
            id = _id;
            Name = _name;
        }
       public string Name
        { get; set;}
        public int ID
        {
            get { return id; }
        }

    }
}