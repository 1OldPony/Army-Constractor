namespace Army_Constractor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentApi : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Units", "MeleeWeaponID");
            DropColumn("dbo.Units", "SecondWeaponID");
            RenameColumn(table: "dbo.Units", name: "MeleeWeapon_MeleeWeaponID", newName: "MeleeWeaponID");
            RenameColumn(table: "dbo.Units", name: "SecondWeapon_MeleeWeaponID", newName: "SecondWeaponID");
            RenameIndex(table: "dbo.Units", name: "IX_MeleeWeapon_MeleeWeaponID", newName: "IX_MeleeWeaponID");
            RenameIndex(table: "dbo.Units", name: "IX_SecondWeapon_MeleeWeaponID", newName: "IX_SecondWeaponID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Units", name: "IX_SecondWeaponID", newName: "IX_SecondWeapon_MeleeWeaponID");
            RenameIndex(table: "dbo.Units", name: "IX_MeleeWeaponID", newName: "IX_MeleeWeapon_MeleeWeaponID");
            RenameColumn(table: "dbo.Units", name: "SecondWeaponID", newName: "SecondWeapon_MeleeWeaponID");
            RenameColumn(table: "dbo.Units", name: "MeleeWeaponID", newName: "MeleeWeapon_MeleeWeaponID");
            AddColumn("dbo.Units", "SecondWeaponID", c => c.Int());
            AddColumn("dbo.Units", "MeleeWeaponID", c => c.Int());
        }
    }
}
