namespace BackEnd_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorAdd : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Authors");
            AddColumn("dbo.Authors", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Authors", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Authors");
            DropColumn("dbo.Authors", "Id");
            AddPrimaryKey("dbo.Authors", "Name");
        }
    }
}
