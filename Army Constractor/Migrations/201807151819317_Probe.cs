namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Probe : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Units", "SecondWeaponID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Units", "SecondWeaponID", c => c.Int());
        }
    }
}
