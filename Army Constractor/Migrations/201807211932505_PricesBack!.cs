namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PricesBack : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Armors", "ArmorPrice", c => c.Int(nullable: false));
            AddColumn("dbo.MeleeWeapons", "MeleeWeaponPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Mounts", "MountPrice", c => c.Int(nullable: false));
            AddColumn("dbo.RangeWeapons", "RangeWeaponPrice", c => c.Int(nullable: false));
            AddColumn("dbo.RecrutTypes", "RecrutTypePrice", c => c.Int(nullable: false));
            AddColumn("dbo.Shields", "ShieldPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shields", "ShieldPrice");
            DropColumn("dbo.RecrutTypes", "RecrutTypePrice");
            DropColumn("dbo.RangeWeapons", "RangeWeaponPrice");
            DropColumn("dbo.Mounts", "MountPrice");
            DropColumn("dbo.MeleeWeapons", "MeleeWeaponPrice");
            DropColumn("dbo.Armors", "ArmorPrice");
        }
    }
}
