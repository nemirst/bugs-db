using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ADAS_D5
{
    public enum Status { FROZEN, OPEN, RESOLVED, CLOSED }
    // Bug entity.
    public class Bug
    {
        public int BugId { get; set; }
        public string Title { get; set; }
        public string EmployeeEmail { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }
        // Employee to whom this bug is assigned (not stored in corresponding DB table)
        public virtual Employee Employee { get; set; }
    }
    
    // Employee entity.
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [Key]
        public string Email { get; set; }
        // Bugs assigned to employee (not stored in corresponding DB table)
        public virtual List<Bug> Bugs { get; set; }
    }

    // Database context, holds all entities.
    public class BugsContext : DbContext
    {
        public BugsContext(string name) : base("name=" + name) {}
        public BugsContext() : this("externalDB") {}
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
