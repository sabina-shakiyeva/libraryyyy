using static System.Runtime.InteropServices.JavaScript.JSType;

namespace library.Entities
{
    public class S_Card
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public Date DateIN { get; set; }
        public Date DateOut { get; set; }
        public int LibId { get; set; }
        public Student Student { get; set; }
        public Book Book { get; set; }

    }
}
