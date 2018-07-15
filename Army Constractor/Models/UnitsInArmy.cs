using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class UnitsInArmy
    {
        [Key, Column(Order = 0)]
        public int UnitID { get; set; }

        [Key, Column(Order = 1)]
        public int ArmyID { get; set; }

        [Required(ErrorMessage = "Введите количество данных отрядов в армии")]
        [Range(1, 20)]
        [Display(Name = "Количество отрядов")]
        public int NumberOfUnits { get; set; }

        public virtual Unit Unit { get; set; }
        public virtual Army Army { get; set; }
    }
}