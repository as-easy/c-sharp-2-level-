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
    internal interface IEmployeePayment
    {
        /// <summary>
        ///     Метод для расчета заработной платы
        /// </summary>
        /// <param name="payment">Заработная плата</param>
        double Pay(double payment);
    }
}
