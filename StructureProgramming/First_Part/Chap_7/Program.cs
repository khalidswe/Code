using System;

namespace Chap_7
{
    class Program
    {
        #region 7.2
        /*
        static double add(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }*/
        #endregion
        #region 7.6
        /*
        static int test_fuction(int x)
        {
            int y = x;
            x = 2 * y;
            return (x * y);
        }*/
        #endregion

        #region
        /*
        double pi = 3.14;
        void pi_func()
        {
            pi = 3.1416;
            return;
        }*/
        #endregion

        #region
        /*
        static int max_func(int[] arr, int n)
        {
            int max = arr[0];

            int i;
            for (i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;

        }
        */
        #endregion


        static void Main(string[] args)
        {
            #region 7.1
            /*
            double a=2.5, b =2.5, c;
            c = a + b;
            Console.WriteLine(c);
            */
            #endregion

            #region 7.2
            /*
            double a, b, c;
            a = 3.0;
            b = 3.5;
            c = add(a, b);
            Console.WriteLine(c);
            */
            #endregion
            #region
            /*
            int x = 10, y = 20, z = 30;

            z = test_fuction(x);
            Console.WriteLine($"{x} , {y} , {z}");
            */
            #endregion

            #region
            /*
            int[] arr = { -100,0,53,22,83,23,89,-132,201,3,85};
            int n = 11;

            int max = max_func(arr, n);
            Console.WriteLine(max);
            */
            #endregion

        }
    }
}
