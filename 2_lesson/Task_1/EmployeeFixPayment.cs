using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class EmployeeFixPayment : ArrayEmployee, IEmployeePayment
    {
        public double Pay(double fixpayment) => fixpayment;

        public override void ReadEmployeeDB(string pathEmployeeDB)
        {
            Console.WriteLine("Employee with fix playment:\n");
            base.ReadEmployeeDB(pathEmployeeDB);            
        }
    }
}
