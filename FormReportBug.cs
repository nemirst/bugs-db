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
    // REPORT - report new bug; EDIT - edit existing bug.
    public enum StartupMode { REPORT, EDIT };

    // Form for bug reporting and editing.
    public partial class FormReportBug : Form
    {
        public StartupMode StartupMode { get; set; }
        public int EditModeBugId { get; set; }
        private Bug editModeBug;

        public FormReportBug()
        {
            InitializeComponent();
            StartupMode = StartupMode.REPORT;
            EditModeBugId = -1;
        }

        private void FormReportBug_Load(object sender, EventArgs e)
        {
            // Fill Status ComboBox
            if (comboBoxStatus.Items.Count == 0)
                comboBoxStatus.Items.AddRange(Enum.GetNames(typeof(Status)));
            DB2GUI.FillEmployeeCombobox(comboBoxAssigned);

            if (StartupMode == StartupMode.REPORT)
            {  // Report mode - fill fields with default values.
                Text = "Report Bug";
                buttonCreate.Text = "Create";
                textBoxTitle.Text = "";
                textBoxDescription.Text = "";
                dateTimePickerDue.Value = DateTime.Now;
                comboBoxStatus.SelectedIndex = 0;
                textBoxTitle.Select();
            }
            else  // Edit mode - fill fields from existing bug.
            {
                Text = "Edit Bug";
                buttonCreate.Text = "Save";
                editModeBug = DBAccess.GetBug(EditModeBugId);
                textBoxTitle.Text = editModeBug.Title;
                textBoxDescription.Text = editModeBug.Description;
                dateTimePickerDue.Value = editModeBug.DueDate;
                comboBoxAssigned.SelectedItem = DB2GUI.AssignedString(editModeBug.Employee);
                comboBoxStatus.SelectedItem = editModeBug.Status.ToString();
                Select();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {  // Create/Save button pressed.
            if (textBoxTitle.Text.Length == 0)
            {
                MessageBox.Show("Title missing!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create bug object which will be saved in DB.
            Bug bug;
            if (StartupMode == StartupMode.EDIT)
                bug = editModeBug;
            else
                bug = new Bug { BugId = 0 };
            // Update information from GUI.
            bug.Title = textBoxTitle.Text;
            bug.Description = textBoxDescription.Text;
            bug.EmployeeEmail = DBAccess.Employees[comboBoxAssigned.SelectedIndex].Email;
            bug.Status = (Status)Enum.Parse(typeof(Status), comboBoxStatus.Text);
            bug.DueDate = dateTimePickerDue.Value;
            // Add bug to DB.
            DBAccess.InsertOrUpdateBug(bug);

            if (StartupMode == StartupMode.REPORT)
                MessageBox.Show("Bug successfully reported!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Bug saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
