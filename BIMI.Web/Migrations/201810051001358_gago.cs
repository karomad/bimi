namespace BIMI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gago : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Description = c.String(),
                        MoneyRange = c.String(),
                        isParent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JobModels");
        }
    }
}
