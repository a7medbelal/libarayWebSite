namespace Domain.Models;
public class Library : BaseModel
{
    public string UserId { get; set; }
    public User User { get; set; } = null!; 
    public string Title { get; set; }
    public string? Image { get; set; }
    public string Description { get; set; }
    public ICollection<LibraryBook> LibraryBooks { get; set; }
    public ICollection<Review> Reviews { get; set; }
}