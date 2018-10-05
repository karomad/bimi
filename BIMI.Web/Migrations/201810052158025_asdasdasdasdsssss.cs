namespace BIMI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdasdasdsssss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobModels", "FirstName", c => c.String());
            AddColumn("dbo.JobModels", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.JobModels", "LastName");
            DropColumn("dbo.JobModels", "FirstName");
        }
    }
}
