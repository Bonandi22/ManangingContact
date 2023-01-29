using System.ComponentModel.DataAnnotations;

namespace ManangingContact.Models
{
    public class Contacts
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a contact {0} with 9 digits")]
        [MaxLength(9)]
        public string Contact { get; set; } 

        [Required(ErrorMessage = "the field {0} is mandatory")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "the field {0} is mandatory")]
        public string Email { get; set; } 

    }
}
