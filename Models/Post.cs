using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Post
    {
        [Key]
        [DisplayName("IdPost")]
        public int Id { set; get; }

        [ForeignKey("User")]
        [DisplayName("IdUser")]
        [Required]
        public int IdUser { set; get; }
        public User User { set; get; }

        [DisplayName("Название")]
        [Required]
        public string Title { set; get; }

        [DisplayName("Текст")]
        [Required]
        public string TextComment { set; get; }

        [DisplayName("Дата создания")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime CurrentDate { set; get; }

        [ForeignKey("Category")]
        [DisplayName("№ Категории")]
        [Required]
        public int IdCategory { set; get; }
        public Category Category { set; get; }
    }
}