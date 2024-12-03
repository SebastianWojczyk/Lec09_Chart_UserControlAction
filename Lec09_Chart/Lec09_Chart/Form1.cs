using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lec09_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart.Palette = ChartColorPalette.Fire;

            //Series function = new Series("f(x) = x²");
            //Series function2 = new Series("f(x) = 10x");

            //function.ChartType = SeriesChartType.Line;
            //function.BorderWidth = 3;
            ////function.Color = Color.Brown;

            //function2.ChartType = SeriesChartType.Line;
            //for (double x = -10; x <= 10; x += 1)
            //{
            //    DataPoint d = new DataPoint();
            //    d.SetValueXY(x, x * x);

            //    d.MarkerStyle = MarkerStyle.Circle;
            //    d.MarkerSize = 3;

            //    if (Math.Abs(3 + x) < 0.001)
            //    {
            //        d.Label = $"f({x}) = {x * x}";
            //    }

            //    function.Points.Add(d);

            //    function2.Points.AddXY(x, 10 * x);

            //}

            //chart.Series.Add(function);
            //chart.Series.Add(function2);

            //chart.ChartAreas.First().RecalculateAxesScale();

            //chart.ChartAreas.First().AxisY.Minimum = -100;
            //chart.ChartAreas.First().AxisY.Maximum = 100;

            //chart.ChartAreas.First().AxisX.Crossing = 0;
            //chart.ChartAreas.First().AxisX.MajorGrid.Enabled = false;

            //chart.ChartAreas.First().AxisY.Crossing = 0;
            //chart.ChartAreas.First().AxisY.MajorGrid.Enabled = false;

            userControlFunction_FunctionChanged();
        }

        private void userControlFunction_FunctionChanged()
        {
            chart.Series.Clear();

            int i = 1;
            foreach (UserControlFunction u in flowLayoutPanel.Controls)
            {
                Series s = new Series();
                s.Name = $"{i++}. {u.FunctionDescription}";

                for (double x = -10; x <= 10; x += 1)
                {
                    s.Points.AddXY(x, u.GetValueY(x));
                }

                chart.Series.Add(s);
            }
            chart.ChartAreas.First().RecalculateAxesScale();
        }
    }
}
