using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Models;

public class CategoriesBook : BaseModel
{
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    [ForeignKey("Book")]
    public int BookId { get; set; }
    public Book Book { get; set; }
}