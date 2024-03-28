using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract decimal CalculateMonthlyPayment();
    }

    public class Secretary : Employee 
    {
        
    }

    public class Manager : Employee
    {

    }
}
