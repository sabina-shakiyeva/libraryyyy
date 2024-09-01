namespace library.Entities
{
    public class Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> books { get; set; }
    }
}
