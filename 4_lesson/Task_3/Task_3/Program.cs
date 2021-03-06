﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"four",4 },
                {"two",2 },
                { "one",1 },
                {"three",3 },
            };
                         
            var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; }); //Анонимный метод
            Program.ToDisplay(d);

            var d1 = dict.OrderBy(pair => pair.Value); //3.а С лямбда-выражением
            Program.ToDisplay(d1);

            Func<KeyValuePair<string, int>, int> fun = delegate (KeyValuePair<string, int> pair1) { return pair1.Value; }; //для собственного понимания
            var d2 = dict.OrderBy(fun);
            Program.ToDisplay(d2);
           
            fun += Program.FunKeyPair;  //3.Б
            var d3 = dict.OrderBy(fun);
            Program.ToDisplay(d3);

            Console.ReadKey();
        }

        static int FunKeyPair(KeyValuePair<string, int> pair)
        {
            return pair.Value;
        }

        static void ToDisplay(IOrderedEnumerable<KeyValuePair<string, int>> dictSort)
        {
            foreach (var pair in dictSort)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();
        }
    }
}
