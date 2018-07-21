using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class Armor
    {
        public int ArmorID { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название")]
        [Display (Name = "Доспех") ]
        public string ArmorName { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1,5)]
        [Display(Name = "Поглощение урона")]
        public int ArmorAbsorb { get; set; }

        [Range(0, 5)]
        [Display(Name = "Снижение скорости")]
        public int? ArmorMoveDecrease { get; set; }

        [Display(Name = "Описание")]
        [StringLength(500, ErrorMessage = "Длина строки должна быть меньше 500 символов")]
        public string Description { get; set; }
    }
}