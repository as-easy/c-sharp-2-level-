using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Task_1
{
    /// <summary>
    ///     Разработчик: Варанкин Владимир
    /// </summary>
    /// 
    class Program
    {
        /// <summary>
        ///     Реализация 1 и 4, задания
        ///     <para>pathFixEmployeeDB - Константа с несуществующим файлом</para>
        ///     <para>pathTimeEmployeeDB - Константа с БД сотрудников с почасовой оплатой</para>
        /// </summary>  
        /// 
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
            timeEmployee.ToDisplay();

            //1.в) *Реализовать интерфейсы для возможности сортировки массива используя Array.Sort(). 
            //Взял пример из справки https://msdn.microsoft.com/ru-ru/library/system.icomparable(v=vs.110).aspx 
            //Правда, всего этого можно было не делать, а применить  timeEmployee.strarr.Sort() без реализации интерфейса IComparable
            #region 1в
            {
                ArrayList arrayEmployee = new ArrayList();

                for (int i = 0; i < timeEmployee.strarr.Count; i++)
                {
                    ArrayEmployee ae = new ArrayEmployee();
                    ae.Tostrtemp = timeEmployee.strarr[i].ToString();
                    arrayEmployee.Add(ae);
                }

                Console.WriteLine("1.в) Реализация сортировки");
                arrayEmployee.Sort();

                foreach (ArrayEmployee t in arrayEmployee)
                {
                    Console.WriteLine("\t" + t.Tostrtemp);
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
