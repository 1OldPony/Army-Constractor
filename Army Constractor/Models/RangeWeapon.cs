using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public partial class RangeWeapon
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
        public int RanWeapArmorIgnore { get; set; }

        [Display(Name = "Описание")]
        [StringLength(500, ErrorMessage = "Длина строки должна быть меньше 500 символов")]
        public string Description { get; set; }

        [NotMapped]
        public int Price
        {
            get => RangeWeaponTypePrice();
            set { }
        }
    }

    public partial class RangeWeapon
    {
        public int RangeWeaponTypePrice()
        {
            int RWPrice = (RanWeapAttBonus * 6) + (RanWeapRange * 3)
                + (RanWeapArmorIgnore * 6);
            return RWPrice;
        }
    }
}
