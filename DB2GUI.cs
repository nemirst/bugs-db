using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAS_D5
{
    static class DB2GUI
    {
        // Extract email between brackets.
        public static string EmailFromAssignedText(string comboboxItemStr)
        {
            return comboboxItemStr.Split(new char[] { '<', '>' })[1];
        }

        // Employee to string (name surname <email>)
        public static string AssignedString(Employee em)
        {
            return em.Name + " " + em.Surname + " <" + em.Email + ">";
        }

        // Fills provided combobox items with employees stored in DB.
        public static void FillEmployeeCombobox(ComboBox cb, bool firstEmpty = false)
        {
            cb.Items.Clear();
            if (firstEmpty)
                cb.Items.Add("");
            cb.Items.AddRange(DBAccess.Employees.Select(
                em => AssignedString(em)).ToArray());
            if (cb.Items.Count > 0)
                cb.SelectedIndex = 0;
        }
    }
}
