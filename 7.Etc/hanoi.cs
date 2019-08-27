using System;
using System.Collections.Generic;

namespace _7.Etc
{
    class Hanoi
    {
        public static Stack<int> Move(Stack<int> s1, Stack<int> s2, Stack<int> s3, int n)
        {
            if (n > 0)
            {
                Move(s1, s3, s2, n - 1);
                int i = s1.Pop();
                s3.Push(i);
                Move(s2, s1, s3, n - 1);
            }
            return s3;
        }
    }
}
