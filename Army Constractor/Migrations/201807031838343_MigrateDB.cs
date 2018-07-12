namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armies",
                c => new
                    {
                        ArmyID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ArmyName = c.String(),
                        ArmyPrice = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ArmyID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UnitName = c.String(),
                        BaseUnitID = c.Int(nullable: false),
                        ArmorID = c.Int(nullable: false),
                        MeleeWeaponID = c.Int(nullable: false),
                        RangeWeaponID = c.Int(nullable: false),
                        SecondWeaponID = c.Int(nullable: false),
                        ShieldID = c.Int(nullable: false),
                        MountID = c.Int(nullable: false),
                        NumberOfCombatants = c.Int(nullable: false),
                        UnitTotalPrice = c.Int(nullable: false),
                        Description = c.String(),
                        Army_ArmyID = c.Int(),
                    })
                .PrimaryKey(t => t.UnitID)
                .ForeignKey("dbo.Armors", t => t.ArmorID, cascadeDelete: false)
                .ForeignKey("dbo.BaseUnits", t => t.BaseUnitID, cascadeDelete: false)
                .ForeignKey("dbo.Mounts", t => t.MountID, cascadeDelete: false)
                .ForeignKey("dbo.RangeWeapons", t => t.RangeWeaponID, cascadeDelete: false)
                .ForeignKey("dbo.Shields", t => t.ShieldID, cascadeDelete: false)
                .ForeignKey("dbo.MeleeWeapons", t => t.MeleeWeaponID, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .ForeignKey("dbo.Armies", t => t.Army_ArmyID)
                .Index(t => t.UserID)
                .Index(t => t.BaseUnitID)
                .Index(t => t.ArmorID)
                .Index(t => t.RangeWeaponID)
                .Index(t => t.ShieldID)
                .Index(t => t.MountID)
                .Index(t => t.Army_ArmyID);
            
            CreateTable(
                "dbo.Armors",
                c => new
                    {
                        ArmorID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ArmorName = c.String(),
                        ArmorAbsorb = c.Int(nullable: false),
                        ArmorMoveDecrease = c.Int(nullable: false),
                        ArmorPrice = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ArmorID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        RegisterDate = c.String(),
                        AdminComment = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.BaseUnits",
                c => new
                    {
                        BaseUnitID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        BaseUnitName = c.String(),
                        BaseUnitRank = c.Int(nullable: false),
                        BaseUnitAttBonus = c.Int(nullable: false),
                        BaseUnitDefBonus = c.Int(nullable: false),
                        BaseUnitAbsorb = c.Int(nullable: false),
                        BaseUnitArmorIgnore = c.Int(nullable: false),
                        BaseUnitMove = c.Int(nullable: false),
                        BaseUnitBraveryBonus = c.Int(nullable: false),
                        BaseUnitPrice = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.BaseUnitID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.MeleeWeapons",
                c => new
                    {
                        MeleeWeaponID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        MelWeapName = c.String(),
                        Range = c.Int(nullable: false),
                        MelWeapArmorIgnore = c.Int(nullable: false),
                        TwoHanded = c.Boolean(nullable: false),
                        Pare = c.Boolean(nullable: false),
                        MelWeapPrice = c.Int(nullable: false),
                        Description = c.String(),
                        Unit_UnitID = c.Int(),
                    })
                .PrimaryKey(t => t.MeleeWeaponID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .ForeignKey("dbo.Units", t => t.Unit_UnitID)
                .Index(t => t.UserID)
                .Index(t => t.Unit_UnitID);
            
            CreateTable(
                "dbo.Mounts",
                c => new
                    {
                        MountID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        MountName = c.String(),
                        MountRange = c.Int(nullable: false),
                        MountRank = c.Int(nullable: false),
                        MountArmorIgnore = c.Int(nullable: false),
                        MountAbsorb = c.Int(nullable: false),
                        MountDefBonus = c.Int(nullable: false),
                        MountAttBonus = c.Int(nullable: false),
                        MountMove = c.Int(nullable: false),
                        Flying = c.Boolean(nullable: false),
                        MountPrice = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MountID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.RangeWeapons",
                c => new
                    {
                        RangeWeaponID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        RanWeapName = c.String(),
                        RanWeapRange = c.Int(nullable: false),
                        RanWeapArmorIgnore = c.Int(nullable: false),
                        RanWeapPrice = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RangeWeaponID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Shields",
                c => new
                    {
                        ShieldID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ShieldName = c.String(),
                        ShieldDefBonus = c.Int(nullable: false),
                        ShieldPrice = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ShieldID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Armies", "UserID", "dbo.Users");
            DropForeignKey("dbo.Units", "Army_ArmyID", "dbo.Armies");
            DropForeignKey("dbo.Units", "UserID", "dbo.Users");
            DropForeignKey("dbo.Units", "ShieldID", "dbo.Shields");
            DropForeignKey("dbo.Shields", "UserID", "dbo.Users");
            DropForeignKey("dbo.Units", "RangeWeaponID", "dbo.RangeWeapons");
            DropForeignKey("dbo.RangeWeapons", "UserID", "dbo.Users");
            DropForeignKey("dbo.Units", "MountID", "dbo.Mounts");
            DropForeignKey("dbo.Mounts", "UserID", "dbo.Users");
            DropForeignKey("dbo.MeleeWeapons", "Unit_UnitID", "dbo.Units");
            DropForeignKey("dbo.MeleeWeapons", "UserID", "dbo.Users");
            DropForeignKey("dbo.Units", "BaseUnitID", "dbo.BaseUnits");
            DropForeignKey("dbo.BaseUnits", "UserID", "dbo.Users");
            DropForeignKey("dbo.Units", "ArmorID", "dbo.Armors");
            DropForeignKey("dbo.Armors", "UserID", "dbo.Users");
            DropIndex("dbo.Shields", new[] { "UserID" });
            DropIndex("dbo.RangeWeapons", new[] { "UserID" });
            DropIndex("dbo.Mounts", new[] { "UserID" });
            DropIndex("dbo.MeleeWeapons", new[] { "Unit_UnitID" });
            DropIndex("dbo.MeleeWeapons", new[] { "UserID" });
            DropIndex("dbo.BaseUnits", new[] { "UserID" });
            DropIndex("dbo.Armors", new[] { "UserID" });
            DropIndex("dbo.Units", new[] { "Army_ArmyID" });
            DropIndex("dbo.Units", new[] { "MountID" });
            DropIndex("dbo.Units", new[] { "ShieldID" });
            DropIndex("dbo.Units", new[] { "RangeWeaponID" });
            DropIndex("dbo.Units", new[] { "ArmorID" });
            DropIndex("dbo.Units", new[] { "BaseUnitID" });
            DropIndex("dbo.Units", new[] { "UserID" });
            DropIndex("dbo.Armies", new[] { "UserID" });
            DropTable("dbo.Shields");
            DropTable("dbo.RangeWeapons");
            DropTable("dbo.Mounts");
            DropTable("dbo.MeleeWeapons");
            DropTable("dbo.BaseUnits");
            DropTable("dbo.Users");
            DropTable("dbo.Armors");
            DropTable("dbo.Units");
            DropTable("dbo.Armies");
        }
    }
}
