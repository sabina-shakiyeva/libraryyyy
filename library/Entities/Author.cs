namespace library.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LatName { get; set; }
        public ICollection<Book> books  { get; set; }


    }
}
