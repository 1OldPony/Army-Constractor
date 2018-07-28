namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceAndArmies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UnitsInArmies", "ArmyID", "dbo.Armies");
            DropForeignKey("dbo.UnitsInArmies", "UnitID", "dbo.Units");
            DropIndex("dbo.UnitsInArmies", new[] { "UnitID" });
            DropIndex("dbo.UnitsInArmies", new[] { "ArmyID" });
            DropTable("dbo.Armies");
            DropTable("dbo.UnitsInArmies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UnitsInArmies",
                c => new
                    {
                        UnitID = c.Int(nullable: false),
                        ArmyID = c.Int(nullable: false),
                        NumberOfUnits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UnitID, t.ArmyID });
            
            CreateTable(
                "dbo.Armies",
                c => new
                    {
                        ArmyID = c.Int(nullable: false, identity: true),
                        ArmyName = c.String(nullable: false),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ArmyID);
            
            CreateIndex("dbo.UnitsInArmies", "ArmyID");
            CreateIndex("dbo.UnitsInArmies", "UnitID");
            AddForeignKey("dbo.UnitsInArmies", "UnitID", "dbo.Units", "UnitID", cascadeDelete: true);
            AddForeignKey("dbo.UnitsInArmies", "ArmyID", "dbo.Armies", "ArmyID", cascadeDelete: true);
        }
    }
}
