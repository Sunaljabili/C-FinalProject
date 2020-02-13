namespace BackEnd_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookAndCustomerAndManagerAndReportCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookName = c.String(nullable: false),
                        BookSubject = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.BookId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
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
            DropTable("dbo.Reports");
            DropTable("dbo.Managers");
            DropTable("dbo.Customers");
            DropTable("dbo.Books");
        }
    }
}
