namespace BackEnd_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookAndCustomerAndAuthorAndReportAndManagerAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RentPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedAt = c.DateTime(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 150),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        İd = c.Int(nullable: false, identity: true),
                        Managerİd = c.Int(nullable: false),
                        CustomerId = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        DeadLine = c.DateTime(nullable: false),
                        Note = c.String(maxLength: 500),
                        IsDone = c.Boolean(nullable: false),
                        DoneUserId = c.Int(),
                        DoneAt = c.DateTime(nullable: false),
                        Result = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.İd);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Reports");
            DropTable("dbo.Managers");
            DropTable("dbo.Customers");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
