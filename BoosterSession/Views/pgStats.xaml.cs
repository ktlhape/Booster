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
using BoosterSession.Models;
using LiveCharts;
using LiveCharts.Wpf;

namespace BoosterSession.Views
{
    /// <summary>
    /// Interaction logic for pgStats.xaml
    /// </summary>
    public partial class pgStats : Page
    {
        public SeriesCollection MyEmployees { get; set; }
        public pgStats()
        {
            InitializeComponent();
            ShowChart();
            DataContext = this;
        }

        public void ShowChart()
        {
            MyEmployees = new SeriesCollection();
            PieSeries ps;
            string[] employment = new string[] { "Full-Time", "Part-Time", "Contractor" };
            foreach (string type in employment)
            {
                ps = new PieSeries();
                ps.Title = type;
                int value = Employee.Employees.Count(x => x.EmployementType.Equals(type));
                ps.Values = new ChartValues<int> { value};
                ps.DataLabels = true;
                MyEmployees.Add(ps);

            }
        }
    }
}
