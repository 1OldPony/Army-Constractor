using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public partial class MeleeWeapon
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

        [NotMapped]
        public int Price
        {
            get => MeleeWeaponPrice();
            set { }
        }
    }

    public partial class MeleeWeapon
    {
        public int MeleeWeaponPrice()
        {
            int TH = 0;
            int Pr = 0;
            if (TwoHanded == true)
            {
                TH = 20;
            }

            if (Pare == true)
            {
                Pr = 20;
            }

            int MeleeWeapPrice = (Range * 20) + (MelWeapArmorIgnore * 5) + Pr - TH;
            return MeleeWeapPrice;
        }
    }
}