using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        [DisplayName("Id")]
        public int Id { set; get; }

        [DisplayName("Ник")]
        [Required]
        public string Nick { set; get; }

        [DisplayName("Email")]
        [Required]
        public string Email { set; get; }

        [DisplayName("Пароль")]
        [Required]
        public string Password { set; get; }

        [DisplayName("Дата регистрации")]
        [Required]
        public DateTime CurrentDate { set; get; }
    }
}