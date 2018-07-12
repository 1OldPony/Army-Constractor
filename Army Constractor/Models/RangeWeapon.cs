using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class RangeWeapon
    {
        public virtual int RangeWeaponID { get; set; }
        public virtual string RanWeapName { get; set; }
        public virtual int RanWeapRange { get; set; }
        public virtual int RanWeapArmorIgnore { get; set; }
        public virtual string Description { get; set; }
    }
}