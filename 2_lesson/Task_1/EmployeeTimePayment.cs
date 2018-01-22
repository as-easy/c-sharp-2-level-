using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class EmployeeTimePayment : ArrayEmployee, IEmployeePayment
    {
        public double Pay(double timepayment) => 20.8 * 8 * timepayment;

        public override void ReadEmployeeDB(string pathEmployeeDB)
        {
            Console.WriteLine("Employee with time playment:\n");
            base.ReadEmployeeDB(pathEmployeeDB);
            
        }
    }
}
