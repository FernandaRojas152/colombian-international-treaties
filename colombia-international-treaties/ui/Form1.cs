using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using colombia_international_treaties.model;

namespace colombia_international_treaties
{
    public partial class Database : Form
    {
        private DataManager dm;

        private List<PointLatLng> mark;
        private List<PointLatLng> point;

        GMapOverlay markers = new GMapOverlay("markers");

        public Database()
        {
            dm = new DataManager();
            InitializeComponent();
            mark = new List<PointLatLng>();
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance; 
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(3.42158, -76.5205);
            gmap.Overlays.Add(markers);
        }

        private void setMarkers() 
        {
            foreach (PointLatLng points in point)
            {
                GMapMarker marker = new GMarkerGoogle(points, GMarkerGoogleType.pink_dot);
                markers.Markers.Add(marker);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;",
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
            DataTable dt = dm.getDataSet().Tables[0];
            int lower = Convert.ToInt32(lowerBound.Text);
            int upper = Convert.ToInt32(upperBound.Text);
            string column = Box1.SelectedItem.ToString();

            if (lower < upper)
            {
                dt.DefaultView.RowFilter = Box1.SelectedItem+" >= "+lower+" AND "+Box1.SelectedItem+" <= "+upper;
            }
            else
            {
                DialogResult warning = MessageBox.Show("Upper bound should be higher than lower bound.", "Error", MessageBoxButtons.OKCancel);
            }
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

        private void marker_Click(object sender, EventArgs e)
        {
            DataTable dt = dm.getDataSet().Tables[0];
            foreach (string f in lista)
            {
                GeoCoderStatusCode statusCode;
                PointLatLng? pointLatLng1 = OpenStreet4UMapProvider.Instance.GetPoint(f, out statusCode);


                if (pointLatLng1 != null)
                {
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng), GMarkerGoogleType.blue_dot);
                    marker00.ToolTipText = f + "\n" + pointLatLng1.Value.Lat + "\n" + pointLatLng1.Value.Lng;
                    markers.Markers.Add(marker00);
                }

            }
        }
    }
}
