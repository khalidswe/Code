using System;

namespace LeetCodeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] num = { 2, 5, 7, 6, 10, 23 };
            int target = 12;
            int[] f = { };
            for (i = 0; i < num.Length; i++)
            { 
                if (num[i]+ num[i+1] == target)
                {
                    f[i] = i;
                }
            }
            
            
            Console.WriteLine(f[i]);
            
        }
    }
}
