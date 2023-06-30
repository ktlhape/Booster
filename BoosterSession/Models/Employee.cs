using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoosterSession.Models
{
    /// <summary>
    /// Employee class to store employee details and a list of all employees
    /// </summary>
    public class Employee
    {
        public int EmployeeID { get; set; } 
        public string Firstname { get; set; } 
        public string Lastname { get; set; } 
        public string Phone { get; set; }
        public double Salary{ get; set; }
        public int YearsOfExperience { get; set; }
        public string EmployementType { get; set; }
        public bool IsMarried { get; set; }
        public static List<Employee> Employees { get; set; } = new List<Employee>() 
        {
            new Employee(123,"Steve", "Jobs", "012345678",15700,5,"Part-Time",true),
            new Employee(124,"Martin", "Lawrance", "012345678",16500,12,"Full-Time",false),
            new Employee(125,"Roger", "Federer", "012345678",23000,15,"Part-Time",true),
            new Employee(126,"Jessica", "Parks", "012345678",23750,5,"Full-Time",false),
            new Employee(127,"Serena", "Williams", "012345678",25300,5,"Contractor",false),
            new Employee(128,"Novak", "Djokovic", "012345678",26000,5,"Full-Time",true),
            new Employee(129,"Veronica", "Parks", "012345678",20400,5,"Contractor",true),
        };
        public Employee() { }
        public Employee(int employeeID, string firstname, string lastname, string phone, double salary, int yearsOfExperience, string employementType, bool isMarried)
        {
            EmployeeID = employeeID;
            Firstname = firstname;
            Lastname = lastname;
            Phone = phone;
            Salary = salary;
            YearsOfExperience = yearsOfExperience;
            EmployementType = employementType;
            IsMarried = isMarried;
        }
        public static void AddEmployee(Employee em)
        {
            Employees.Add(em);

        }
        /// <summary>
        /// Get Employee with Employee ID <paramref name="id"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Employee object with Employee ID <paramref name="id"/></returns>
        public static Employee GetEmployee(int id)
        {
            //Simplified
           return Employees.Find(e => e.EmployeeID == id);
        }
        /// <summary>
        /// Get all Employees with the same <paramref name="lastname"/>
        /// </summary>
        /// <param name="lastname"></param>
        /// <returns>List of Employees with the matching <paramref name="lastname"/></returns>
        public static List<Employee> GetByLastname(string lastname)
        {
          return Employees.FindAll(e => e.Lastname.Equals(lastname)).ToList();
        }
        /// <summary>
        /// Get Employee with the highest salary
        /// </summary>
        /// <returns>Employee object with the highest salary</returns>
        public static Employee HighestSalary()
        {
            double maxSalary = Employees.Max(e => e.Salary);
          return Employees.Find(x => x.Salary == maxSalary);
        }
        /// <summary>
        /// Get Employees with a married status of true
        /// </summary>
        /// <returns>List of all employees who are married</returns>
        public static List<Employee> MarriedEmployees()
        {
            return Employees.Where(x => x.IsMarried.Equals(true)).ToList();
        }
        /// <summary>
        /// Get Employees with the specified employment type of <paramref name="type"/>
        /// </summary>
        /// <param name="type">Employment Type</param>
        /// <returns>All Employees matching the specified employment type <paramref name="type"/></returns>
        public static List<Employee> GetByEmployment(string type)
        {
            return Employees.Where(x => x.EmployementType.Equals(type)).ToList();
        }
        /// <summary>
        /// Get Employees data from a <paramref name="emList"/>
        /// </summary>
        /// <param name="emList"></param>
        /// <returns>String containing employee data</returns>
        public static string GetEmployeesData(List<Employee> emList)
        {
            string strOutput = "";
            foreach (Employee em in emList)
            {
                strOutput += em.ToString() + "\n";
            }
            return strOutput;
        } 
        public override string ToString()
        {
            return $"({EmployeeID}) : {Firstname} {Lastname} - {Salary}\n" +
                $"Experience: {YearsOfExperience}\n" +
                $"Employment Type: {EmployementType}\n" +
                $"Married? {IsMarried}\n";
        }
    }
}
