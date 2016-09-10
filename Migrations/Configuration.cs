namespace ADAS_D5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ADAS_D5.BugsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ADAS_D5.BugsContext context)
        {
            context.Employees.AddOrUpdate(x => x.Email,
                new Employee { Email = "lauris.liparts@company.com", Name = "Lauris", Surname = "Liparts" },
                new Employee { Email = "janis.ozols@company.com", Name = "Jânis", Surname = "Ozols" },
                new Employee { Email = "juris.berzins@company.com", Name = "Juris", Surname = "Bçrziòð" },
                new Employee { Email = "ilze.liepina@company.com", Name = "Ilze", Surname = "Liepiòa" }
                );
            context.Bugs.AddOrUpdate(x => x.BugId,
                new Bug { BugId = 1, Title = "Bug #01", Description = "Description of bug #01", EmployeeEmail = "lauris.liparts@company.com", Status = Status.OPEN, DueDate = new DateTime(2016, 09, 10, 12, 0, 0) },
                new Bug { BugId = 2, Title = "Bug #02", Description = "Description of bug #02", EmployeeEmail = "janis.ozols@company.com", Status = Status.FROZEN, DueDate = new DateTime(2016, 09, 11, 12, 0, 0) },
                new Bug { BugId = 3, Title = "Bug #03", Description = "Description of bug #03", EmployeeEmail = "juris.berzins@company.com", Status = Status.OPEN, DueDate = new DateTime(2016, 09, 12, 12, 0, 0) },
                new Bug { BugId = 4, Title = "Bug #04", Description = "Description of bug #04", EmployeeEmail = "ilze.liepina@company.com", Status = Status.OPEN, DueDate = new DateTime(2016, 09, 13, 12, 0, 0) },
                new Bug { BugId = 5, Title = "Bug #05", Description = "Description of bug #05", EmployeeEmail = "lauris.liparts@company.com", Status = Status.CLOSED, DueDate = new DateTime(2016, 09, 14, 12, 0, 0) },
                new Bug { BugId = 6, Title = "Bug #06", Description = "Description of bug #06", EmployeeEmail = "janis.ozols@company.com", Status = Status.OPEN, DueDate = new DateTime(2016, 09, 15, 12, 0, 0) },
                new Bug { BugId = 7, Title = "Bug #07", Description = "Description of bug #07", EmployeeEmail = "juris.berzins@company.com", Status = Status.OPEN, DueDate = new DateTime(2016, 09, 16, 12, 0, 0) },
                new Bug { BugId = 8, Title = "Bug #08", Description = "Description of bug #08", EmployeeEmail = "ilze.liepina@company.com", Status = Status.RESOLVED, DueDate = new DateTime(2016, 09, 17, 12, 0, 0) },
                new Bug { BugId = 9, Title = "Bug #09", Description = "Description of bug #09", EmployeeEmail = "lauris.liparts@company.com", Status = Status.OPEN, DueDate = new DateTime(2016, 09, 18, 12, 0, 0) },
                new Bug { BugId = 10, Title = "Bug #10", Description = "Description of bug #10", EmployeeEmail = "janis.ozols@company.com", Status = Status.RESOLVED, DueDate = new DateTime(2016, 09, 19, 12, 0, 0) }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
