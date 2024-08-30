using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.DataVisualization.Charting;
using winForm.Models;

namespace winForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var points = App.DB.PostSeason.Where(x=>x.SeasonId==1).ToList();
            var areas = winForm.ChartAreas.Add("pointArea");
            var sears = winForm.Series.Add("pointColumn");
            sears.ChartType = SeriesChartType.Column;
            winForm.ChartAreas["pointArea"].AxisX.LabelStyle.Angle = -60;
            winForm.ChartAreas[0].AxisX.Interval = 1;
            var charPoint = points.ToDictionary(Key => Key.Team.TeamName, Value => Value.Rank);
            sears.Points.DataBindXY(charPoint.Keys,charPoint.Values);
        }
    }
}
