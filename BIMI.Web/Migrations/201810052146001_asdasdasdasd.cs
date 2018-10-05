namespace BIMI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdasdasd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobModels", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobModels", "UserName");
        }
    }
}
