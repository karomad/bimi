namespace BIMI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adduserreation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.JobModels", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.JobModels", "UserId");
            AddForeignKey("dbo.JobModels", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobModels", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.JobModels", new[] { "UserId" });
            AlterColumn("dbo.JobModels", "UserId", c => c.Int(nullable: false));
        }
    }
}
