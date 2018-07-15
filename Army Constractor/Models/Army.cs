using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class Army
    {
        public int ArmyID { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название")]
        [Display(Name = "Армия")]
        public string ArmyName { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        public virtual List<UnitsInArmy> UnitsInArmies { get; set; }
    }
}