using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class Unit
    {
        public virtual int UnitID { get; set; }
        public virtual string UnitName { get; set; }
        public virtual int BaseUnitID { get; set; }
        public virtual int ArmorID { get; set; }
        public virtual int MeleeWeaponID { get; set; }
        public virtual int RangeWeaponID { get; set; }
        public virtual int SecondWeaponID { get; set; }
        public virtual int ShieldID { get; set; }
        public virtual int MountID { get; set; }
        public virtual int NumberOfCombatants { get; set; }
        public virtual string Description { get; set; }
        public virtual Armor Armor { get; set; }
        public virtual BaseUnit BaseUnit { get; set; }
        public virtual MeleeWeapon MeleeWeapon { get; set; }
        public virtual Mount Mount { get; set; }
        public virtual RangeWeapon RangeWeapon { get; set; }
        public virtual Shield Shield { get; set; }
    }
}