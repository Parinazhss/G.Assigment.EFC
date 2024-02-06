


using ConsoleApp.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class LoansEntity
{
    [Key]
    public int LoanId { get; set; }


    [Required]
    [ForeignKey(nameof(UserEntity))]
    public int UserId { get; set; }
    public virtual UserEntity User { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(BookEntity))]
    public int BookId { get; set; }
    public virtual BookEntity Book { get; set; } = null!;

    public DateTime LoanDate { get; set; }
    public DateTime ReturnDate { get; set; }
}


