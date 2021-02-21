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
        GMapOverlay markers;

        public Database()
        {
            markers = new GMapOverlay("markers");
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
            generateCharts();
        }

        private void generateCharts()
        {
            chart1.Series["Cantidad por tipo de tratado"].Points.Clear();
            chart1.Titles.Clear();
            pie.Series["Vigencia"].Points.Clear();
            pie.Titles.Clear();
            pointC.Series["Variable Tratado"].Points.Clear();
            pointC.Titles.Clear();
            generateChart1();
            generateChart2();
            generateChart3();
        }

        private void generateChart1()
        {
            chart1.Visible = true;
            chart1.Titles.Add("Tipo de tratado (Bilateral y No Bilateral)");
            DataTable dt = dm.getDataSet().Tables[0];
            int bilateral = 0, noBilateral = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row[DataManager.BILATERAL] != DBNull.Value)
                {
                    if ("SI" == (string)row[DataManager.BILATERAL])
                        bilateral++;
                    else if ("NO" == (string)row[DataManager.BILATERAL])
                        noBilateral++;
                } 
            }
            chart1.Series["Cantidad por tipo de tratado"].Points.AddXY("SÍ", bilateral);
            chart1.Series["Cantidad por tipo de tratado"].Points.AddXY("NO", noBilateral);
        }

        private void generateChart2()
        {
            pie.Visible = true;
            pie.Titles.Add("Vigencia");
            DataTable dt = dm.getDataSet().Tables[0];
            IDictionary<string, int> counts = new Dictionary<string, int>();
            List<String> names = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                if (row[DataManager.VIGENTE] != DBNull.Value)
                {
                    names.Add((string)row[DataManager.VIGENTE]);
                }
            }
            foreach (string value in names)
            {
                if (!counts.ContainsKey(value))
                    counts.Add(value, 1);
                else
                    counts[value]++;
            }
            int i = 0;
            foreach (string value in counts.Keys)
            {
                pie.Series["Vigencia"].Points.AddXY(value.ToString(), counts[value]);
                pie.Series["Vigencia"].Points[i].LegendText = value;
                i++;
            }
        }

        private void generateChart3()
        {
            pointC.Visible = true;
            pointC.Titles.Add("Analisis de tratado o acuerdo");
            DataTable dt = dm.getDataSet().Tables[0];
            int tratado = 0, acuerdo = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row[DataManager.NT] != DBNull.Value)
                {
                    if ("TRATADO" == (string)row[DataManager.NT])
                        tratado++;
                    else if ("ACUERDO PROCEDIMIENTO SIMPLIFICADO" == (string)row[DataManager.NT])
                        acuerdo++;
                }
            }
            pointC.Series["Variable Tratado"].Points.AddXY("Tratado", tratado);
            pointC.Series["Variable Tratado"].Points.AddXY("Acuerdo", acuerdo);
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
            string value = Box2.GetItemText(Box2.SelectedItem);
            List<string> cities = new List<string>();       
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", Box1.SelectedItem, value);
            showMarkers(cities, value, dt);
        }

        private void buttonString_Click(object sender, EventArgs e)
        {
            DataTable dt = dm.getDataSet().Tables[0];
            string value = text1.Text;
            List<string> cities = new List<string>();
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", Box1.SelectedItem, value);
            showMarkers(cities, value, dt);
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            DataTable dt = dm.getDataSet().Tables[0];
            int lower = Convert.ToInt32(lowerBound.Text);
            int upper = Convert.ToInt32(upperBound.Text);    
            if (lower < upper)
            {
                dt.DefaultView.RowFilter = Box1.SelectedItem+" >= "+lower+" AND "+Box1.SelectedItem+" <= "+upper;
            }
            else
            {
                MessageBox.Show("Upper bound should be higher than lower bound.", "Error", MessageBoxButtons.OKCancel);
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

        private void showMarkers(List<string> cities, string value, DataTable dt)
        {
            List<String> names = new List<String>();
            foreach (DataRow row in dt.Rows)
            {
                if (row[Box1.SelectedItem.ToString()]!=DBNull.Value && row[DataManager.LA]!=DBNull.Value)
                {
                    string rowString = (string)row[Box1.SelectedItem.ToString()];
                    if (rowString.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        cities.Add((string)row[DataManager.LA]);
                        names.Add((string)row[Box1.SelectedItem.ToString()]);
                    }
                }
            }
            cities = cities.Distinct().ToList();
            markers.Clear();
            int i = 0;
            foreach (string city in cities)
            {
                GeoCoderStatusCode statusCode;
                PointLatLng? pointLatLng1 = OpenStreet4UMapProvider.Instance.GetPoint(city, out statusCode);

                if (pointLatLng1 != null)
                {
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng), GMarkerGoogleType.blue_dot);
                    marker00.ToolTipText = city + "\n" + names[i]  + "\n" + pointLatLng1.Value.Lat + "\n" + pointLatLng1.Value.Lng;
                    markers.Markers.Add(marker00);
                    Console.WriteLine(city);
                    i++;
                }
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            markers.Clear();
        }

        private void lowerBound_Enter(object sender, EventArgs e)
        {
            if (lowerBound.Text == "from")
            {
                lowerBound.Text = "";
                lowerBound.ForeColor = Color.Black;
            }
                
        }

        private void lowerBound_Leave(object sender, EventArgs e)
        {
            if (lowerBound.Text == "")
            {
                lowerBound.Text = "from";
                lowerBound.ForeColor = Color.Gray;
            }
        }

        private void upperBound_Enter(object sender, EventArgs e)
        {
            if (upperBound.Text == "to")
            {
                upperBound.Text = "";
                upperBound.ForeColor = Color.Black;
            }
        }

        private void upperBound_Leave(object sender, EventArgs e)
        {
            if (upperBound.Text == "")
            {
                upperBound.Text = "to";
                upperBound.ForeColor = Color.Gray;
            }
        }
    }
}
