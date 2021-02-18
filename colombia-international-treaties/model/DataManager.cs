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
    
          public const string PATH = @"c:\\data\Tratados_internacionales_de_Colombia.csv";

          private DataSet ds;
         
          public DataManager(){
               
          }

          public void datasss() {
        
                /*
                DataTable dt = ds.Tables[0];
                string department = "";
                foreach (DataRow row in dt.Rows)
                {
                    if (department == (string)row[FILTER])
                        department = (string)row[FILTER];
                    else
                    {
                        cbFilter.Items.Add(row[FILTER]);
                        department = (string)row[FILTER];
                    }
                }
                */
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
