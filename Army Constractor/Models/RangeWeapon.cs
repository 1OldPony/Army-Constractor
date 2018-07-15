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

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(5, 30)]
        [Display(Name = "Радиус атаки")]
        public int RanWeapRange { get; set; }

        [Display(Name = "Бронебойность")]
        public int? RanWeapArmorIgnore { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}