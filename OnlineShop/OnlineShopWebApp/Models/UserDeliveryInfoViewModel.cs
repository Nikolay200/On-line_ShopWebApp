
using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class UserDeliveryInfoViewModel
    {
        [Required(ErrorMessage = "Не указана фамилия пользователя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Фамилия должна содержать от 2 до 25 символов")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Не указано имя пользователя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Имя должно содержать от 2 до 25 символов")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Не указано отчество пользователя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Отчество должно содержать от 2 до 25 символов")]
        public string PatronymicName { get; set; }

        [Required(ErrorMessage = "Не указан телефон")]
        
        //[Range(1, 10, ErrorMessage = "Номер телефона должен содержать не более 10 цифр")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Не указан город")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Поле должно содержать от 2 до 25 символов")]
        public string Town { get; set; }

        [Required(ErrorMessage = "Не указана улица")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Поле должно содержать от 2 до 25 символов")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Не указан номер дома")]
        [Range(1, 300, ErrorMessage ="Номер дома не может быть больше 300")]
        public int House { get; set; }

        [Required(ErrorMessage = "Не указан номер квартиры")]
        [Range(1, 1000, ErrorMessage = "Номер квартиры не может быть больше 1000")]
        public int Flat { get; set; }

        [Required(ErrorMessage = "Не указан E-mail")]
        [EmailAddress(ErrorMessage ="Укажите валидный адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан индекс")]
        //[Range(6, 6, ErrorMessage = "Индекс должен содержать 6 цифр")]
        public int Index { get; set; }
    }
}
