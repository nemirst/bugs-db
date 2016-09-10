namespace ADAS_D5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bugs",
                c => new
                    {
                        BugId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        EmployeeEmail = c.String(maxLength: 128),
                        Description = c.String(),
                        DueDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BugId)
                .ForeignKey("dbo.Employees", t => t.EmployeeEmail)
                .Index(t => t.EmployeeEmail);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bugs", "EmployeeEmail", "dbo.Employees");
            DropIndex("dbo.Bugs", new[] { "EmployeeEmail" });
            DropTable("dbo.Employees");
            DropTable("dbo.Bugs");
        }
    }
}
