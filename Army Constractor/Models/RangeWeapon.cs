using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class RangeWeapon
    {
        public int RangeWeaponID { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название")]
        [Display(Name = "Оружие дал. боя")]
        public string RanWeapName { get; set; }

        [Display(Name = "Стрелковый бонус атаки")]
        [Range(1, 5)]
        public int RanWeapAttBonus { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(5, 30)]
        [Display(Name = "Радиус атаки")]
        public int RanWeapRange { get; set; }

        [Display(Name = "Бронебойность")]
        [Range(0, 5)]
        public int? RanWeapArmorIgnore { get; set; }

        [Display(Name = "Описание")]
        [StringLength(500, ErrorMessage = "Длина строки должна быть меньше 500 символов")]
        public string Description { get; set; }

        [Display(Name = "Цена")]
        public int RangeWeaponPrice { get; set; }
    }
}