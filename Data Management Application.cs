using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RFID
{
    public partial class Data_Management_Application : Menu
    {
        private string rfidTag;
        SerialPort port = new System.IO.Ports.SerialPort("COM3", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);

        SQLconnection fromSQLcon = new SQLconnection();
        SQLQuery fromSQLQuery = new SQLQuery();

        public Data_Management_Application()
        {
            InitializeComponent();
            fromSQLQuery.GetComboBoxHouse(cboSelectHouseToView); 
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
            StartProgamWithHide("Monitoring");
        }

        private void btnViewPersonInHouse_Click(object sender, EventArgs e)
        {
            string selectedHouse = cboSelectHouseToView.Text;
            fromSQLQuery.DataGridViewPersonInHouse(dvgViewData, selectedHouse);
        }

        private void btnViewPersonInDataGridView_Click(object sender, EventArgs e)
        {
            string parameter = "SELECT * FROM [Alle personer]";
            fromSQLQuery.ViewDataGridFromSQL(dvgViewData, parameter);
        }

        private void btnViewHousesInDataGridView_Click(object sender, EventArgs e)
        {
            string parameter = "SELECT * FROM [Alle hus]";
            fromSQLQuery.ViewDataGridFromSQL(dvgViewData, parameter);
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            string selectedPerson = cboSelectPerson.Text;
            string selectedAdresse = cboSelectHouseToView.Text;
            string rfidName = fromSQLcon.GetRFIDnameFromUser(selectedPerson, selectedAdresse);
            fromSQLcon.SQLstoredProcedure2Input("uspDeletePerson", "@person", selectedPerson, "@RFIDname", rfidName);
        }

        private void btnChangeAdresse_Click(object sender, EventArgs e)
        {
            string adresse = cboSelectHouseToView.Text;
            string newAdresse = txtNewAdresse.Text;
            string newPostnr = txtNewAdressePostNr.Text;
            string postNr = fromSQLcon.SQLstoredProcedure1Output1Input("uspGetPostNrFromAdresse", "@Adresse", adresse);
            string newPoststed = txtNewPoststed.Text;

            fromSQLcon.SQLstoredProcedure5Input("uspUpdateAdresseName", 
                "@AdresseToBeUpdated", adresse, "@NewAdresseName", newAdresse, "@NewPostNr", 
                newPostnr, "@PostNrToBeUpdated", postNr, "@NewPoststed", newPoststed);
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            string person = txtAddPerson.Text;
            string adresse = cboSelectHouseToView.Text;
            string eierID = fromSQLcon.SQLstoredProcedure1Output1Input("uspGetEierIdFromAdresse", "@adresse", adresse);

            fromSQLcon.SQLstoredProcedure3Input("uspInsertPerson", "@person", person, "@eierId", eierID, "@RFIDnavn", rfidTag);
        }

        private void cboSelectHouseToView_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSelectPerson.Items.Clear();
            fromSQLQuery.GetComboBoxPerson(cboSelectPerson, cboSelectHouseToView.Text);
            txtAdresse.Text = cboSelectHouseToView.Text;
        }

        private void cboSelectPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPerson = cboSelectPerson.Text;
            string selectedAdresse = cboSelectHouseToView.Text;
            string rfidName = fromSQLcon.GetRFIDnameFromUser(selectedPerson, selectedAdresse);

            txtSelectedRFIDtag.Text = rfidName;
        }

        private void bntScanRFIDtag_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize
                port.Open();
                port.DtrEnable = true;

                int numberBytesToRead = 4;
                byte[] data = new byte[numberBytesToRead];
                port.ReadTimeout = 5000;
                port.Read(data, 0, numberBytesToRead);

                rfidTag = "";
                for (int i = 0; i < numberBytesToRead; i++)
                {
                    rfidTag = rfidTag + data[i].ToString("X");
                }

                txtScanRFIDtag.Text = rfidTag;

                port.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
