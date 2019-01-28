using System
    ;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class PricesCalc
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();


        public int ShieldPriceFromID(int? id)
        {
            int ShDef = db.Shields.Single(p => p.ShieldID == id).ShieldDefBonus*5;
            return ShDef;
        }

        public int RecrutTypePriceFromID(int? id)
        {
            int Rank = db.RecrutTypes.Single(p => p.RecrutTypeID == id).RecrutTypeRank * 10;
            int? AttBonus = db.RecrutTypes.Single(p => p.RecrutTypeID == id).RecrutTypeAttBonus*5;
            int? DefBonus = db.RecrutTypes.Single(p => p.RecrutTypeID == id).RecrutTypeDefBonus*5;
            int? Absorb = db.RecrutTypes.Single(p => p.RecrutTypeID == id).RecrutTypeAbsorb*5;
            int? ArmorIgnore = db.RecrutTypes.Single(p => p.RecrutTypeID == id).RecrutTypeArmorIgnore*5;
            int? Move = db.RecrutTypes.Single(p => p.RecrutTypeID == id).RecrutTypeMove*2;
            int? BraveryBonus = db.RecrutTypes.Single(p => p.RecrutTypeID == id).RecrutTypeBraveryBonus * 5;

            int Total = Rank + AttBonus + DefBonus + Absorb + ArmorIgnore + Move + BraveryBonus;
            return Total;
        }

        public int? ArmorPriceFromID(int? id)
        {
            int Absorb = db.Armors.Single(p => p.ArmorID == id).ArmorAbsorb * 5;
            int? MoveDecrease = db.Armors.Single(p => p.ArmorID == id).ArmorMoveDecrease * 2;

            int? Total = Absorb - MoveDecrease;
            return Total ?? 0;
        }

        public int? MeleeWeapPriceFromID(int? id)
        {
            int Range = db.MeleeWeapons.Single(p => p.MeleeWeaponID == id).Range * 20;
            int ArmorIgnore = db.MeleeWeapons.Single(p => p.MeleeWeaponID == id).MelWeapArmorIgnore * 5;
            bool TwoHanded= db.MeleeWeapons.Single(p=>p.MeleeWeaponID == id).TwoHanded;
            bool Pare = db.MeleeWeapons.Single(p => p.MeleeWeaponID == id).Pare;

            int TH = 0;
            int Pr = 0;
            if (TwoHanded==true)
            {
                TH = 20;
            }
            if (Pare==true)
            {
                Pr = 20;
            }

            int? Total = Range + ArmorIgnore + Pr -TH;
            return Total ?? 0;
        }

        public int? MountPriceFromID(int? id)
        {
            int Rank = db.Mounts.Single(p => p.MountID == id).MountRank * 10;
            int Range = db.Mounts.Single(p => p.MountID == id).MountRange * 20;
            int? ArmorIgnore = db.Mounts.Single(p => p.MountID == id).MountArmorIgnore * 5;
            int? Absorb = db.Mounts.Single(p => p.MountID == id).MountAbsorb * 5;
            int? DefBonus = db.Mounts.Single(p => p.MountID == id).MountDefBonus * 5;
            int? Move = db.Mounts.Single(p => p.MountID == id).MountMove * 2;
            int? AttBonus = db.Mounts.Single(p => p.MountID == id).MountAttBonus * 5;
            bool Flying = db.Mounts.Single(p => p.MountID == id).Flying;

            int Fl = 0;
            if (Flying == true)
            {
                Fl = 20;
            }

            int? Total = Rank + AttBonus + DefBonus + Absorb + ArmorIgnore + Move + Fl + Range;
            return Total ?? 0;
        }

        public int? RangeWeapFromID(int? id)
        {
            int Range = db.RangeWeapons.Single(p => p.RangeWeaponID == id).RanWeapRange * 3;
            int? ArmorIgnore = db.RangeWeapons.Single(p => p.RangeWeaponID == id).RanWeapArmorIgnore * 6;
            int? AttBonus = db.RangeWeapons.Single(p => p.RangeWeaponID == id).RanWeapAttBonus * 6;
            
            int? Total = Range + ArmorIgnore + AttBonus;
            return Total ?? 0;
        }
    }
    

}

