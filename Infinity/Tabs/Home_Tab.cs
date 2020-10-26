using System.Windows.Forms;
using System.Diagnostics;
using InfinityLibrary.Helpers;
using InfinityLibrary.DataAccess;
using System.Collections.Generic;
using InfinityLibrary.Models;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System;

namespace Infinity.Tabs
{
    public partial class Home_Tab : UserControl
    {
        private static Home_Tab _instance;
        public Home_Tab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get an instance of Home_Tab usercontrol
        /// </summary>
        /// <returns></returns>
        public static Home_Tab getInstance()
        {
            if (_instance == null)
                _instance = new Home_Tab();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Home_Tab");
        }

        /// <summary>
        /// Method for populating the Charts
        /// </summary>
        public void populateCharts()
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                ReportsGenerator reportGen = new ReportsGenerator();
                List<StatusAnalysis> statusAnalyis = reportGen.StatusAnalysis();

                barChart.DataSource = statusAnalyis.OrderBy(i => i.Status);
                barChart.Series["Defect Count"].XValueMember = "Status";
                barChart.Series["Defect Count"].YValueMembers = "Count";
                barChart.Series["Defect Count"].YValueType = ChartValueType.Int32;

                doughnutChart.DataSource = statusAnalyis.OrderBy(i => i.Status);
                doughnutChart.Series["Count"].XValueMember = "Status";
                doughnutChart.Series["Count"].YValueMembers = "Count";
                doughnutChart.Series["Count"].YValueType = ChartValueType.Int32;

                DefectDataAccess defect = new DefectDataAccess();
                var defects = defect.GetAllDefects();
                drePointChart.DataSource = defect.GetAllDefects();
                drePointChart.Series["DRE"].XValueMember = "DefectId";
                drePointChart.Series["DRE"].YValueMembers = "DRE";
                drePointChart.Series["DRE"].YValueType = ChartValueType.Int32;

                List<AgeAnalysis> ageAnalysis = new List<AgeAnalysis>();
                foreach (var d in defects.Zip(reportGen.calculateAge(defects), Tuple.Create))
                {
                    ageAnalysis.Add(new AgeAnalysis
                    {
                        DefectId = d.Item1.DefectId,
                        Age = d.Item2
                    });
                }
                agePointChart.DataSource = ageAnalysis;
                agePointChart.Series["Age"].XValueMember = "DefectId";
                agePointChart.Series["Age"].YValueMembers = "Age";
                agePointChart.Series["Age"].YValueType = ChartValueType.Int32;
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnector.CloseSQLConnection(); // Close connection to the database
        }

        /// <summary>
        /// Method for populating the DataDridViews
        /// </summary>
        public void populateDataGridAgeAnalysis()
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                DefectDataAccess defect = new DefectDataAccess();
                var defects = defect.GetAllDefects();
                dgvAgeAnalysis.AutoGenerateColumns = false; // To only show the columns needed
                dgvAgeAnalysis.DataSource = defects;
                txtSearchDefects.Text = "";
                for (int i = 0; i < defects.Count; i++)
                {
                    ReportsGenerator reportGen = new ReportsGenerator();
                    dgvAgeAnalysis.Rows[i].Cells[7].Value = reportGen.calculateAge(defects)[i];
                }
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnector.CloseSQLConnection(); // Close connection to the database
        }

        /// <summary>
        /// Method for populating the DataDridViews
        /// </summary>
        public void populateDataGridDREAnalysis()
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                DefectDataAccess defect = new DefectDataAccess();
                var defects = defect.GetAllDefects();
                dgvDREAnalysis.AutoGenerateColumns = false; // To only show the columns needed
                dgvDREAnalysis.DataSource = defects;
                txtSearchDRE.Text = "";
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnector.CloseSQLConnection(); // Close connection to the database
        }

        /// <summary>
        /// Method for populating the DataDridViews
        /// </summary>
        public void populateDataGridDRRAnalysis()
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                ReportsGenerator reportGen = new ReportsGenerator();
                dgvDRRAnalysis.AutoGenerateColumns = false; // To only show the columns needed
                dgvDRRAnalysis.DataSource = reportGen.DrrAnalysis();
                txtSearchDRE.Text = "";
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnector.CloseSQLConnection(); // Close connection to the database
        }

        /// <summary>
        /// Method for generating the DRR chart
        /// </summary>
        private void generateDrrChart()
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                ReportsGenerator reportGen = new ReportsGenerator();
                var chartValues = new List<DRRAnalysis>();
                foreach (var d in reportGen.DrrAnalysis())
                {
                    if (d.Tester == txtSearchDRR.Text)
                    {
                        chartValues.Add(new DRRAnalysis
                        {
                            ProjectName = d.ProjectName,
                            DRR = d.DRR
                        });
                    }
                }
                drrPointChart.DataSource = chartValues;
                drrPointChart.Series["DRR"].XValueMember = "ProjectName";
                drrPointChart.Series["DRR"].YValueMembers = "DRR";
                drrPointChart.Series["DRR"].YValueType = ChartValueType.Int32;
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnector.CloseSQLConnection(); // Close connection to the database
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                DefectDataAccess defect = new DefectDataAccess();
                dgvAgeAnalysis.AutoGenerateColumns = false; // To only show the columns needed
                var defects = defect.SearchDefectsAnalysis(txtSearchDefects.Text.Trim());
                dgvAgeAnalysis.DataSource = defects;
                ReportsGenerator reportGen = new ReportsGenerator();
                reportGen.calculateAge(defects);
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnector.CloseSQLConnection(); // Close connection to the database
        }

        private void btnSearchDRE_Click(object sender, EventArgs e)
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                DefectDataAccess defect = new DefectDataAccess();
                dgvDREAnalysis.AutoGenerateColumns = false; // To only show the columns needed
                dgvDREAnalysis.DataSource = defect.SearchDefectsAnalysis(txtSearchDRE.Text.Trim());
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnector.CloseSQLConnection(); // Close connection to the database
        }

        private void btnSearchDRR_Click(object sender, EventArgs e)
        {
            generateDrrChart();
        }

        private void tabSelector_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
                populateCharts();
            else if (tabControl.SelectedIndex == 2)
                populateDataGridDREAnalysis();
            else if (tabControl.SelectedIndex == 3)
                populateDataGridDRRAnalysis();
            populateDataGridAgeAnalysis();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
                populateDataGridAgeAnalysis();
            else if (tabControl.SelectedIndex == 2)
                populateDataGridDREAnalysis();
            else if (tabControl.SelectedIndex == 3)
                populateDataGridDRRAnalysis();
        }

        /// <summary>
        /// Switch between chart and datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchDRE_MouseClick(object sender, MouseEventArgs e)
        {
            if (switchDRE.IsOn == true)
            {
                drePointChart.Visible = true;
                btnSearchDRE.Visible = false;
                txtSearchDRE.Visible = false;
            }
            else
            {
                drePointChart.Visible = false;
                btnSearchDRE.Visible = true;
                txtSearchDRE.Visible = true;
            }
        }

        /// <summary>
        /// Switch between chart and datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchAge_MouseClick(object sender, MouseEventArgs e)
        {
            if (switchAge.IsOn == true)
            {
                agePointChart.Visible = true;
                btnSearch.Visible = false;
                txtSearchDefects.Visible = false;
            }
            else
            {
                agePointChart.Visible = false;
                btnSearch.Visible = true;
                txtSearchDefects.Visible = true;
            }
        }

        private void switchDRR_MouseClick(object sender, MouseEventArgs e)
        {
            if (switchDRR.IsOn == true)
            {
                drrPointChart.Visible = true;
                txtSearchDRR.Visible = true;
                btnSearchDRR.Visible = true;
            }
            else
            {
                drrPointChart.Visible = false;
                txtSearchDRR.Visible = false;
                btnSearchDRR.Visible = false;
            }
        }
    }
}
