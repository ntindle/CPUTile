using PromiseTechnology;
using PromiseTechnology.Windowing;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace PromiseTechnology.DesktopTiles {
    public partial class PerformanceGraph : UserControl {
        private string[] performanceCounterInfo = new string[3] { null, null, null };

        [Browsable(true)]
        [Description("Chart starts running Automatically"), Category("Behavior")]
        public bool ChartRunning { get; set; }

        [Browsable(true)]
        public new string Text {
            get {
                return CategoryLabel.Text;
            }
            set {
                CategoryLabel.Text = value;
            }
        }

        public int NumberOfDataPoints { get; set; }

        public int RefreshRate {
            get {
                return refreshTimer.Interval;
            }
            set {
                refreshTimer.Interval = value;
            }
        }

        public PerformanceGraph() {
            InitializeComponent();
            this.chartContextMenu.Visible = false;
            this.NumberOfDataPoints = 50;
        }

        public void PerformanceGraph_Load(object sender, EventArgs e) {
            this.numberOfDataPointsToolStripComboBox.Select(0, 2);
        }

        /// <summary>
        /// Add the current performance 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshTimer_Tick(object sender, EventArgs e) {
            if (ChartRunning == true) {
                updatePerformanceData();
            }
        }

        #region ContextMenu

        //contextMenuEvents

        /// <summary>
        /// Pause The Chart so things don't get wacky while we change it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void chartContextMenu_Opening(object sender, CancelEventArgs e) {
            pauseChart();
        }

        /// <summary>
        /// Resume the chart after we close the context menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void chartContextMenu_Closing(object sender, ToolStripDropDownClosingEventArgs e) {
            resumeChart();
        }



        /// <summary>
        /// Sets the <code>NumberOfDataPoints</code> for the Graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void numberOfDataPointsToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            NumberOfDataPoints = int.Parse(this.numberOfDataPointsToolStripComboBox.SelectedItem.ToString());
            resumeChart();
        }

        /// <summary>
        /// ComboBox to select the line type during runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LineTypeToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            this.performanceChart.Series.FirstOrDefault().ChartType = (SeriesChartType)this.LineTypeToolStripComboBox.SelectedIndex;
            resumeChart();
        }


        #endregion ContextMenu

        public void pauseChart() {
            Console.WriteLine("Chart paused");
            ChartRunning = false;
        }
        public void resumeChart() {
            Console.WriteLine("Chart Resumed");
            ChartRunning = true;
        }

        public void updatePerformanceData() {
            PerformanceCounterCategory category = new PerformanceCounterCategory(this.performanceCounter.CategoryName);

            if (category.CounterExists(this.performanceCounter.CounterName)) {
                float nextValue = performanceCounter.NextValue();
                CounterSample nextSample = performanceCounter.NextSample();
                FormsConsole.WriteLine(nextSample);
                FormsConsole.WriteLine(nextValue);
                if (performanceChart.Series.FirstOrDefault().Points.Count > NumberOfDataPoints) {
                    performanceChart.Series.FirstOrDefault().Points.RemoveAt(0);
                    //performanceChart.Series.FirstOrDefault().Points.RemoveAt(0);
                } else {
                    try {
                        performanceChart.Series.FirstOrDefault().Points.AddXY(DateTime.Now, nextValue);
                    } catch (Exception e) {
                        FormsConsole.WriteLine(e.ToString()).WriteLine(nextValue.ToString())
                            .WriteLine("BaseValue: {0} CounterFrequency: {1} CounterTimeStamp: {2} CounterType: {3} RawValue: {4}"
                            .FormatStr(nextSample.BaseValue, nextSample.CounterFrequency, nextSample.CounterTimeStamp, nextSample.CounterType.ToString(), nextSample.RawValue));

                        this.CategoryLabel.Text = "Something Went Wrong...";
                        this.InstanceLabel.Text = "My Bad";
                    }

                }
            } else {
                Console.WriteLine("Counter {0} does not exist for category {1}", performanceCounter.CounterName, performanceCounter.CategoryName);
            }
        }
    }
}