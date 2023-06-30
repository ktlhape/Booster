using BoosterSession.Models;
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

namespace BoosterSession.Views
{
    /// <summary>
    /// Interaction logic for pgFilter.xaml
    /// </summary>
    public partial class pgFilter : Page
    {
        public pgFilter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Clear();
            string searchText = "";
            int id;
            List<Employee> emList = new List<Employee>();
            Employee em = new Employee();

            if (cmbSearchBy.SelectedItem.ToString().Equals("Employee ID"))
            {
                id = Convert.ToInt32(txtSearch.Text);
                em = Employee.GetEmployee(id);
                lstDisplay.Items.Add(em.ToString());
            }
            else if (cmbSearchBy.SelectedItem.ToString().Equals("Lastname"))
            {
                searchText = txtSearch.Text;
                emList = Employee.GetByLastname(searchText);
                lstDisplay.Items.Add(Employee.GetEmployeesData(emList));
            }
            else if (cmbSearchBy.SelectedItem.ToString().Equals("Max Salary"))
            {
                em = Employee.HighestSalary();
                lstDisplay.Items.Add(em.ToString());
            }
            else if (cmbSearchBy.SelectedItem.ToString().Equals("Is Married"))
            {
                emList = Employee.MarriedEmployees();
                lstDisplay.Items.Add(Employee.GetEmployeesData(emList));
            }
            else if (cmbSearchBy.SelectedItem.ToString().Equals("Emplyoment"))
            {
                searchText = txtSearch.Text;
                emList = Employee.GetByEmployment(searchText);
                lstDisplay.Items.Add(Employee.GetEmployeesData(emList));
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            cmbSearchBy.Items.Add("Employee ID");
            cmbSearchBy.Items.Add("Lastname");
            cmbSearchBy.Items.Add("Max Salary");
            cmbSearchBy.Items.Add("Is Married");
            cmbSearchBy.Items.Add("Emplyoment");
        }
    }
}
