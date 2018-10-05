namespace BIMI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "test", c => c.Int(nullable: false));
        }
    }
}
