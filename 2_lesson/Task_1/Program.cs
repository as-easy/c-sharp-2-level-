using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double fixpayment = 90000;
            const double timepayment = 500;
            //const string pathFixEmployeeDB = @"EmployeeDB\FixEmpoyeeDB.txt";
            const string pathFixEmployeeDB = @"EmployeeDB\test.txt";
            const string pathTimeEmployeeDB = @"EmployeeDB\TimeEmpoyeeDB.txt";
            EmployeeFixPayment fixEmloyee = new EmployeeFixPayment();
            EmployeeTimePayment timeEmployee = new EmployeeTimePayment();

            Console.WriteLine($"Среднемесячная заработная плата с fix оплатой = {fixEmloyee.Pay(fixpayment)}");
            Console.WriteLine($"Среднемесячная заработная плата с time оплатой = {timeEmployee.Pay(timepayment)}\n");

            fixEmloyee.ReadEmployeeDB(pathFixEmployeeDB);
            fixEmloyee.ToDisplay();

            timeEmployee.ReadEmployeeDB(pathTimeEmployeeDB);
           // timeEmployee.S
            timeEmployee.ToDisplay();

            

            ArrayList arrayEmployee = new ArrayList();

            //arrayEmployee.Add(timeEmployee.strarr);

            for (int i = 0; i < timeEmployee.strarr.Count; i++)
            {                
                ArrayEmployee ae = new ArrayEmployee();
                ae.Tostrtemp = timeEmployee.strarr[i].ToString();
                arrayEmployee.Add(ae);
            }

            arrayEmployee.Sort();

           // timeEmployee.strarr.Sort();

            foreach (ArrayEmployee t in arrayEmployee)
            {
                Console.WriteLine(t.Tostrtemp);
            }

            Console.ReadKey();
        }
    }
}
