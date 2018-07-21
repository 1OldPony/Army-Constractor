namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RangAtt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RangeWeapons", "RanWeapAttBonus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RangeWeapons", "RanWeapAttBonus");
        }
    }
}
