namespace Tamrin.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setpropertyfield : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.People", "LastName", c => c.String(maxLength: 30));
            AlterColumn("dbo.People", "NationalCode", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.People", "UserName", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.People", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.People", "Role", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Role", c => c.String());
            AlterColumn("dbo.People", "Password", c => c.String());
            AlterColumn("dbo.People", "UserName", c => c.String());
            AlterColumn("dbo.People", "NationalCode", c => c.String());
            AlterColumn("dbo.People", "LastName", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String());
        }
    }
}
