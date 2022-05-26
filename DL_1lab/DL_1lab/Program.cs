using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayIndex arrayIndex = new ArrayIndex();

            arrayIndex.Fields();
        }
    }
    class ArrayData
    {
        public int n, k, intn = 1, intk = 1, min, intm = 1, res;

        public void Fields()
        {
            Console.Write("Input n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input k:");
            k = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                intn = i * intn;
            }
            min = n - k;
            for (int m = 1; m <= min; m++)
            {
                intm = m * intm;
            }
            res = intn / (intm);
            Console.WriteLine(res);


        }
    }


    class ArrayIndex : ArrayData
    {
        public bool ezz;

        public int masIndex;


    }
}