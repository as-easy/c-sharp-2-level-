using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Task_1
{
    internal class ArrayEmployee : AbstractArrayEmployee, IComparable
    {
        public string strtemp;

        override public void ReadEmployeeDB(string pathEmployeeDB)
        {
            try
            {
                if (!File.Exists(pathEmployeeDB))
                    throw new FileNotFoundException("Fail not found " + pathEmployeeDB + "\n");

                using (StreamReader str = new StreamReader(pathEmployeeDB))
                {
                    int i = 0;                    

                    while (!str.EndOfStream)
                    { 
                        strarr.Add(str.ReadLine());                        
                        i++;
                    } 
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public string Tostrtemp
        {
            get { return strtemp; }

            set { strtemp = value; }
        }


        public void ToDisplay()
        {
            if (strarr != null)
            {
                foreach (var str in strarr)
                {
                    Console.WriteLine("\t"+str);
                }
                Console.WriteLine("\n");
            }
        }


        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is ArrayEmployee strarr)
                return this.strtemp.CompareTo(strarr.strtemp);
            else
                throw new ArgumentException("Object is not a ArrayEmployee");
        }
    }
}
