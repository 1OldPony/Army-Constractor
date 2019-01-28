namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Denullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Armors", "ArmorMoveDecrease", c => c.Int(nullable: false));
            AlterColumn("dbo.Mounts", "MountArmorIgnore", c => c.Int(nullable: false));
            AlterColumn("dbo.Mounts", "MountAbsorb", c => c.Int(nullable: false));
            AlterColumn("dbo.RangeWeapons", "RanWeapArmorIgnore", c => c.Int(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeAttBonus", c => c.Int(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeDefBonus", c => c.Int(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeAbsorb", c => c.Int(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeArmorIgnore", c => c.Int(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeBraveryBonus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RecrutTypes", "RecrutTypeBraveryBonus", c => c.Int());
            AlterColumn("dbo.RecrutTypes", "RecrutTypeArmorIgnore", c => c.Int());
            AlterColumn("dbo.RecrutTypes", "RecrutTypeAbsorb", c => c.Int());
            AlterColumn("dbo.RecrutTypes", "RecrutTypeDefBonus", c => c.Int());
            AlterColumn("dbo.RecrutTypes", "RecrutTypeAttBonus", c => c.Int());
            AlterColumn("dbo.RangeWeapons", "RanWeapArmorIgnore", c => c.Int());
            AlterColumn("dbo.Mounts", "MountAbsorb", c => c.Int());
            AlterColumn("dbo.Mounts", "MountArmorIgnore", c => c.Int());
            AlterColumn("dbo.Armors", "ArmorMoveDecrease", c => c.Int());
        }
    }
}
