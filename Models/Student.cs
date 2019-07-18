using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage="isminizi Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage="Email Adresinizi Giriniz")] 
        [EmailAddress(ErrorMessage="Email Adresinizi Düzgün Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage="Telefon Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage="Katılma Durumunuz nedir")]
        public bool? Confirm  { get; set; }
    }
}