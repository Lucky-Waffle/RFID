using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID
{
    public partial class Data_Monitoring_Application : Menu
    {

        SQLQuery fromSQLQuery = new SQLQuery();

        public Data_Monitoring_Application()
        {
            InitializeComponent();
            fromSQLQuery.GetComboBoxHouse(cboSelectHouseToView);
        }

        private void bntViewStatistic_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            string selectedHouse = cboSelectHouseToView.Text;
            string navn = "Dør åpnet";
            fromSQLQuery.GetStatisticInChart(chart1, selectedHouse, navn);
        }

        private void btnViewHistoryInDataGridView_Click(object sender, EventArgs e)
        {
            string selectedHouse = cboSelectHouseToView.Text;
            fromSQLQuery.GetHistoryInDataGrid(dgvHistory, selectedHouse);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void dataLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProgamWithHide("Logging");
        }

        private void monitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProgamWithHide("Management");
        }

        
    }
}
