namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RecrutTypes", "RecrutTypeAttBonus", c => c.Int());
            AlterColumn("dbo.RecrutTypes", "RecrutTypeDefBonus", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RecrutTypes", "RecrutTypeDefBonus", c => c.Int(nullable: false));
            AlterColumn("dbo.RecrutTypes", "RecrutTypeAttBonus", c => c.Int(nullable: false));
        }
    }
}
