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
        public virtual int ArmorID { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public virtual string ArmorName { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Range(1,5)]
        public virtual int ArmorAbsorb { get; set; }
        public virtual int ArmorMoveDecrease { get; set; }
        public virtual string Description { get; set; }
    }
}