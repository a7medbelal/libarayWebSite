using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class LibraryBook : BaseModel
{
    public int BookId { get; set; }
    public Book Book { get; set; }
    [ForeignKey("Library")]
    public int? LibraryId { get; set; }
    public Library Library { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; }
}