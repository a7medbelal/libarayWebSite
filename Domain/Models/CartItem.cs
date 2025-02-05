using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Models;

public class CartItem : BaseModel
{
    [ForeignKey("LibraryBook")]
    public int? LibraryBookId { get; set; }
    public LibraryBook LibraryBook { get; set; }
    [ForeignKey("Cart")]
    public int? CartId { get; set; }
    public Cart Cart { get; set; }
}