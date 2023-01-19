using System.ComponentModel.DataAnnotations;

namespace MVCTemplate.Models
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name = "Firstname: ", Prompt = "Firstname: ")]
        [MinLength(2)]
        [MaxLength(25)]
        public string Firstname { get; set; }

        [Required, Display(Name = "Firstname: ", Prompt = "Firstname: "), MinLength(2), MaxLength(25)]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "E-Mail Address: ", Prompt = "E-Mail Address: ")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Subject: ", Prompt = "Subject: ")]
        [MinLength(5)]
        [MaxLength(150)]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Your Message: ", Prompt = "Your Message: ")]
        [MinLength(10)]
        [MaxLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Required]
        [Display(Name = "I Read Terms", Prompt = "I Read Terms")]
        public bool AcceptTerms { get; set; }
    }
}
