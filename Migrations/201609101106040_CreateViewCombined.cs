namespace ADAS_D5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateViewCombined : DbMigration
    {
        public override void Up()
        {
            this.Sql(@"CREATE VIEW [dbo].[ViewCombined]
	        AS SELECT *, concat(e.Name, ' ', e.Surname) as NameSurname FROM Employees e LEFT JOIN Bugs b
	        ON e.Email = b.EmployeeEmail;");
        }
        
        public override void Down()
        {
            this.Sql(@"DROP VIEW [dbo].[ViewCombined];");
        }
    }
}
