using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace colombia_international_treaties.model
{
    class DataManager
    {
        public const string BILATERAL = "Bilateral", NT = "Naturaleza del Tratado",
            VIGENTE = "Vigente", LA = "Lugar de Adopcion", EO = "Estados-Organismos",
            SC = "Suscribio Por Colombia", TRATADO = "Nombre del Tratado";
        private DataSet ds;

        public DataManager()
        {

        }

        public DataSet getDataSet()
        {
            return ds; 
        }

        public DataView importData(string line)
        {
            String connection = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", line);
            OleDbConnection connector = new OleDbConnection(connection);
            connector.Open();
            OleDbCommand query = new OleDbCommand("Select * from [Worksheet$]", connector);
            OleDbDataAdapter adapter = new OleDbDataAdapter
            {
                SelectCommand = query
            };
            ds = new DataSet();
            adapter.Fill(ds);
            connector.Close();
            return ds.Tables[0].DefaultView;
        }

    }
}
