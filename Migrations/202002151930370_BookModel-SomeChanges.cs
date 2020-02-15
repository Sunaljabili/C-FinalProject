namespace BackEnd_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookModelSomeChanges : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Books");
            AddColumn("dbo.Books", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Books", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Books", "Author", c => c.String(nullable: false));
            AddColumn("dbo.Books", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Books", "SalePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Books", "RentPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddPrimaryKey("dbo.Books", "Id");
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
            DropPrimaryKey("dbo.Books");
            DropColumn("dbo.Books", "RentPrice");
            DropColumn("dbo.Books", "SalePrice");
            DropColumn("dbo.Books", "Status");
            DropColumn("dbo.Books", "Author");
            DropColumn("dbo.Books", "Name");
            DropColumn("dbo.Books", "Id");
            AddPrimaryKey("dbo.Books", "BookId");
        }
    }
}
