using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public partial class RecrutType
    {
        public int RecrutTypeID { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название")]
        [Display(Name = "Тип рекрута")]
        public string RecrutTypeName { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1, 5)]
        [Display(Name = "Базовая сила")]
        public int RecrutTypeRank { get; set; }

        [Display(Name = "Бонус атаки")]
        [Range(0, 10)]
        public int RecrutTypeAttBonus { get; set; }

        [Display(Name = "Бонус защиты")]
        [Range(0, 10)]
        public int RecrutTypeDefBonus { get; set; }

        [Display(Name = "Поглощение урона")]
        [Range(0, 5)]
        public int RecrutTypeAbsorb { get; set; }

        [Display(Name = "Бронебойность")]
        [Range(0, 5)]
        public int RecrutTypeArmorIgnore { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(4, 20)]
        [Display(Name = "Движение")]
        public int RecrutTypeMove { get; set; }

        [Display(Name = "Бонус к храбрости")]
        [Range(0, 5)]
        public int RecrutTypeBraveryBonus { get; set; }

        [Display(Name = "Описание")]
        [StringLength(500, ErrorMessage = "Длина строки должна быть меньше 500 символов")]
        public string Description { get; set; }

        [NotMapped]
        public int Price
        {
            get => RecrutTypePrice();
            set { }
        }
    }

    public partial class RecrutType
    {
        public int RecrutTypePrice()
        {
            int RTPrice = (RecrutTypeRank * 10) + (RecrutTypeAttBonus * 5)
                + (RecrutTypeDefBonus*5) + (RecrutTypeAbsorb*5) + (RecrutTypeArmorIgnore*5) 
                + (RecrutTypeMove*2) + (RecrutTypeBraveryBonus*5);
            return RTPrice;
        }
    }
}