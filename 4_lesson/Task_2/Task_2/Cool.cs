using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Cool<T>
    {
        public void Fun(List<T> coll)
        {
            int n = 1;

            coll.Sort();

            for (int i = 0; i < coll.Count; i++)
            {
                Console.Write($"Object {coll[i]}");
                for (int j = i+1; j < coll.Count; j++)
                {

                    if (coll[i].Equals(coll[j])) n++;
                    else 
                    {
                        i = j-1;
                        break;
                    }

                    if (j == coll.Count - 1) i = j;
                }

                Console.Write($" occurs in the collection: {n} times");
                n = 1;

                Console.WriteLine();
            }
        }
    }
}
