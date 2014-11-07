using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace getproductsofallintsexceptatindex
{
    class Program
    {
        static void Main(string[] args)
        {
            getproductsofallintsexceptatindex(new[] { 1, 7, 3, 4 });
        }

        public static int[] getproductsofallintsexceptatindex(int[] a)
        {
            int[] b = new int[4];
           
            for (int i = 0; i < a.Length; i++)
            {
                int s = 1;
                for (int j = 0; j < a.Length; j++)
                {
                    if (i != j)
                    {
                        s *= a[j];
                    }
                }
                b[i] = s;
            }
            return b;

        }
    }
}
