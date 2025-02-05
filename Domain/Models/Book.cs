namespace Domain.Models;

public class Book : BaseModel
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Version { get; set; }
    public DateTime PublishDate { get; set; }
    public ICollection<LibraryBook> LibraryBooks { get; set; }
    public ICollection<Category> Categories { get; set; }
}