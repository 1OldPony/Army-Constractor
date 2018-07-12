namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AfterTheFall : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Armors", "UserID", "dbo.Users");
            DropForeignKey("dbo.BaseUnits", "UserID", "dbo.Users");
            DropForeignKey("dbo.MeleeWeapons", "UserID", "dbo.Users");
            DropForeignKey("dbo.Mounts", "UserID", "dbo.Users");
            DropForeignKey("dbo.RangeWeapons", "UserID", "dbo.Users");
            DropForeignKey("dbo.Shields", "UserID", "dbo.Users");
            DropForeignKey("dbo.Units", "UserID", "dbo.Users");
            DropForeignKey("dbo.Units", "Army_ArmyID", "dbo.Armies");
            DropForeignKey("dbo.Armies", "UserID", "dbo.Users");
            DropIndex("dbo.Armies", new[] { "UserID" });
            DropIndex("dbo.Units", new[] { "UserID" });
            DropIndex("dbo.Units", new[] { "Army_ArmyID" });
            DropIndex("dbo.Armors", new[] { "UserID" });
            DropIndex("dbo.BaseUnits", new[] { "UserID" });
            DropIndex("dbo.MeleeWeapons", new[] { "UserID" });
            DropIndex("dbo.Mounts", new[] { "UserID" });
            DropIndex("dbo.RangeWeapons", new[] { "UserID" });
            DropIndex("dbo.Shields", new[] { "UserID" });
            CreateTable(
                "dbo.UnitsInArmies",
                c => new
                    {
                        UnitsInArmyID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.UnitsInArmyID);
            
            AddColumn("dbo.Armies", "UnitsInArmy_UnitsInArmyID", c => c.Int());
            AddColumn("dbo.Units", "UnitsInArmy_UnitsInArmyID", c => c.Int());
            CreateIndex("dbo.Armies", "UnitsInArmy_UnitsInArmyID");
            CreateIndex("dbo.Units", "UnitsInArmy_UnitsInArmyID");
            AddForeignKey("dbo.Units", "UnitsInArmy_UnitsInArmyID", "dbo.UnitsInArmies", "UnitsInArmyID");
            AddForeignKey("dbo.Armies", "UnitsInArmy_UnitsInArmyID", "dbo.UnitsInArmies", "UnitsInArmyID");
            DropColumn("dbo.Armies", "UserID");
            DropColumn("dbo.Units", "UserID");
            DropColumn("dbo.Units", "Army_ArmyID");
            DropColumn("dbo.Armors", "UserID");
            DropColumn("dbo.BaseUnits", "UserID");
            DropColumn("dbo.MeleeWeapons", "UserID");
            DropColumn("dbo.Mounts", "UserID");
            DropColumn("dbo.RangeWeapons", "UserID");
            DropColumn("dbo.Shields", "UserID");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.Shields", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.RangeWeapons", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Mounts", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.MeleeWeapons", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.BaseUnits", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Armors", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Units", "Army_ArmyID", c => c.Int());
            AddColumn("dbo.Units", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Armies", "UserID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Armies", "UnitsInArmy_UnitsInArmyID", "dbo.UnitsInArmies");
            DropForeignKey("dbo.Units", "UnitsInArmy_UnitsInArmyID", "dbo.UnitsInArmies");
            DropIndex("dbo.Units", new[] { "UnitsInArmy_UnitsInArmyID" });
            DropIndex("dbo.Armies", new[] { "UnitsInArmy_UnitsInArmyID" });
            DropColumn("dbo.Units", "UnitsInArmy_UnitsInArmyID");
            DropColumn("dbo.Armies", "UnitsInArmy_UnitsInArmyID");
            DropTable("dbo.UnitsInArmies");
            CreateIndex("dbo.Shields", "UserID");
            CreateIndex("dbo.RangeWeapons", "UserID");
            CreateIndex("dbo.Mounts", "UserID");
            CreateIndex("dbo.MeleeWeapons", "UserID");
            CreateIndex("dbo.BaseUnits", "UserID");
            CreateIndex("dbo.Armors", "UserID");
            CreateIndex("dbo.Units", "Army_ArmyID");
            CreateIndex("dbo.Units", "UserID");
            CreateIndex("dbo.Armies", "UserID");
            AddForeignKey("dbo.Armies", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.Units", "Army_ArmyID", "dbo.Armies", "ArmyID");
            AddForeignKey("dbo.Units", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.Shields", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.RangeWeapons", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.Mounts", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.MeleeWeapons", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.BaseUnits", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.Armors", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
