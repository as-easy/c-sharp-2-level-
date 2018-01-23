using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class EmployeeTimePayment : ArrayEmployee, IEmployeePayment
    {
        /// <summary>
        ///     1.а) Расчет среднемесячной заработной платы с почасовой оплатой
        /// </summary>
        /// <param name="timepayment">Почасовая оплата</param>
        public double Pay(double timepayment) => 20.8 * 8 * timepayment;

        /// <summary>
        ///     1.б) Заполнение массива сотрудников с почасовой оплатой
        /// </summary>
        /// <param name="pathEmployeeDB">Путь к БД сотрудников</param>
        public override void ReadEmployeeDB(string pathEmployeeDB)
        {
            Console.WriteLine("Employee with time playment:\n");
            base.ReadEmployeeDB(pathEmployeeDB);
            
        }
    }
}
