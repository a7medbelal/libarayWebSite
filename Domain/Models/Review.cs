using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Review : BaseModel
{
    public int ?LibraryId { get; set; }
    public int Rating { get; set; }
    public string? Comment { get; set; }
    [ForeignKey("User")]
    public string UserId { get; set; }
    public User User { get; set; }
}