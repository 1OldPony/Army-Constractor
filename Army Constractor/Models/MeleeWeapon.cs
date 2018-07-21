using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class MeleeWeapon
    {
        public int MeleeWeaponID { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название")]
        [Display(Name = "Оружие бл. боя")]
        public string MelWeapName { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1, 3)]
        [Display(Name = "Радиус атаки")]
        public int Range { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1, 5)]
        [Display(Name = "Бронебойность")]
        public int MelWeapArmorIgnore { get; set; }

        [Display(Name = "Двуручное")]
        public bool TwoHanded { get; set; }

        [Display(Name = "Парное")]
        public bool Pare { get; set; }

        [Display(Name = "Описание")]
        [StringLength(500, ErrorMessage = "Длина строки должна быть меньше 500 символов")]
        public string Description { get; set; }
    }
}