namespace AddingTheme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.contact", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.contact", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.contact", "Subject", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.contact", "Message", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.contact", "PhoneNumber", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.contact", "PhoneNumber", c => c.String());
            AlterColumn("dbo.contact", "Message", c => c.String());
            AlterColumn("dbo.contact", "Subject", c => c.String());
            AlterColumn("dbo.contact", "Email", c => c.String());
            AlterColumn("dbo.contact", "Name", c => c.String());
        }
    }
}
