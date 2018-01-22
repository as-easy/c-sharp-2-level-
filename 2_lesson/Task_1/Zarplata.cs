using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    public abstract class EmployeePayment
    {
        protected Array EmployeeArray;
       // protected string pathEmployeeDB;      
        abstract public double Pay(double payment);        
    }

    public class EmployeeFixPayment : EmployeePayment
    {
        string pathEmployeeDB = @"EmployeeDB\FixEmployeeDB.txt";
        StreamReader str = new StreamReader(pathEmployeeDB);

        public override double Pay(double fixpayment) => fixpayment;     
        
        

        new Array EmployeeArray = Array.CreateInstance(typeof(string) );
            
    }

    public class EmployeeTimePayment : EmployeePayment
    {
        public override double Pay(double timepayment) => 20.8 * 8 * timepayment;       
    }
}
