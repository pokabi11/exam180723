using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam180723.Entities
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required, Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; }
        [Required, Column(TypeName = "nvarchar(15)")]
        public string Number { get; set; }
        [Required, Column(TypeName ="nvarchar(255)")]
        public string GroupName { get; set; }
        [Required, Column(TypeName= "Date"), NotMapped]
        public DateOnly HireDate { get; set; }
        [Required, Column(TypeName = "Date"), NotMapped]
        public DateOnly Birthday { get; set; }
    }
}
