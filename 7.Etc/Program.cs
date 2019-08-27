using System;
using System.Collections.Generic;

namespace _7.Etc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("//----- Judge PrimeNumber -----//");
            int pnumber = 13;
            int degree = 3;
            PrimeNumber.Judge(pnumber, degree);

            Console.WriteLine("//----- Tower of Hanoi -----//");
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();
            var s3 = new Stack<int>();
            int n = 10;

            for (int i = n; 1 <= i; i--)
            {
                s1.Push(i);
            }

            var s4 = Hanoi.Move(s1, s2, s3, n);

            foreach (int i in s4)
            {
                Console.WriteLine(i);
            }

        }
    }
}
