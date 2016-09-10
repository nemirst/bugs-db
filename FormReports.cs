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
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this._ADAS_D5_BugsContextDataSetReports.EnforceConstraints = false;
            // TODO: This line of code loads data into the '_ADAS_D5_BugsContextDataSetReports.ViewCombined' table. You can move, or remove it, as needed.
            this.ViewCombinedTableAdapter.Fill(this._ADAS_D5_BugsContextDataSetReports.ViewCombined);
            this.reportViewer1.RefreshReport();
        }
    }
}
