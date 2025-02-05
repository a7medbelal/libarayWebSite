using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public class Cart : BaseModel
{
    [ForeignKey(("User"))]
    public string UserId { get; set; }
    public User User { get; set; }
    [Precision(18, 2)]
    public decimal  TotalPrice { get; set; }
   public ICollection<CartItem> CartItems { get; set; }
    
}