

using ConsoleApp.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infrastructure.Entities;

public class UserEntity
{
    [Key]
    public int UserId { get; set; } 



    [Required]
    [Column(TypeName = "varchar(100)")]
    public string Email { get; set; } = null!;


    [Required]
    [Column(TypeName = "varchar(200)")]
    public string Password { get; set; } = null!;


    [Required]
    [ForeignKey(nameof(RoleEntity))]
    public int RoleId { get; set; }

    public virtual RoleEntity Role { get; set; } = null!;
    public virtual ProfileEntity Profile { get; set; } = null!;
    public virtual ICollection<LoansEntity> Loans { get; set; } = new HashSet<LoansEntity>();
}


