using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAS_D5
{
    // Class to handle single DB connection in this application.
    static class DBAccess
    {
        // Establish DB connection and load employees.
        public static void LoadDB()
        {
            try
            {
                DB = new BugsContext();
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database! " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load employees from DB in internal structure, sort.
        public static List<Employee> LoadEmployees()
        {
            var query = from em in DB.Employees
                        orderby em.Name, em.Surname, em.Email
                        select em;
            Employees = query.ToList();
            return Employees;
        }

        // Stores bug in DB, replaces existing if exists.
        public static void InsertOrUpdateBug(Bug bug)
        {
            if (bug.BugId == 0)
                DB.Bugs.Add(bug);
            DB.SaveChanges();
        }

        // Gets bug from DB
        public static Bug GetBug(int bugId)
        {
            return DB.Bugs.First(bug => bug.BugId == bugId);
        }

        // Deletes bugs from DB.
        public static void DeleteBugs(List<int> bugIds)
        {
            DB.Bugs.RemoveRange(bugIds.Select(bugId => DB.Bugs.Find(bugId)));
            DB.SaveChanges();
        }

        public static BugsContext DB { get; private set; }
        public static List<Employee> Employees { get; private set; }

    }
}
