namespace PSPProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "email", c => c.String());
            AddColumn("dbo.Employees", "adress", c => c.String());
            AddColumn("dbo.Employees", "photo", c => c.String());
            DropColumn("dbo.Employees", "position");
            DropColumn("dbo.Employees", "hireDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "hireDate", c => c.String());
            AddColumn("dbo.Employees", "position", c => c.String());
            DropColumn("dbo.Employees", "photo");
            DropColumn("dbo.Employees", "adress");
            DropColumn("dbo.Employees", "email");
        }
    }
}
