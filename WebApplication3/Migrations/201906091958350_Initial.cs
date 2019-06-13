namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contacts_FirstName = c.String(nullable: false, maxLength: 100),
                        Contacts_LastName = c.String(nullable: false, maxLength: 100),
                        Contacts_Email = c.String(),
                        Contacts_PhoneNumber = c.String(),
                        Status = c.Int(),
                        Financial_Profit = c.Double(nullable: false),
                        Financial_Orders = c.Double(nullable: false),
                        Address_Street = c.String(),
                        Address_City = c.String(),
                        Address_ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Companies");
        }
    }
}
