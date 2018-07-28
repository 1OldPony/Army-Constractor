namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class What : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Armors", "ArmorPrice");
            DropColumn("dbo.MeleeWeapons", "MeleeWeaponPrice");
            DropColumn("dbo.Mounts", "MountPrice");
            DropColumn("dbo.RangeWeapons", "RangeWeaponPrice");
            DropColumn("dbo.RecrutTypes", "RecrutTypePrice");
            DropColumn("dbo.Shields", "ShieldPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shields", "ShieldPrice", c => c.Int(nullable: false));
            AddColumn("dbo.RecrutTypes", "RecrutTypePrice", c => c.Int(nullable: false));
            AddColumn("dbo.RangeWeapons", "RangeWeaponPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Mounts", "MountPrice", c => c.Int(nullable: false));
            AddColumn("dbo.MeleeWeapons", "MeleeWeaponPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Armors", "ArmorPrice", c => c.Int(nullable: false));
        }
    }
}
