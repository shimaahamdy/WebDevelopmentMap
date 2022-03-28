namespace APIcore.Models
{
    public class department
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }

        public virtual List<student> Students { get; set; } = new List<student>();
    }
}
