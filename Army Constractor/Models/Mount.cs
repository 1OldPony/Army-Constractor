using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public partial class Mount
    {
        public int MountID { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название")]
        [Display(Name = "Верховое животное")]
        public string MountName { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1, 3)]
        [Display(Name = "Радиус атаки")]
        public int MountRange { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1, 5)]
        [Display(Name = "Базовая сила")]
        public int MountRank { get; set; }

        [Display(Name = "Бронебойность")]
        [Range(0, 5)]
        public int? MountArmorIgnore { get; set; }

        [Display(Name = "Поглощение урона")]
        [Range(0, 5)]
        public int? MountAbsorb { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1, 10)]
        [Display(Name = "Бонус защиты")]
        public int MountDefBonus { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1, 10)]
        [Display(Name = "Бонус атаки")]
        public int MountAttBonus { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1, 20)]
        [Display(Name = "Движение")]
        public int MountMove { get; set; }

        [Display(Name = "Полет")]
        public bool Flying { get; set; }

        [Display(Name = "Описание")]
        [StringLength(500, ErrorMessage = "Длина строки должна быть меньше 500 символов")]
        public string Description { get; set; }

        [NotMapped]
        public int? Price
        {
            get => MountPrice();
            set { }
        }
    }

    public partial class Mount
    {
        public int? MountPrice()
        {
            int Fl = 0;
            if (Flying==true)
            {
                Fl = 20;
            }
            int? MountPrice = (MountRange * 20) + (MountRank * 10)
                + (MountArmorIgnore * 5) + (MountAbsorb * 5) + (MountDefBonus * 5) + (MountAttBonus * 5) + (MountMove*2) + Fl;
            return MountPrice;
        }
    }
}