namespace BackEnd_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerIdAdded : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
