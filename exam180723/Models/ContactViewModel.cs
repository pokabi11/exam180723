using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace exam180723.Models
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(6,ErrorMessage ="Input the right Name Form")]
        [MaxLength(255)]
        [Display(Name ="Contact Name")]
        public string Name { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "Input the right Number Form")]
        [MaxLength(15)]
        [Display(Name = "Contact Number")]
        public string Number { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Input the right Group Name Form")]
        [MaxLength(255)]
        [Display(GroupName = "Group Name")]
        public string GroupName { get; set; }
        public DateOnly HireDate { get; set; }
        public DateOnly Birthday { get; set; }

    }
}
