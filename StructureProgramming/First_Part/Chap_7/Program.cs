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

        #region 7.8
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

        #region 7.8 ex
        /*
        static int min_func(int[] arr, int n)
        {
            int min = arr[0];

            int i;
            for (i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min= arr[i];
                }
            }
            return min;

        }
        */
        #endregion

        #region 7.9
        /*
        static void test_arr(int[] arr)
        {
            arr[0] = 100;
            return;
        }
        */
        #endregion

        #region 7.9 ex

        static double areaofCircle(double pi,double radius)
        {
            double area = (pi * (radius*radius ));
            return area;
        }
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

            #region  7.6
            /*
            int x = 10, y = 20, z = 30;

            z = test_fuction(x);
            Console.WriteLine($"{x} , {y} , {z}");
            */
            #endregion

            #region 7.8
            /*
            int[] arr = { -100,0,53,22,83,23,89,-132,201,3,85};
            int n = 11;

            int max = max_func(arr, n);
            Console.WriteLine(max);
            */
            #endregion

            #region 7.8 ex
            /*
            int[] arr = { -100, 0, 53, 22, 83, 23, 89, -132, 201, 3, 85 };
            int n = 11;

            int min = min_func(arr, n);
            Console.WriteLine(min);
            */
            #endregion

            #region 7.9
            /*
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr[0]);
            test_arr(arr);
            Console.WriteLine(arr[0]);
            */
            #endregion

            #region 7.9 ex

            double area, pi = 3.1416, radius;
            Console.WriteLine("enter radius value : ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = areaofCircle(pi,radius);
            Console.WriteLine($"area is : {area:F2}");
            #endregion
        }
    }
}
