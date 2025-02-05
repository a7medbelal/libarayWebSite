using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Image  : BaseModel
{
  
    [ForeignKey("Book")]
    public int BookId { get; set; }
    public string ImageUrl { get; set; }
}