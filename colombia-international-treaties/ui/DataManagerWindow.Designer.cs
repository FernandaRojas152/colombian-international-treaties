﻿
namespace colombia_international_treaties.UI
{
    partial class Database
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.clean = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pointC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointC)).BeginInit();
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
            this.gmap.Location = new System.Drawing.Point(609, 12);
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
            this.gmap.Size = new System.Drawing.Size(585, 451);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 2D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 451);
            this.dataGridView1.TabIndex = 1;
            // 
            // Box1
            // 
            this.Box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box1.FormattingEnabled = true;
            this.Box1.Location = new System.Drawing.Point(93, 473);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(121, 21);
            this.Box1.TabIndex = 2;
            this.Box1.SelectedIndexChanged += new System.EventHandler(this.Box1_SelectedIndexChanged);
            // 
            // Box2
            // 
            this.Box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box2.FormattingEnabled = true;
            this.Box2.Location = new System.Drawing.Point(220, 473);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(121, 21);
            this.Box2.TabIndex = 3;
            this.Box2.Visible = false;
            this.Box2.SelectedIndexChanged += new System.EventHandler(this.Box2_SelectedIndexChanged);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(93, 501);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 20);
            this.text1.TabIndex = 4;
            this.text1.Visible = false;
            // 
            // lowerBound
            // 
            this.lowerBound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerBound.ForeColor = System.Drawing.Color.Gray;
            this.lowerBound.Location = new System.Drawing.Point(93, 501);
            this.lowerBound.Name = "lowerBound";
            this.lowerBound.Size = new System.Drawing.Size(73, 20);
            this.lowerBound.TabIndex = 5;
            this.lowerBound.Text = "from";
            this.lowerBound.Visible = false;
            this.lowerBound.Enter += new System.EventHandler(this.lowerBound_Enter);
            this.lowerBound.Leave += new System.EventHandler(this.lowerBound_Leave);
            // 
            // upperBound
            // 
            this.upperBound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperBound.ForeColor = System.Drawing.Color.Gray;
            this.upperBound.Location = new System.Drawing.Point(172, 501);
            this.upperBound.Name = "upperBound";
            this.upperBound.Size = new System.Drawing.Size(73, 20);
            this.upperBound.TabIndex = 6;
            this.upperBound.Text = "to";
            this.upperBound.Visible = false;
            this.upperBound.Enter += new System.EventHandler(this.upperBound_Enter);
            this.upperBound.Leave += new System.EventHandler(this.upperBound_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonString
            // 
            this.buttonString.Location = new System.Drawing.Point(93, 527);
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
            this.buttonNumber.Location = new System.Drawing.Point(93, 527);
            this.buttonNumber.Name = "buttonNumber";
            this.buttonNumber.Size = new System.Drawing.Size(75, 23);
            this.buttonNumber.TabIndex = 10;
            this.buttonNumber.Text = "Search";
            this.buttonNumber.UseVisualStyleBackColor = true;
            this.buttonNumber.Visible = false;
            this.buttonNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(609, 469);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(75, 23);
            this.clean.TabIndex = 12;
            this.clean.Text = "Clear";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(573, 500);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Cantidad por tipo de tratado";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(340, 193);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title1.Name = "Tipo de tratado (Bilateral y No Bilateral";
            this.chart1.Titles.Add(title1);
            this.chart1.Visible = false;
            // 
            // pie
            // 
            chartArea2.Name = "ChartArea1";
            this.pie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pie.Legends.Add(legend2);
            this.pie.Location = new System.Drawing.Point(919, 500);
            this.pie.Name = "pie";
            this.pie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Label = "#PERCENT";
            series2.Legend = "Legend1";
            series2.Name = "Vigencia";
            this.pie.Series.Add(series2);
            this.pie.Size = new System.Drawing.Size(275, 193);
            this.pie.TabIndex = 14;
            this.pie.Text = "pie";
            this.pie.Visible = false;
            // 
            // pointC
            // 
            chartArea3.Name = "ChartArea1";
            this.pointC.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pointC.Legends.Add(legend3);
            this.pointC.Location = new System.Drawing.Point(319, 501);
            this.pointC.Name = "pointC";
            this.pointC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Variable Tratado";
            this.pointC.Series.Add(series3);
            this.pointC.Size = new System.Drawing.Size(248, 192);
            this.pointC.TabIndex = 15;
            this.pointC.Text = "pointC";
            this.pointC.Visible = false;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 712);
            this.Controls.Add(this.pointC);
            this.Controls.Add(this.pie);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.clean);
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
            this.MaximizeBox = false;
            this.Name = "Database";
            this.Text = "Database treaties";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointC)).EndInit();
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
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie;
        private System.Windows.Forms.DataVisualization.Charting.Chart pointC;
    }
}

