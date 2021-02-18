using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using colombia_international_treaties.model;

namespace colombia_international_treaties
{
    public partial class Form1 : Form
    {
        private DataManager dm;
        public Form1()
        {
            dm = new DataManager();
            InitializeComponent();
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance;  //Proveedor del servicio
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(3.42158, -76.5205);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select File"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = dm.importData(ofd.FileName);
            }

            DataTable dt = dm.getDataSet().Tables[0];
            foreach (DataColumn column in dt.Columns)
            {
                Box1.Items.Add(column.ColumnName);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Box1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearStuff();
            DataTable dt = dm.getDataSet().Tables[0];
            string column = Box1.GetItemText(Box1.SelectedItem);

            if(column==DataManager.BILATERAL || column==DataManager.NT || column==DataManager.VIGENTE)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row[column] != DBNull.Value)
                        if (!Box2.Items.Contains((string)row[column]))
                            Box2.Items.Add(row[column]);
                }
                Box2.Visible = true;
            }
            else if (column==DataManager.LA || column==DataManager.EO
                || column==DataManager.SC || column==DataManager.TRATADO)
            {
                text1.Visible = true;
                buttonString.Visible = true;
            }
            else
            {
                lowerBound.Visible = true;
                upperBound.Visible = true;
                buttonNumber.Visible = true;
            }
        }

        private void Box2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = dm.getDataSet().Tables[0];
            string category = Box2.GetItemText(Box2.SelectedItem);
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", Box1.SelectedItem, category);
        }

        private void buttonString_Click(object sender, EventArgs e)
        {
            DataTable dt = dm.getDataSet().Tables[0];
            string value = text1.Text;
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", Box1.SelectedItem, value);
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {

        }

        private void clearStuff()
        {
            Box2.Visible = false;
            Box2.Items.Clear();
            text1.Visible = false;
            text1.Clear();
            buttonString.Visible = false;
            lowerBound.Visible = false;
            lowerBound.Clear();
            upperBound.Visible = false;
            upperBound.Clear();
            buttonNumber.Visible = false;
        }
    }
}
