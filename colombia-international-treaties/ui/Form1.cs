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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
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
        }
    }
}
