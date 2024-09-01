namespace library.Entities
{
    public class Press
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> books { get; set; }

    }
}
