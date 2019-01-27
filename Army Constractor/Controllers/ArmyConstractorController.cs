using Army_Constractor.Models;
using Army_Constractor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Army_Constractor.Controllers
{
    public class ArmyConstractorController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        public ActionResult Search(FormCollection values)
        {
            
            var UnitInfo = db.Units.Include("Armor").Include("RangeWeapon").Include("RecrutType").Include("Shield").Include("MeleeWeapon").Include("Mount").ToList();
            var MeleeWeaponInfo = db.MeleeWeapons.ToList();
            var RangeWeaponInfo = db.RangeWeapons.ToList();
            var ArmorInfo = db.Armors.ToList();
            var RecrutTypeInfo = db.RecrutTypes.ToList();
            var MountInfo = db.Mounts.ToList();
            var ShieldInfo = db.Shields.ToList();
            

            UnitInfo = UnitInfo.Where(p => p.UnitName.ToLower().Contains(values["SearchString"].ToLower()) ||
                                                    p.MeleeWeapon.MelWeapName.ToLower().Contains(values["SearchString"].ToLower()) ||
                                                    p.RangeWeapon.RanWeapName.ToLower().Contains(values["SearchString"].ToLower()) ||
                                                    p.Armor.ArmorName.ToLower().Contains(values["SearchString"].ToLower()) ||
                                                    p.RecrutType.RecrutTypeName.ToLower().Contains(values["SearchString"].ToLower()) ||
                                                    p.Mount.MountName.ToLower().Contains(values["SearchString"].ToLower()) ||
                                                    p.Shield.ShieldName.ToLower().Contains(values["SearchString"].ToLower())).ToList();

            MeleeWeaponInfo = MeleeWeaponInfo.Where(p => p.MelWeapName.ToLower().Contains(values["SearchString"].ToLower())).ToList();

            RangeWeaponInfo = RangeWeaponInfo.Where(p => p.RanWeapName.ToLower().Contains(values["SearchString"].ToLower())).ToList();

            ArmorInfo = ArmorInfo.Where(p => p.ArmorName.ToLower().Contains(values["SearchString"].ToLower())).ToList();

            RecrutTypeInfo = RecrutTypeInfo.Where(p => p.RecrutTypeName.ToLower().Contains(values["SearchString"].ToLower())).ToList();

            MountInfo = MountInfo.Where(p => p.MountName.ToLower().Contains(values["SearchString"].ToLower())).ToList();

            ShieldInfo = ShieldInfo.Where(p => p.ShieldName.ToLower().Contains(values["SearchString"].ToLower())).ToList();


            SearchResults ViewModel = new SearchResults()
            {
                Armors = ArmorInfo,
                MeleeWeapons = MeleeWeaponInfo,
                RecrutTypes = RecrutTypeInfo,
                Mounts = MountInfo,
                RangeWeapons = RangeWeaponInfo,
                Shields = ShieldInfo,
                Units = UnitInfo
            };


            return View(ViewModel);
        }
    }
}