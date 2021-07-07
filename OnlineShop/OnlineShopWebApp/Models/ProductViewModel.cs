using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Не указано имя продукта")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Имя должно содержать от 2 до 25 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана цена продукта")]
        [Range(1, 1000000, ErrorMessage = "Цена не может быть больше 1000000 руб.")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Не указано описание продукта")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Описание должно содержать от 10 до 1000 символов")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Не указан URL изображения")]
        [Range(3, 500, ErrorMessage = "URL изображения не должен быть больше 500 символов")]
        public string ImagePath { get; set; }
               
    }
}

