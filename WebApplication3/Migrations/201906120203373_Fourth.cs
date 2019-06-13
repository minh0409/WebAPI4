namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fourth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "Status", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "Status", c => c.Int());
        }
    }
}
