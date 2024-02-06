using System.ComponentModel.DataAnnotations;

namespace ConsoleApp.Entities;

public class BookEntity
{
    [Key]
    public int BookId { get; set; }
    public string Title { get; set; } = null!;
 

}
