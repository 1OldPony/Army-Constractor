using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class Mount
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
        public int? MountArmorIgnore { get; set; }

        [Display(Name = "Поглощение урона")]
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
        public string Description { get; set; }
    }
}