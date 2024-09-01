namespace library.Entities;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Pages { get; set; }
    public int PressId { get; set; }
    public int ThemeId { get; set; }
    public int CategoryId { get; set; }
    public int AuthorId { get; set; }
    public Category Category { get; set; }
    public Press Press { get; set; }
    public Theme Theme { get; set; }
    public Author Author { get; set; }
    public ICollection<S_Card> S_cards { get; set; }


}
