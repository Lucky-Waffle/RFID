using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace RFID
{
    public class SQLconnection
    {
        private string sqlConfig = ConfigurationManager.ConnectionStrings["RFID"].ConnectionString;
        private static string husIdFromSql;
        private static string eierNrFromSql;
        private DateTime dateTime = DateTime.Now;

        public static string InputSQLrfid;

        public SQLconnection()
        {

        }

        public virtual void InputRFIDtag(string text)
        {
            InputSQLrfid = text;
        }

        public virtual string GetRFIDtagNr()
        {
            return InputSQLrfid;
        }
        
        public string SQLstoredProcedure1Output1Input(string storedProcedure, string sqlParameter, string sqlValue)
        {
            string Output = "";
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand(storedProcedure, conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter(sqlParameter, sqlValue));
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Output = dr.GetValue(0).ToString();
                }
                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return Output;
        }

        public string GetRFIDnameFromUser(string sqlPerson, string sqlAdresse) //SQLstoredProcedure1Output2Input
        {
            string Name = "";
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand("uspGetRFIDnameFromUser", conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter("@person", sqlPerson));
                sql.Parameters.Add(new SqlParameter("@adresse", sqlAdresse));
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    Name = dr.GetValue(0).ToString();
                }
                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return Name;
        }

        public void SQLstoredProcedure1Input(string storedProcedure, string sqlParameter, string sqlValue)
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand(storedProcedure, conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter(sqlParameter, sqlValue));
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();

                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void SQLstoredProcedure2Input(string storedProcedure, string sqlParameter1, string sqlValue1, string sqlParameter2, string sqlValue2)
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand(storedProcedure, conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter(sqlParameter1, sqlValue1));
                sql.Parameters.Add(new SqlParameter(sqlParameter2, sqlValue2));
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();

                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void SQLstoredProcedure3Input(string storedProcedure, 
            string sqlParameter1, string sqlValue1, string sqlParameter2, string sqlValue2, string sqlParameter3, string sqlValue3)
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand(storedProcedure, conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter(sqlParameter1, sqlValue1));
                sql.Parameters.Add(new SqlParameter(sqlParameter2, sqlValue2));
                sql.Parameters.Add(new SqlParameter(sqlParameter3, sqlValue3));
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();

                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void SQLstoredProcedure5Input(string storedProcedure,
            string sqlParameter1, string sqlValue1, string sqlParameter2, string sqlValue2, string sqlParameter3, string sqlValue3,
            string sqlParameter4, string sqlValue4, string sqlParameter5, string sqlValue5)
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand(storedProcedure, conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter(sqlParameter1, sqlValue1));
                sql.Parameters.Add(new SqlParameter(sqlParameter2, sqlValue2));
                sql.Parameters.Add(new SqlParameter(sqlParameter3, sqlValue3));
                sql.Parameters.Add(new SqlParameter(sqlParameter4, sqlValue4));
                sql.Parameters.Add(new SqlParameter(sqlParameter5, sqlValue5));
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();

                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public virtual void SQLstoredProcedureInputInTextbox(TextBox textBox, string storedProcedure, string sqlParameter, string sqlValue) 
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand(storedProcedure, conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter(sqlParameter, sqlValue));
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    textBox.Text = dr.GetValue(0).ToString();
                }

                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public virtual void ImportToComboBox(ComboBox comboBox, string sqlQuery)
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand(sqlQuery, conRFID);

                sql.CommandType = CommandType.Text;
                conRFID.Open();
                SqlDataReader dr = sql.ExecuteReader();

                while (dr.Read() == true)
                {
                    sqlQuery = dr[0].ToString();
                    comboBox.Items.Add(sqlQuery);
                }

                conRFID.Close();
                comboBox.SelectedIndex = 0;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public virtual void ImportToTextbox(TextBox textBox, string sqlQuery)
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand(sqlQuery, conRFID);

                sql.CommandType = CommandType.Text;
                conRFID.Open();

                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    textBox.Text = dr.GetValue(0).ToString();
                }
                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void DoorLogin()
        {
            SQLstoredProcedure1Output1Input("uspGetNameFromRFIDtag", "@RFIDname", InputSQLrfid);
            GetHusIdFromSQL();
            GetEierNrFromSQL();
            
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand("uspDoorLogin", conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter("@inputDateTime", dateTime));
                sql.Parameters.Add(new SqlParameter("@inputHusId", husIdFromSql));
                sql.Parameters.Add(new SqlParameter("@inputEierNr", eierNrFromSql));
                sql.ExecuteNonQuery();

                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void DoorLogout()
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand("uspDoorLogout", conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter("@inputDateTime", dateTime));
                sql.Parameters.Add(new SqlParameter("@inputHusId", husIdFromSql));
                sql.Parameters.Add(new SqlParameter("@inputEierNr", eierNrFromSql));
                sql.ExecuteNonQuery();

                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // Protected------------------------
        protected void ViewInDataGridView(string sqlQuery, DataGridView dataGrid)
        {
            SqlConnection conRFID = new SqlConnection(sqlConfig);
            SqlDataAdapter sda;
            DataTable dt;

            try
            {
                conRFID.Open();
                sda = new SqlDataAdapter(sqlQuery, conRFID);
                dt = new DataTable();

                sda.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        protected void ViewInChart(string sqlQuery, Chart chart, string navn)
        {
            string tid;
            int count;
            chart.ChartAreas[0].AxisX.Interval = 1.0;

            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand(sqlQuery, conRFID);

                conRFID.Open();
                SqlDataReader dr = sql.ExecuteReader();

                while (dr.Read() == true)
                {
                    tid = Convert.ToString(dr[0]);
                    count = Convert.ToInt32(dr["Number"]);
                    chart.Series[navn].Points.AddXY(tid, count);
                }
                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // Private-------------------

        private void GetHusIdFromSQL()
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand("uspGetHusId", conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter("@RFIDname", InputSQLrfid));
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    husIdFromSql = dr.GetValue(0).ToString();
                }
                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void GetEierNrFromSQL()
        {
            try
            {
                SqlConnection conRFID = new SqlConnection(sqlConfig);
                SqlCommand sql = new SqlCommand("uspGetEierNr", conRFID);

                sql.CommandType = CommandType.StoredProcedure;
                conRFID.Open();

                sql.Parameters.Add(new SqlParameter("@RFIDname", InputSQLrfid));
                sql.ExecuteNonQuery();

                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    eierNrFromSql = dr.GetValue(0).ToString();
                }
                conRFID.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
