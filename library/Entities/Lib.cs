namespace library.Entities
{
    public class Lib
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<S_Card> S_Cards { get; set; }
    }
}
