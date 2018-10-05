namespace BIMI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsParent", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsParent");
        }
    }
}
