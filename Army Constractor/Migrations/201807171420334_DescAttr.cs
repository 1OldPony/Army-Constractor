namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescAttr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Armies", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Units", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Armors", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.MeleeWeapons", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Mounts", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.RangeWeapons", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.RecrutTypes", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Shields", "Description", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Shields", "Description", c => c.String());
            AlterColumn("dbo.RecrutTypes", "Description", c => c.String());
            AlterColumn("dbo.RangeWeapons", "Description", c => c.String());
            AlterColumn("dbo.Mounts", "Description", c => c.String());
            AlterColumn("dbo.MeleeWeapons", "Description", c => c.String());
            AlterColumn("dbo.Armors", "Description", c => c.String());
            AlterColumn("dbo.Units", "Description", c => c.String());
            AlterColumn("dbo.Armies", "Description", c => c.String());
        }
    }
}
