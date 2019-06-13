namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Address_State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "Address_State");
        }
    }
}
