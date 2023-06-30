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
    /// Interaction logic for pgCapture.xaml
    /// </summary>
    public partial class pgCapture : Page
    {
        public pgCapture()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            int id, experience;
            string firstaname, lastname, phone; 
            string employmentType ="";
            double salary;
            bool isMarried = false;

            //Add Validations 

            
            id = Convert.ToInt32(txtEmployeeID.Text);
            firstaname = txtFirstname.Text;
            lastname = txtLastname.Text;
            phone = txtPhone.Text;
            salary = Convert.ToDouble(txtSalary.Text);
            experience = Convert.ToInt32(txtExp.Text);

            isMarried = (chkIsMarried.IsChecked == true); //This can either be true or false

            if (rdoContractor.IsChecked == true)
            {
                employmentType = "Contractor";
            }else if (rdoFull.IsChecked == true)
            {
                employmentType = "Full-Time";
            }
            else if (rdoPart.IsChecked == true)
            {
                employmentType = "Part-Time";
            }

            Employee em = new Employee(id, firstaname, lastname, phone, salary, experience, employmentType, isMarried);
            Employee.AddEmployee(em);
            ClearForm();
        }
        private void ClearForm()
        {
            txtEmployeeID.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPhone.Clear();
            txtExp.Clear();
            txtSalary.Clear();
            txtEmployeeID.Focus();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }
    }
}
