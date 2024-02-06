

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class ProfileEntity
{
    [Key]

    public int Id { get; set; }


    [ForeignKey(nameof(UserEntity))]
    public int UserId { get; set; } 

    public string FirstName { get; set; } = null!;


    public string LastName { get; set; } = null!;


    
    public string? StreetName { get; set; }


  
    public string? PostalCode { get; set; }


    public string? City { get; set; }

    public virtual UserEntity User { get; set; } = null!;
}


