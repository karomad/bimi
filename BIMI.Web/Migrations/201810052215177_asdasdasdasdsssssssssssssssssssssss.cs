namespace BIMI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdasdasdsssssssssssssssssssssss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Image");
        }
    }
}
