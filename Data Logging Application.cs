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
    public partial class Data_Logging_Application : Menu
    {
        SQLconnection fromSQLcon = new SQLconnection();
        Person person = new Person();
        House house = new House();
        Door door = new Door();
        RFIDtag rfidTag = new RFIDtag();

        public Data_Logging_Application()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void dataLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProgamWithHide("Management");
        }

        private void monitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProgamWithHide("Monitoring");
        }

        private void Data_Logging_Application_Load(object sender, EventArgs e)
        {
            if (CheckSkipLogin() == false)
            {
                txtLoginName2.Text = fromSQLcon.SQLstoredProcedure1Output1Input("uspGetNameFromRFIDtag", "@RFIDname", fromSQLcon.GetRFIDtagNr());
                txtRFIDtag.Text = fromSQLcon.GetRFIDtagNr();
                fromSQLcon.SQLstoredProcedureInputInTextbox(txtAdresse, "uspViewAdresse", "@RFIDname", fromSQLcon.GetRFIDtagNr());
                fromSQLcon.SQLstoredProcedureInputInTextbox(txtDoorStatus, "uspViewDoorStatus", "@RFIDname", fromSQLcon.GetRFIDtagNr());
                if (txtDoorStatus.Text == "False")
                {
                    txtDoorStatus.Text = "Dør lukket";
                }
                else
                {
                    txtDoorStatus.Text = "Dør åpnet";
                }
            }
            else
            {
                txtLoginName2.Text = person.FirstName;
                txtRFIDtag.Text = rfidTag.RFIDtagNr;
                txtAdresse.Text = house.Adresse;
                txtDoorStatus.Text = door.DoorStatus;
            }
            
        }
    }
}
