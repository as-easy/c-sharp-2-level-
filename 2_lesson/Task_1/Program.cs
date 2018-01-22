using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double fixpayment = 90000;
            const double timepayment = 500;
            EmployeePayment fixemloyee = new EmployeeFixPayment();
            EmployeePayment timeemployee = new EmployeeTimePayment();

            Console.WriteLine($"Среднемесячная заработная плата с фиксированной оплатой = {fixemloyee.Pay(fixpayment)}");
            Console.WriteLine($"Среднемесячная заработная плата с почасовой оплатой = {timeemployee.Pay(timepayment)}");

            string pathEmployeeDB = @"EmployeeDB\FixEmployeeDB.txt";
            StreamReader str = new StreamReader(pathEmployeeDB);
        }
    }
}
