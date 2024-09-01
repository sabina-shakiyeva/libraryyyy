namespace library.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LatName { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public ICollection<S_Card> S_Cards { get; set; }

    }
}
