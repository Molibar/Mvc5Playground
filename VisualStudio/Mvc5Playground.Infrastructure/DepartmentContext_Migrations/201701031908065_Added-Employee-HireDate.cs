namespace Mvc5Playground.Infrastructure.DepartmentContext_Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmployeeHireDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "HireDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "HireDate");
        }
    }
}
