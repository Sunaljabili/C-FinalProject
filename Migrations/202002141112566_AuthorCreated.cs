namespace BackEnd_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Authors");
        }
    }
}
