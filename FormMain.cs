using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAS_D5
{
    public partial class FormMain : Form
    {
        private FormReportBug formReportBug;
        private FormReports formReports;
        private SourceFilters sourceFilters;

        public FormMain()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();

            // Custom initialization.
            DBAccess.LoadDB();
            formReportBug = new FormReportBug();
            formReports = new FormReports();
            sourceFilters = new SourceFilters();
            Cursor.Current = Cursors.AppStarting;
        }

        // Reloads gridview from DB
        public void ReloadBugs()
        {
            // TODO: This line of code loads data into the '_ADAS_D5_BugsContextDataSet.Bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this._ADAS_D5_BugsContextDataSet.Bugs);
            dataGridView1.Select();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ReloadBugs();
            // TODO: This line of code loads data into the '_ADAS_D5_BugsContextDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._ADAS_D5_BugsContextDataSet.Employees);

            // Initialize filter components
            groupBoxFilters.Enabled = false;

            checkedListBoxStatus.Items.AddRange(Enum.GetNames(typeof(Status)));
            for (int x = 0; x < checkedListBoxStatus.Items.Count; x++)
                checkedListBoxStatus.SetItemChecked(x, true);

            DB2GUI.FillEmployeeCombobox(comboBoxAssigned, true);

            groupBoxFilters.Enabled = true;
        }

        private void checkedListBoxStatus_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBoxStatus.Enabled == false)  // Why does it fire events in disabled state?
                return;

            // Setup Status filter
            Func<int, string> status_str = s => String.Format("'{0}'", s);
            List<string> showStatuses = new List<string>(
                checkedListBoxStatus.CheckedIndices.Cast<int>().Select(status_str));

            if (e.NewValue == CheckState.Checked)
                showStatuses.Add(status_str(e.Index));
            else
                showStatuses.Remove(status_str(e.Index));;

            if (showStatuses.Count == 0)
                sourceFilters.Add("Status", "False");
            else
                sourceFilters.Add("Status", string.Format("[Status] in ({0})", string.Join(", ", showStatuses)));
            bugsBindingSource.Filter = sourceFilters.Compose();
        }

        private void buttonReportNew_Click(object sender, EventArgs e)
        {
            // Open form for bug reporting
            formReportBug.StartupMode = StartupMode.REPORT;
            formReportBug.ShowDialog();
            ReloadBugs();
        }

        private void comboBoxAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAssigned.Enabled == false)  // Why does it fire events in disabled state?
                return;
            // Setup email filter
            string selectedEmployee = (string)((ComboBox)sender).SelectedItem;
            if (selectedEmployee == "")
                sourceFilters.Remove("EmployeeEmail");
            else
            {
                string employeeEmail = DB2GUI.EmailFromAssignedText(selectedEmployee);
                sourceFilters.Add("EmployeeEmail", String.Format("[EmployeeEmail] = '{0}'", employeeEmail));
            }
            bugsBindingSource.Filter = sourceFilters.Compose();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            // Setup title filter
            string bugTitle = ((TextBox)sender).Text;
            if (bugTitle.Length == 0)
                sourceFilters.Remove("Title");
            else
                sourceFilters.Add("Title", String.Format("[Title] LIKE '%{0}%'", bugTitle));
            bugsBindingSource.Filter = sourceFilters.Compose();
        }

        private void StartBugEdit()
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            // Open bug editing form
            formReportBug.StartupMode = StartupMode.EDIT;
            var row = dataGridView1.SelectedRows.Cast<DataGridViewRow>().First();
            formReportBug.EditModeBugId = (int)row.Cells[BugId.Index].Value;
            formReportBug.ShowDialog();
            ReloadBugs();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    // User tries to delete row from gridview
                    DialogResult res = MessageBox.Show("Selected bugs will be deleted. Proceed?", "", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (res != DialogResult.Yes)
                        e.Handled = true;
                    else
                    {
                        var selectedRows = dataGridView1.SelectedRows.Cast<DataGridViewRow>();
                        var toDeleteList = selectedRows.Select(row => row.Cells[BugId.Index].Value).Cast<int>().ToList();
                        DBAccess.DeleteBugs(toDeleteList);
                    }
                    break;
                case Keys.Enter:
                    // User tries to edit bug from gridview
                    StartBugEdit();
                    e.Handled = true;
                    break;
            }
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            // Open reports form
            formReports.ShowDialog();
        }
    }

    // Class to filtration by multiple parameters.
    public class SourceFilters
    {
        private Dictionary<string, string> filters = new Dictionary<string, string>();

        // Adds new filter.
        public void Add(string filterType, string newFilter)
        {
            filters[filterType] = newFilter;
        }

        // Removes filter if exists.
        public void Remove(string filterType)
        {
            if(filters.ContainsKey(filterType))
                filters.Remove(filterType);
        }

        // Creates filter string in Expression language. Can be used to setup binding source filter.
        public string Compose()
        {
            if (filters.Count == 0)
                return "";

            var combined_filter = "";
            var last = filters.Last();
            var first = filters.First();
            foreach (var entry in filters)
                if (entry.Equals(last))
                    if (entry.Equals(first))
                        combined_filter += entry.Value;
                    else
                        combined_filter += String.Format("({0})", entry.Value);
                else
                    combined_filter += String.Format("({0}) AND ", entry.Value);

            return combined_filter;
        }
    }
}
