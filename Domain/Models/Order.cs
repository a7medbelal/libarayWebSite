using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Models;

public class Order : BaseModel
{
    [ForeignKey("User")]
    public string UserId { get; set; }
    public User User { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }
    public int TotalPrice { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}