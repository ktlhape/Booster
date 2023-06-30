using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoosterSession.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Desc { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
