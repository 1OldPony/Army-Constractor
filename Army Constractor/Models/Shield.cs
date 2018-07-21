﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class Shield
    {
        public int ShieldID { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название")]
        [Display(Name = "Щит")]
        public string ShieldName { get; set; }

        [Required(ErrorMessage = "Эта характеристика необходима")]
        [Range(1, 5)]
        [Display(Name = "Бонус к защите")]
        public int ShieldDefBonus { get; set; }

        [Display(Name = "Описание")]
        [StringLength(500, ErrorMessage = "Длина строки должна быть меньше 500 символов")]
        public string Description { get; set; }

        [Display(Name = "Цена")]
        public int ShieldPrice { get; set; }
    }
}