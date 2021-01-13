using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        [Key]
        [DisplayName("№")]
        public int IdCategory { set; get; }
        [DisplayName("Категория")]
        [Required]
        public String NameCategory { set; get; }
    }
}