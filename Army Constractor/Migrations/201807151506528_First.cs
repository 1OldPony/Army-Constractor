namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Units", "ArmorID", "dbo.Armors");
            DropForeignKey("dbo.Units", "MountID", "dbo.Mounts");
            DropForeignKey("dbo.Units", "RangeWeaponID", "dbo.RangeWeapons");
            DropForeignKey("dbo.Units", "ShieldID", "dbo.Shields");
            DropIndex("dbo.Units", new[] { "ArmorID" });
            DropIndex("dbo.Units", new[] { "RangeWeaponID" });
            DropIndex("dbo.Units", new[] { "ShieldID" });
            DropIndex("dbo.Units", new[] { "MountID" });
            DropPrimaryKey("dbo.UnitsInArmies");
            AlterColumn("dbo.Armies", "ArmyName", c => c.String(nullable: false));
            AlterColumn("dbo.Units", "UnitName", c => c.String(nullable: false));
            AlterColumn("dbo.Units", "ArmorID", c => c.Int());
            AlterColumn("dbo.Units", "MeleeWeaponID", c => c.Int());
            AlterColumn("dbo.Units", "RangeWeaponID", c => c.Int());
            AlterColumn("dbo.Units", "SecondWeaponID", c => c.Int());
            AlterColumn("dbo.Units", "ShieldID", c => c.Int());
            AlterColumn("dbo.Units", "MountID", c => c.Int());
            AlterColumn("dbo.Armors", "ArmorMoveDecrease", c => c.Int());
            AlterColumn("dbo.MeleeWeapons", "MelWeapName", c => c.String(nullable: false));
            AlterColumn("dbo.Mounts", "MountName", c => c.String(nullable: false));
            AlterColumn("dbo.Mounts", "MountArmorIgnore", c => c.Int());
            AlterColumn("dbo.Mounts", "MountAbsorb", c => c.Int());
            AlterColumn("dbo.RangeWeapons", "RanWeapName", c => c.String(nullable: false));
            AlterColumn("dbo.RangeWeapons", "RanWeapArmorIgnore", c => c.Int());
            AlterColumn("dbo.RecrutTypes", "RecrutTypeName", c => c.String(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeAbsorb", c => c.Int());
            AlterColumn("dbo.RecrutTypes", "RecrutTypeArmorIgnore", c => c.Int());
            AlterColumn("dbo.RecrutTypes", "RecrutTypeBraveryBonus", c => c.Int());
            AlterColumn("dbo.Shields", "ShieldName", c => c.String(nullable: false));
            AddPrimaryKey("dbo.UnitsInArmies", new[] { "UnitID", "ArmyID" });
            CreateIndex("dbo.Units", "ArmorID");
            CreateIndex("dbo.Units", "RangeWeaponID");
            CreateIndex("dbo.Units", "ShieldID");
            CreateIndex("dbo.Units", "MountID");
            AddForeignKey("dbo.Units", "ArmorID", "dbo.Armors", "ArmorID");
            AddForeignKey("dbo.Units", "MountID", "dbo.Mounts", "MountID");
            AddForeignKey("dbo.Units", "RangeWeaponID", "dbo.RangeWeapons", "RangeWeaponID");
            AddForeignKey("dbo.Units", "ShieldID", "dbo.Shields", "ShieldID");
            DropColumn("dbo.UnitsInArmies", "UnitsInArmyID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UnitsInArmies", "UnitsInArmyID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Units", "ShieldID", "dbo.Shields");
            DropForeignKey("dbo.Units", "RangeWeaponID", "dbo.RangeWeapons");
            DropForeignKey("dbo.Units", "MountID", "dbo.Mounts");
            DropForeignKey("dbo.Units", "ArmorID", "dbo.Armors");
            DropIndex("dbo.Units", new[] { "MountID" });
            DropIndex("dbo.Units", new[] { "ShieldID" });
            DropIndex("dbo.Units", new[] { "RangeWeaponID" });
            DropIndex("dbo.Units", new[] { "ArmorID" });
            DropPrimaryKey("dbo.UnitsInArmies");
            AlterColumn("dbo.Shields", "ShieldName", c => c.String());
            AlterColumn("dbo.RecrutTypes", "RecrutTypeBraveryBonus", c => c.Int(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeArmorIgnore", c => c.Int(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeAbsorb", c => c.Int(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeName", c => c.String());
            AlterColumn("dbo.RangeWeapons", "RanWeapArmorIgnore", c => c.Int(nullable: false));
            AlterColumn("dbo.RangeWeapons", "RanWeapName", c => c.String());
            AlterColumn("dbo.Mounts", "MountAbsorb", c => c.Int(nullable: false));
            AlterColumn("dbo.Mounts", "MountArmorIgnore", c => c.Int(nullable: false));
            AlterColumn("dbo.Mounts", "MountName", c => c.String());
            AlterColumn("dbo.MeleeWeapons", "MelWeapName", c => c.String());
            AlterColumn("dbo.Armors", "ArmorMoveDecrease", c => c.Int(nullable: false));
            AlterColumn("dbo.Units", "MountID", c => c.Int(nullable: false));
            AlterColumn("dbo.Units", "ShieldID", c => c.Int(nullable: false));
            AlterColumn("dbo.Units", "SecondWeaponID", c => c.Int(nullable: false));
            AlterColumn("dbo.Units", "RangeWeaponID", c => c.Int(nullable: false));
            AlterColumn("dbo.Units", "MeleeWeaponID", c => c.Int(nullable: false));
            AlterColumn("dbo.Units", "ArmorID", c => c.Int(nullable: false));
            AlterColumn("dbo.Units", "UnitName", c => c.String());
            AlterColumn("dbo.Armies", "ArmyName", c => c.String());
            AddPrimaryKey("dbo.UnitsInArmies", "UnitsInArmyID");
            CreateIndex("dbo.Units", "MountID");
            CreateIndex("dbo.Units", "ShieldID");
            CreateIndex("dbo.Units", "RangeWeaponID");
            CreateIndex("dbo.Units", "ArmorID");
            AddForeignKey("dbo.Units", "ShieldID", "dbo.Shields", "ShieldID", cascadeDelete: true);
            AddForeignKey("dbo.Units", "RangeWeaponID", "dbo.RangeWeapons", "RangeWeaponID", cascadeDelete: true);
            AddForeignKey("dbo.Units", "MountID", "dbo.Mounts", "MountID", cascadeDelete: true);
            AddForeignKey("dbo.Units", "ArmorID", "dbo.Armors", "ArmorID", cascadeDelete: true);
        }
    }
}
