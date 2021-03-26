using System.Windows.Forms;
using task_5;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            decimal[] masY =
            {
                (decimal) 0.26183, (decimal) 0.27644, (decimal) 0.29122, (decimal) 0.30617, (decimal) 0.32130,
                (decimal) 0.33660, (decimal) 0.35207, (decimal) 0.36773, (decimal) 0.38537, (decimal) 0.39959
            };
            double x0 = 0.01;
            double h = 0.05;
            double xn = 0.46;
            
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            var points = Test.Calculate();
            for (int i = 0; i < points.GetLength(0); i++)
            {
                if (points[i, 0] != 0 && points[i, 1] != 0)
                {
                    chart1.Series[0].Points.AddXY((double) points[i, 0], (double) points[i, 1]);
                }
            }

            int j = 0;
            for (double i = x0; i <= xn; i+=h)
            {
                chart1.Series[1].Points.AddXY(i, (double)masY[j]);
                j++;
            }

            
            chart1.Series[1].MarkerSize = 8;
            chart1.Series[1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.Minimum = 0.25;
            chart1.ChartAreas[0].AxisY.Maximum = 0.4;
            chart1.ChartAreas[0].AxisX.Minimum = 0.0;
            chart1.ChartAreas[0].AxisX.Maximum = 0.46;
        }
    }
}