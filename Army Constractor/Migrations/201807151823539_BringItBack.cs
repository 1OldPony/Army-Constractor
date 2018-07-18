namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BringItBack : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Units", "SecondWeaponID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Units", "SecondWeaponID");
        }
    }
}
