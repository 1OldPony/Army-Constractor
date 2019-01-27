using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public partial class Unit
    {
        public int UnitID { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название")]
        [Display(Name = "Юнит")]
        public string UnitName { get; set; }

        [Required(ErrorMessage = "Без рекрутов создать юнита невозможно")]
        [Display(Name = "Тип рекрута")]
        public int RecrutTypeID { get; set; }

        [Display(Name = "Доспех")]
        public int? ArmorID { get; set; }

        [Display(Name = "Оружие ближнего боя")]
        [ForeignKey("MeleeWeapon")]
        public int? MeleeWeaponID { get; set; }

        [Display(Name = "Оружие дальнего боя")]
        public int? RangeWeaponID { get; set; }

        [Display(Name = "Вспомогательное оружие")]
        [ForeignKey("SecondWeapon")]
        public int? SecondWeaponID { get; set; }

        [Display(Name = "Щит")]
        public int? ShieldID { get; set; }

        [Display(Name = "Верховое животное")]
        public int? MountID { get; set; }

        [Required(ErrorMessage = "Введите количество бойцов в отряде")]
        [Range(1, 10)]
        [Display(Name = "Бойцов в отряде")]
        public int NumberOfCombatants { get; set; }

        [Display(Name = "описание")]
        [StringLength(500, ErrorMessage = "Длина строки должна быть меньше 500 символов")]
        public string Description { get; set; }
        
        [NotMapped]
        [Display(Name = "Стоимость")]
        public int? Price
        {
            get => UnitPrice();
            set { }
        }
        
        public virtual Armor Armor { get; set; }
        public virtual RecrutType RecrutType { get; set; }
        public virtual MeleeWeapon MeleeWeapon { get; set; }
        public virtual MeleeWeapon SecondWeapon { get; set; }
        public virtual Mount Mount { get; set; }
        public virtual RangeWeapon RangeWeapon { get; set; }
        public virtual Shield Shield { get; set; }

        
    }

    public partial class Unit
    {
        PricesCalc PC = new PricesCalc();
        private int? UnitPrice()
        {

            int? UPrice = (PC.ShieldPriceFromID(ShieldID)+ PC.ArmorPriceFromID(ArmorID) + PC.MeleeWeapPriceFromID(MeleeWeaponID) 
                + PC.MeleeWeapPriceFromID(SecondWeaponID) + PC.MountPriceFromID(MountID) + PC.RangeWeapFromID(RangeWeaponID) 
                + PC.RecrutTypePriceFromID(RecrutTypeID))*NumberOfCombatants;
            return UPrice;
        }
    }
}