using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RFID
{
    public class Menu : Form
    {
        private static bool loginStatus = false;
        private static bool skipLogin = false;

        //SQLconnection fromSQLcon = new SQLconnection(); //Skaper en merkelig feil når progammet tvinges av, etter at det har kjørt
        //Feilen gjør slik at det ikke lenger er mulig å komme inne på Form [Designer]. Feilen løses ved å kommentere bort og kjøre progammet på nytt.

        public void ChangeLogin(bool changeLogin)
        {
            loginStatus = changeLogin;
        }

        private bool CheckLogin()
        {
            if (loginStatus == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ChangeSkipLogin(bool changeSkipLogin)
        {
            loginStatus = changeSkipLogin;
            skipLogin = changeSkipLogin;
        }

        public bool CheckSkipLogin()
        {
            if (skipLogin == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ExitProgram()
        {
            //fromSQLcon.DoorLogout(); //Skaper en merkelig feil, se mer info over. Planen var at Bruker logget ut når programmet lukkes.
            Application.Exit();
        }

        public void StartProgam(string program)
        {
            if (CheckLogin() == true)
            {
                if (program == "Logging")
                {
                    //this.Hide();
                    Data_Logging_Application data_Logging_Application = new Data_Logging_Application();
                    data_Logging_Application.StartPosition = FormStartPosition.Manual;
                    data_Logging_Application.Location = new Point(this.Location.X, this.Location.Y);
                    data_Logging_Application.Show();
                }
                if (program == "Management")
                {
                    //this.Hide();
                    Data_Management_Application data_Management_Application = new Data_Management_Application();
                    data_Management_Application.StartPosition = FormStartPosition.Manual;
                    data_Management_Application.Location = new Point(this.Location.X, this.Location.Y);
                    data_Management_Application.Show();
                }
                if (program == "Monitoring")
                {
                    //this.Hide();
                    Data_Monitoring_Application data_Monitoring_Application = new Data_Monitoring_Application();
                    data_Monitoring_Application.StartPosition = FormStartPosition.Manual;
                    data_Monitoring_Application.Location = new Point(this.Location.X, this.Location.Y);
                    data_Monitoring_Application.Show();
                }
            }
            else
            {
                MessageBox.Show("You most login first");
            }
        }

        public void StartProgamWithHide(string program)
        {
            if (program == "Logging")
            {
                this.Hide();
                Data_Logging_Application data_Logging_Application = new Data_Logging_Application();
                data_Logging_Application.StartPosition = FormStartPosition.Manual;
                data_Logging_Application.Location = new Point(this.Location.X, this.Location.Y);
                data_Logging_Application.Show();
            }
            if (program == "Management")
            {
                this.Hide();
                Data_Management_Application data_Management_Application = new Data_Management_Application();
                data_Management_Application.StartPosition = FormStartPosition.Manual;
                data_Management_Application.Location = new Point(this.Location.X, this.Location.Y);
                data_Management_Application.Show();
            }
            if (program == "Monitoring")
            {
                this.Hide();
                Data_Monitoring_Application data_Monitoring_Application = new Data_Monitoring_Application();
                data_Monitoring_Application.StartPosition = FormStartPosition.Manual;
                data_Monitoring_Application.Location = new Point(this.Location.X, this.Location.Y);
                data_Monitoring_Application.Show();
            }
        }

    }
}
