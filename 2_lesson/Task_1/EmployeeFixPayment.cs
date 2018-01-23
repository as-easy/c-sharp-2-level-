using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    ///     1.а) Описать в базовом классе абстрактный метод для расчёта среднемесячной заработной платы.
    /// </summary>
    internal class EmployeeFixPayment : ArrayEmployee, IEmployeePayment
    {
        /// <summary>
        ///     1.а) Расчет среднемесячной заработной платы с фиксированной оплатой
        /// </summary>
        /// <param name="fixpayment">Фиксированная оплата</param>
        public double Pay(double fixpayment) => fixpayment;

        /// <summary>
        ///     1.б) Заполнение массива сотрудников с фиксированной оплатой
        /// </summary>
        /// <param name="pathEmployeeDB">Путь к БД сотрудников</param>
        public override void ReadEmployeeDB(string pathEmployeeDB)
        {
            Console.WriteLine("Employee with fix playment:\n");
            base.ReadEmployeeDB(pathEmployeeDB);            
        }
    }
}
