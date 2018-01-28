using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> arrListInt = new List<int>
            {
               // 87,1,1,2,2,3,6,2,4,2,7,4,9,2,893,4,5,87,2,4,52,893,7,23,5,6,
               1,1,2,3,4,5,1,2,3,4,5,5,5
            };
            Cool<int> displayInt = new Cool<int>();
            displayInt.Fun(arrListInt);
            Console.WriteLine();

            List<string> arrListString = new List<string>
            {
                "aaaa","aaaa", "aaaa", "bb","bb", "aaaa","c"
            };    
            Cool<string> displayString = new Cool<string>();
            displayString.Fun(arrListString);

            var elements = from n in arrListInt //c LINQ пока не сделал
                          orderby n descending                           
                          select n;            

            Console.ReadKey();

        }        
    }
}
