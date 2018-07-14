namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Army_Constractor.Models.ArmyConstractorDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Army_Constractor.Models.ArmyConstractorDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Armors.AddOrUpdate(
            //a => a.ArmorName,
            new Models.Armor { ArmorName = "Кожаный жилет", ArmorAbsorb = 1 },
            new Models.Armor { ArmorName = "Кожанная куртка", ArmorAbsorb = 2 },
            new Models.Armor { ArmorName = "Стега", ArmorAbsorb = 3 },
            new Models.Armor { ArmorName = "Стега толстая", ArmorAbsorb = 4, ArmorMoveDecrease = 1 },
            new Models.Armor { ArmorName = "Тегиляй", ArmorAbsorb = 5, ArmorMoveDecrease = 2 }
            );
        }
    }
}
