
namespace colombia_international_treaties
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Box1 = new System.Windows.Forms.ComboBox();
            this.Box2 = new System.Windows.Forms.ComboBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.lowerBound = new System.Windows.Forms.TextBox();
            this.upperBound = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonString = new System.Windows.Forms.Button();
            this.buttonNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(595, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(599, 482);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 2D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 529);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Box1
            // 
            this.Box1.FormattingEnabled = true;
            this.Box1.Location = new System.Drawing.Point(93, 549);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(121, 21);
            this.Box1.TabIndex = 2;
            this.Box1.SelectedIndexChanged += new System.EventHandler(this.Box1_SelectedIndexChanged);
            // 
            // Box2
            // 
            this.Box2.FormattingEnabled = true;
            this.Box2.Location = new System.Drawing.Point(220, 549);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(121, 21);
            this.Box2.TabIndex = 3;
            this.Box2.Visible = false;
            this.Box2.SelectedIndexChanged += new System.EventHandler(this.Box2_SelectedIndexChanged);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(93, 577);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 20);
            this.text1.TabIndex = 4;
            this.text1.Visible = false;
            // 
            // lowerBound
            // 
            this.lowerBound.Location = new System.Drawing.Point(93, 577);
            this.lowerBound.Name = "lowerBound";
            this.lowerBound.Size = new System.Drawing.Size(73, 20);
            this.lowerBound.TabIndex = 5;
            this.lowerBound.Visible = false;
            // 
            // upperBound
            // 
            this.upperBound.Location = new System.Drawing.Point(172, 577);
            this.upperBound.Name = "upperBound";
            this.upperBound.Size = new System.Drawing.Size(73, 20);
            this.upperBound.TabIndex = 6;
            this.upperBound.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonString
            // 
            this.buttonString.Location = new System.Drawing.Point(93, 603);
            this.buttonString.Name = "buttonString";
            this.buttonString.Size = new System.Drawing.Size(75, 23);
            this.buttonString.TabIndex = 8;
            this.buttonString.Text = "search";
            this.buttonString.UseVisualStyleBackColor = true;
            this.buttonString.Visible = false;
            this.buttonString.Click += new System.EventHandler(this.buttonString_Click);
            // 
            // buttonNumber
            // 
            this.buttonNumber.Location = new System.Drawing.Point(91, 603);
            this.buttonNumber.Name = "buttonNumber";
            this.buttonNumber.Size = new System.Drawing.Size(75, 23);
            this.buttonNumber.TabIndex = 10;
            this.buttonNumber.Text = "search";
            this.buttonNumber.UseVisualStyleBackColor = true;
            this.buttonNumber.Visible = false;
            this.buttonNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 749);
            this.Controls.Add(this.buttonNumber);
            this.Controls.Add(this.buttonString);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.upperBound);
            this.Controls.Add(this.lowerBound);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gmap);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Box1;
        private System.Windows.Forms.ComboBox Box2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox lowerBound;
        private System.Windows.Forms.TextBox upperBound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonString;
        private System.Windows.Forms.Button buttonNumber;
    }
}

