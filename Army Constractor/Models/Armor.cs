using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public partial class Armor
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

        [NotMapped]
        public int? Price
        {
            get => ArmorPrice();
            set { }
        }        
    }

    public partial class Armor
    {
        public int? ArmorPrice()
        {
            int? ArmorPr = (ArmorAbsorb * 5) - (ArmorMoveDecrease * 3);
            return ArmorPr;
        }
    }
}