namespace PromiseTechnology.DesktopTiles
{
    partial class PerformanceGraph
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.performanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.categoryToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.counterToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.instanceToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.numberOfDataPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfDataPointsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.LineTypeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceCounter = new System.Diagnostics.PerformanceCounter();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.InstanceLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceChart)).BeginInit();
            this.chartContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // performanceChart
            // 
            this.performanceChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.performanceChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.performanceChart.BorderlineWidth = 0;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.ScrollBar;
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.Lime;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.Format = "{0}%";
            chartArea2.AxisY.LabelStyle.Interval = 0D;
            chartArea2.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.LabelStyle.TruncatedLabels = true;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.MaximumAutoSize = 100F;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.BorderWidth = 0;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.performanceChart.ChartAreas.Add(chartArea2);
            this.performanceChart.Location = new System.Drawing.Point(0, 25);
            this.performanceChart.Margin = new System.Windows.Forms.Padding(0);
            this.performanceChart.Name = "performanceChart";
            this.performanceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.performanceChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Memory";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.performanceChart.Series.Add(series2);
            this.performanceChart.Size = new System.Drawing.Size(239, 216);
            this.performanceChart.TabIndex = 4;
            this.performanceChart.Text = "performanceChart";
            this.performanceChart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // chartContextMenu
            // 
            this.chartContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripComboBox,
            this.counterToolStripComboBox,
            this.instanceToolStripComboBox,
            this.toolStripSeparator1,
            this.numberOfDataPointsToolStripMenuItem,
            this.LineTypeToolStripComboBox,
            this.colorToolStripMenuItem});
            this.chartContextMenu.Name = "ChartContextMenu";
            this.chartContextMenu.Size = new System.Drawing.Size(196, 162);
            this.chartContextMenu.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.chartContextMenu_Closing);
            this.chartContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.chartContextMenu_Opening);
            // 
            // categoryToolStripComboBox
            // 
            this.categoryToolStripComboBox.Name = "categoryToolStripComboBox";
            this.categoryToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.categoryToolStripComboBox.Sorted = true;
            // 
            // counterToolStripComboBox
            // 
            this.counterToolStripComboBox.Name = "counterToolStripComboBox";
            this.counterToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.counterToolStripComboBox.Sorted = true;
            this.counterToolStripComboBox.Visible = false;
            // 
            // instanceToolStripComboBox
            // 
            this.instanceToolStripComboBox.Name = "instanceToolStripComboBox";
            this.instanceToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.instanceToolStripComboBox.Sorted = true;
            this.instanceToolStripComboBox.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // numberOfDataPointsToolStripMenuItem
            // 
            this.numberOfDataPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfDataPointsToolStripComboBox});
            this.numberOfDataPointsToolStripMenuItem.Name = "numberOfDataPointsToolStripMenuItem";
            this.numberOfDataPointsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.numberOfDataPointsToolStripMenuItem.Text = "Number of Data Points";
            // 
            // numberOfDataPointsToolStripComboBox
            // 
            this.numberOfDataPointsToolStripComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "50",
            "100",
            "150",
            "200",
            "300",
            "500",
            "750",
            "1000",
            "1500",
            "2000",
            "3000",
            "4000",
            "5000",
            "10000",
            "20000",
            "50000",
            "100000"});
            this.numberOfDataPointsToolStripComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.numberOfDataPointsToolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.numberOfDataPointsToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberOfDataPointsToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberOfDataPointsToolStripComboBox.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "300",
            "500",
            "750",
            "1000",
            "1500",
            "2000",
            "3000",
            "4000",
            "5000",
            "10000",
            "20000",
            "50000",
            "100000"});
            this.numberOfDataPointsToolStripComboBox.Name = "numberOfDataPointsToolStripComboBox";
            this.numberOfDataPointsToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.numberOfDataPointsToolStripComboBox.DropDownClosed += new System.EventHandler(this.numberOfDataPointsToolStripComboBox_SelectedIndexChanged);
            this.numberOfDataPointsToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.numberOfDataPointsToolStripComboBox_SelectedIndexChanged);
            // 
            // LineTypeToolStripComboBox
            // 
            this.LineTypeToolStripComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LineTypeToolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LineTypeToolStripComboBox.Items.AddRange(new object[] {
            "Point",
            "FastPoint",
            "Bubble",
            "Line",
            "Spline",
            "StepLine",
            "FastLine",
            "Bar",
            "StackedBar",
            "StackedBar100",
            "Column",
            "StackedColumn",
            "StackedColumn100",
            "Area",
            "SplineArea",
            "StackedArea",
            "StackedArea100",
            "Pie",
            "Doughnut",
            "Stock",
            "Candlestick",
            "Range",
            "SplineRange",
            "RangeBar",
            "RangeColumn",
            "Radar",
            "Polar",
            "ErrorBar",
            "BoxPlot",
            "Renko",
            "ThreeLineBreak",
            "Kagi",
            "PointAndFigure",
            "Funnel",
            "Pyramid"});
            this.LineTypeToolStripComboBox.Name = "LineTypeToolStripComboBox";
            this.LineTypeToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.LineTypeToolStripComboBox.DropDownClosed += new System.EventHandler(this.LineTypeToolStripComboBox_SelectedIndexChanged);
            this.LineTypeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.LineTypeToolStripComboBox_SelectedIndexChanged);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.textColorToolStripMenuItem,
            this.toolStripSeparator2,
            this.lineColorToolStripMenuItem,
            this.chartBackgroundColorToolStripMenuItem,
            this.gridColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // lineColorToolStripMenuItem
            // 
            this.lineColorToolStripMenuItem.Name = "lineColorToolStripMenuItem";
            this.lineColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.lineColorToolStripMenuItem.Text = "Line Color";
            // 
            // chartBackgroundColorToolStripMenuItem
            // 
            this.chartBackgroundColorToolStripMenuItem.Name = "chartBackgroundColorToolStripMenuItem";
            this.chartBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.chartBackgroundColorToolStripMenuItem.Text = "Chart Background Color";
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.gridColorToolStripMenuItem.Text = "Grid Color";
            // 
            // performanceCounter
            // 
            this.performanceCounter.CategoryName = "Processor";
            this.performanceCounter.CounterName = "% Processor Time";
            this.performanceCounter.InstanceName = "_Total";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 200;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // InstanceLabel
            // 
            this.InstanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstanceLabel.AutoSize = true;
            this.InstanceLabel.Location = new System.Drawing.Point(251, 12);
            this.InstanceLabel.Name = "InstanceLabel";
            this.InstanceLabel.Size = new System.Drawing.Size(31, 13);
            this.InstanceLabel.TabIndex = 7;
            this.InstanceLabel.Text = "2015";
            this.InstanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.ForeColor = System.Drawing.Color.White;
            this.CategoryLabel.Location = new System.Drawing.Point(9, 8);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(143, 19);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "CPU Usage in Percent";
            // 
            // PerformanceGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.InstanceLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.performanceChart);
            this.Name = "PerformanceGraph";
            this.Size = new System.Drawing.Size(248, 264);
            this.Load += new System.EventHandler(this.PerformanceGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceChart)).EndInit();
            this.chartContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart performanceChart;
        private System.Diagnostics.PerformanceCounter performanceCounter;
        private System.Windows.Forms.ContextMenuStrip chartContextMenu;
        private System.Windows.Forms.ToolStripComboBox categoryToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox counterToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox instanceToolStripComboBox;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label InstanceLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem numberOfDataPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox numberOfDataPointsToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox LineTypeToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem lineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.Label CategoryLabel;
    }
}
