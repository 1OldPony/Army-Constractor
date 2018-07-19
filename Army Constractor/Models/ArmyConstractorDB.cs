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

        public DbSet<Armor> Armors { get; set; }
        public DbSet<Army> Armies { get; set; }
        public DbSet<MeleeWeapon> MeleeWeapons { get; set; }
        public DbSet<Mount> Mounts { get; set; }
        public DbSet<RangeWeapon> RangeWeapons { get; set; }
        public DbSet<RecrutType> RecrutTypes { get; set; }
        public DbSet<Shield> Shields { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitsInArmy> UnitsInArmies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Unit>()
                .HasOptional(u=>u.MeleeWeapon)
                .WithOptionalDependent()
                .Map(c=>c.MapKey("MeleeWeaponID"));

            modelBuilder.Entity<Unit>()
                .HasOptional(u => u.SecondWeapon)
                .WithOptionalDependent()
                .Map(c => c.MapKey("SecondWeaponID"));
        }
    }
}
