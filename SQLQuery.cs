using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RFID
{
    public class SQLQuery:SQLconnection
    {
        private string comboBoxHus = //gjøre om til View
            @"
            SELECT Adresse, PostNr
            FROM HUS
            ORDER BY HusId";

        public SQLQuery()
        {

        }

        public void GetComboBoxHouse(ComboBox comboBox)
        {
            ImportToComboBox(comboBox, comboBoxHus);
        }

        public void DataGridViewPersonInHouse(DataGridView dataGrid, string selectedHouse)
        {
            string sqlQuery =
                @"
                SELECT Navn
                FROM BRUKERE, HUS
                WHERE HUS.EierNr = BRUKERE.EierNr
                AND HUS.Adresse = " + "'" + selectedHouse + "'" +";";

            ViewInDataGridView(sqlQuery, dataGrid);
        }

        public void GetComboBoxPerson(ComboBox comboBox, string selectedHouse)
        {
            string sqlQuery =
                @"
                SELECT Navn
                FROM BRUKERE, HUS
                WHERE HUS.EierNr = BRUKERE.EierNr
                AND HUS.Adresse = " + "'" + selectedHouse + "'" + ";";

            ImportToComboBox(comboBox, sqlQuery);
        }

        public void GetHistoryInDataGrid(DataGridView dataGrid, string selectedHouse)
        {
            string sqlQuery =
                @"
                SELECT DoorLoginTime, DoorName, DoorStatus
                FROM DOOR, HUS
                WHERE HUS.HusId = DOOR.HusId
                AND HUS.Adresse = " + "'" + selectedHouse + "'" +
                "ORDER BY DOOR.DoorId DESC" + ";";
            ViewInDataGridView(sqlQuery, dataGrid);
        }

        public void GetStatisticInChart(Chart chart, string selectedHouse, string navn)
        {
            string sqlQuery =
                @"
                SELECT CONVERT(date, DoorLoginTime) AS [Dato], COUNT(*) AS [Number]
                FROM DOOR, HUS
                WHERE HUS.HusId = DOOR.HusId
                AND HUS.Adresse = " + "'" + selectedHouse + "'" +
                "AND DOOR.DoorStatus = 1" + 
                "GROUP BY CONVERT(date, DOOR.DoorLoginTime)"+
                "ORDER BY COUNT(*) ASC" + ";";
            ViewInChart(sqlQuery, chart, navn);
        }

        public void ViewDataGridFromSQL(DataGridView dataGrid, string parameter)
        {
            ViewInDataGridView(parameter, dataGrid);
        }
    }
}
