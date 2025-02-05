namespace Domain.Models;

public class Category : BaseModel
{
    public string CategoryName { get; set; }
    public ICollection<Book> Books { get; set; }
}