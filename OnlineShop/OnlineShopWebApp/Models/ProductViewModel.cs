using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "�� ������� ��� ��������")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "��� ������ ��������� �� 2 �� 25 ��������")]
        public string Name { get; set; }

        [Required(ErrorMessage = "�� ������� ���� ��������")]
        [Range(1, 1000000, ErrorMessage = "���� �� ����� ���� ������ 1000000 ���.")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "�� ������� �������� ��������")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "�������� ������ ��������� �� 10 �� 1000 ��������")]
        public string Description { get; set; }

        [Required(ErrorMessage = "�� ������ URL �����������")]
        [Range(3, 500, ErrorMessage = "URL ����������� �� ������ ���� ������ 500 ��������")]
        public string ImagePath { get; set; }
               
    }
}

