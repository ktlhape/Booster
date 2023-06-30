using BoosterSession.Models;
using BoosterSession.Views;
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

namespace BoosterSession
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        pgCapture capture = new pgCapture();
        pgFilter filter = new pgFilter();
        pgStats stats = new pgStats();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnCapture_Click(object sender, RoutedEventArgs e)
        {
            frmContainer.Content = capture;
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            frmContainer.Content = filter;
        }

        private void btnStats_Click(object sender, RoutedEventArgs e)
        {
            frmContainer.Content = stats;
        }
    }
}
