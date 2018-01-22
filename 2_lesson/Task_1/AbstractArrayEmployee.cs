using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_1
{
    abstract internal class AbstractArrayEmployee
    {
        internal ArrayList strarr = new ArrayList();
            //string[] strarr;
        abstract public void ReadEmployeeDB(string pathEmployeeDB);
    }
}
