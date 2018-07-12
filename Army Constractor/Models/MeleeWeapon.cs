using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class MeleeWeapon
    {
        public virtual int MeleeWeaponID { get; set; }
        public virtual string MelWeapName { get; set; }
        public virtual int Range { get; set; }
        public virtual int MelWeapArmorIgnore { get; set; }
        public virtual bool TwoHanded { get; set; }
        public virtual bool Pare { get; set; }
        public virtual string Description { get; set; }
    }
}