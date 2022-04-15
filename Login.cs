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
    public partial class Login : Menu
    {
        private string rfidTag;
        SerialPort port = new System.IO.Ports.SerialPort("COM3", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
        SQLconnection fromSQLcon = new SQLconnection();

        public Login()
        {
            InitializeComponent();
        }

        private void btnReadTag_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize
                port.Open();
                port.DtrEnable = true;
                //txtLoginName.Text = "";

                int numberBytesToRead = 4;
                byte[] data = new byte[numberBytesToRead];
                port.ReadTimeout = 5000;
                port.Read(data, 0, numberBytesToRead);

                rfidTag = "";
                for (int i = 0; i < numberBytesToRead; i++)
                {
                    rfidTag = rfidTag + data[i].ToString("X");
                }

                fromSQLcon.InputRFIDtag(rfidTag);
                txtLoginName.Text =  fromSQLcon.SQLstoredProcedure1Output1Input("uspGetNameFromRFIDtag", "@RFIDname", rfidTag);

                fromSQLcon.DoorLogin();

                port.Close();

                ChangeLogin(true);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bntManagement_Click(object sender, EventArgs e)
        {
            StartProgam("Management");
        }

        private void bntLogging_Click(object sender, EventArgs e)
        {
            StartProgam("Logging");
        }

        private void bntMonitoring_Click(object sender, EventArgs e)
        {
            StartProgam("Monitoring");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void skipLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Person personSkipLogin = new Person();
            ChangeSkipLogin(true);

            txtLoginName.Text = personSkipLogin.FirstName;
        }

        private void dataLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
                StartProgam("Logging");
        }

        private void monitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
                StartProgam("Monitoring");
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
                StartProgam("Management");
        }

    }
}
