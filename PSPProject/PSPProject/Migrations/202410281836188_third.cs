namespace PSPProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "firstName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Employees", "lastName", c => c.String(maxLength: 80));
            AlterColumn("dbo.Employees", "email", c => c.String(maxLength: 200));
            AlterColumn("dbo.Employees", "phoneNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Employees", "adress", c => c.String(maxLength: 200));
            AlterColumn("dbo.Employees", "photo", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "photo", c => c.String());
            AlterColumn("dbo.Employees", "adress", c => c.String());
            AlterColumn("dbo.Employees", "phoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "email", c => c.String());
            AlterColumn("dbo.Employees", "lastName", c => c.String());
            AlterColumn("dbo.Employees", "firstName", c => c.String());
        }
    }
}
