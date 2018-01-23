using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_1
{
    /// <summary>
    ///     1.б) Создать на базе абстрактного класса массив сотрудников и заполнить его. 
    /// </summary>
    abstract internal class AbstractArrayEmployee
    {
        internal ArrayList strarr = new ArrayList();
        
        abstract public void ReadEmployeeDB(string pathEmployeeDB);
    }
}
