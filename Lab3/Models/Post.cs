using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium_3.Models
{
    public class Post
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole 'Zawartość' jest wymagane.")]
        [Display(Name = "Zawartość")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Pole 'Autor' jest wymagane.")]
        [Display(Name = "Autor")]
        public string Author { get; set; }


       
        [Display(Name = "Data publikacji")]
        public DateTime PublicationDate { get; set; }
        [Display(Name = "Tagi")]
        public Tags Tags { get; set; }
        [MinLength(length: 5, ErrorMessage = "Wiadomość musi mieć co najmniej 5 znaków!")]
        [MaxLength(length: 100)]
        [Required(ErrorMessage = "Pole 'Komentarz' jest wymagane.")]
        [Display(Name = "Komentarz")]
        public string Comment { get; set; }
    }

}
