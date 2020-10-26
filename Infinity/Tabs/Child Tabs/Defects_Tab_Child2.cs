using System.Windows.Forms;
using System.Diagnostics;
using InfinityLibrary.Models;

namespace Infinity.Tabs.Child_Tabs
{
    public partial class Defects_Tab_Child2 : UserControl
    {
        private static Defects_Tab_Child2 _instance;
        public Defects_Tab_Child2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get an instance of Defects_Tab_Child2 usercontrol
        /// </summary>
        /// <returns></returns>
        public static Defects_Tab_Child2 getInstance()
        {
            if (_instance == null)
                _instance = new Defects_Tab_Child2();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Defects_Tab_Child2");
        }

        public void populate(Defect defect)
        {
            labelProject.Text = defect.ProjectName;
            labelModule.Text = defect.ModuleName;
            labelRaisedBy.Text = defect.RaisedBy;
            labelAssignedTo.Text = defect.AssignedTo;
            labelStatus.Text = defect.Status;
            labelPriority.Text = defect.Priority;
            labelDateRaised.Text = defect.DateRaised.ToShortDateString();
            labelDateClosed.Text = defect.DateClosed != null ? defect.DateClosed.Value.ToShortDateString() : null;
            labelDRR.Text = defect.DRR.ToString();
            labelDRE.Text = defect.DRE.ToString();
            txtDescription.Text = defect.Description;
            txtSteps.Text = defect.StepsToRepeat;
        }

        private void btnGoBack_Click(object sender, System.EventArgs e)
        {
            Defects_Tab.getInstance().BringToFront();
            Defects_Tab.getInstance().populateDataGridView();
        }
    }
}
