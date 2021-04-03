namespace EmployeeServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Departments", "Nmae");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Nmae", c => c.String(nullable: false));
            DropColumn("dbo.Departments", "Name");
        }
    }
}
