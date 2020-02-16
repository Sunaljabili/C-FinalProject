namespace BackEnd_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookCreated : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Books");
            AddColumn("dbo.Books", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Books", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Books", "AuthorId", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Books", "SalePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Books", "RentPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Books", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Books", "Count", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Books", "Id");
            CreateIndex("dbo.Books", "AuthorId");
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
            DropColumn("dbo.Books", "BookId");
            DropColumn("dbo.Books", "BookName");
            DropColumn("dbo.Books", "BookSubject");
            DropColumn("dbo.Books", "Date");
            DropColumn("dbo.Books", "Note");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Note", c => c.String(nullable: false, maxLength: 500));
            AddColumn("dbo.Books", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Books", "BookSubject", c => c.String(nullable: false));
            AddColumn("dbo.Books", "BookName", c => c.String(nullable: false));
            AddColumn("dbo.Books", "BookId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropPrimaryKey("dbo.Books");
            DropColumn("dbo.Books", "Count");
            DropColumn("dbo.Books", "CreatedAt");
            DropColumn("dbo.Books", "RentPrice");
            DropColumn("dbo.Books", "SalePrice");
            DropColumn("dbo.Books", "Status");
            DropColumn("dbo.Books", "AuthorId");
            DropColumn("dbo.Books", "Name");
            DropColumn("dbo.Books", "Id");
            AddPrimaryKey("dbo.Books", "BookId");
        }
    }
}
