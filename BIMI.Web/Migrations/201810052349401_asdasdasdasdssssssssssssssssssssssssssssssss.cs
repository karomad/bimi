namespace BIMI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdasdasdssssssssssssssssssssssssssssssss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobModels", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobModels", "Image");
        }
    }
}
