using Labolatorium_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium_3.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength:50, ErrorMessage = "Zbyt długie imię, podaj mniej niż 50 znaków")]
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public DateTime? Birth { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }

    }
}
