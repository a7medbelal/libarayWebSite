using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models;

namespace Domain.Models;

public class OrderItem : BaseModel
{
   
    public int LibraryBookId { get; set; }
    public LibraryBook LibraryBook { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
}