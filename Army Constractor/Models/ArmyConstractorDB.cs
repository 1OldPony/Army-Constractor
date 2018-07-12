using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class ArmyConstractorDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ArmyConstractorDB() : base("name=ArmyConstractorDB")
        {
        }

        public System.Data.Entity.DbSet<Army_Constractor.Models.Army> Armies { get; set; }
        public System.Data.Entity.DbSet<Army_Constractor.Models.Armor> Armors { get; set; }
        public System.Data.Entity.DbSet<Army_Constractor.Models.BaseUnit> BaseUnits { get; set; }
        public System.Data.Entity.DbSet<Army_Constractor.Models.MeleeWeapon> MeleeWeapons { get; set; }
        public System.Data.Entity.DbSet<Army_Constractor.Models.Mount> Mounts { get; set; }
        public System.Data.Entity.DbSet<Army_Constractor.Models.RangeWeapon> RangeWeapons { get; set; }
        public System.Data.Entity.DbSet<Army_Constractor.Models.Shield> Shields { get; set; }
        public System.Data.Entity.DbSet<Army_Constractor.Models.Unit> Units { get; set; }
        public System.Data.Entity.DbSet<Army_Constractor.Models.UnitsInArmy> UnitsInArmies { get; set; }
    }
}
