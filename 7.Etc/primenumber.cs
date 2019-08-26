using System;
using System.Linq;

namespace _7.Etc
{
    class PrimeNumber
    {
        /// <summary>
        /// 素数判定法
        /// <param name="pnumber">素数判定をする</param>
        /// </summary>
        public static void Judge(int pnumber, int degree)
        {
            if (pnumber < degree)
            {
                Console.WriteLine("");
                return;
            }

            Random rnd = new System.Random();
            double[] rndArray = new double[degree];
            int count = 0;
            while (count < degree)
            {
                double p = rnd.Next(1, pnumber);
                if (!(rndArray.Any(s => s == p)))
                {
                    rndArray[count] = p;
                    count++;
                }
            }

            foreach (double i in rndArray)
            {
                var res = (Math.Pow(i, pnumber)) % pnumber;
                if (res != i)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }

            Console.WriteLine("Prime");

        }
    }
}
