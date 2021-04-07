using System;

namespace Chap_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5.1
            /*
            double x, y;
            Console.WriteLine("enter the value of x + y = ");
             double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of x - y = ");
             double m = Convert.ToDouble(Console.ReadLine());

            y = (n - m) / 2;

            x = n - y;

            Console.WriteLine(($"x = {x} and y = {y}")); p;/
            */
            #endregion

            #region 5.2/3
            /*
            double x, y,a1,a2,b1,b2,c1,c2;

            Console.WriteLine("enter the value of a1 = ");
            a1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of a2 = ");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of b1 = ");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of b2 = ");
            b2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of x + y = ");
             c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of x - y = ");
             c2 = Convert.ToDouble(Console.ReadLine());

            double s = ((a1 * b2) - (a2 * b1));
            if ((int)s == 0)
            {
                Console.WriteLine("x and y are not determinent");
            }
            else
            {
                x = ((b2 * c1) - (b1 * c2)) / s;

                y = ((a1 * c2) - (a2 * c1)) / s;

                Console.WriteLine(($"x = {x} and y = {y}"));
            }
            */
            #endregion

            #region 5.4
            /*
            double total_amount, interest_rate, monthly_amount, time, total_payable;

            Console.WriteLine("enter the total amount taken = ");
            total_amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the interest rate = ");
            interest_rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the time = ");
            time = Convert.ToDouble(Console.ReadLine());

            total_payable = total_amount + (total_amount * ((interest_rate*time) / 100.00));

            monthly_amount = total_payable / (time*12);

            Console.WriteLine($"Total payable with interest {total_payable:F2} ");
            Console.WriteLine($"Monthly payable with interest {monthly_amount:F2}"); //F2 = floating point 0.00
            */


            #endregion

            #region 5.4
            /*
            double v, t,s;
            Console.Write("enter velocity value: ");
            v = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter time value: ");
            t = Convert.ToDouble(Console.ReadLine());
            s = 2 * v * t;
            Console.WriteLine($"ans : {s:F2}",s);
            */
            #endregion

            #region 5.6
            /*
            int i,k=0;
            for (i = 1; i <= 1000; i++)
            {
                k = i + k;
            }
            Console.WriteLine(k) ;
            */
            #endregion

            #region 5.6/7
            /*
            int a;
            double f, c;
            Console.WriteLine(" press \n1. farenheit to celcius .\n2. celcius to fernheit");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {  
                
                case 1:
                    
                    Console.WriteLine("enter value: ");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = (f - 32) / 1.8;
                    Console.WriteLine($"{f} farenheit is equal to {c:F2} celcius.");
                    break;

                case 2:
                    
                    Console.WriteLine("enter value: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = (c * 1.8) + 32;
                    Console.WriteLine($"{c} celcius is equal to {f:F2} farenheit.");
                    break;

                default:
                        Console.WriteLine("wrong input");
                        break;
                    
            }
            */
            #endregion

            #region 5.8
            
            int a, b,x, gcd=0;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                x = b;
            }
            else
            {
                x = a;
            }
           
            for ( ; x >= 1; x--)
            {
                if ( a% x == 0 && b % x == 0)
                {
                    gcd = x;
                    break;
                }
            }
            Console.WriteLine($"gcd is : {gcd}");
            
            #endregion

            #region 5.9
            /*
            int a, b, gcd, x, t;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                x = b;
            }
            else if (a < b)
            {
                x = a;
            }

            if (a == 0)
            {
                gcd = a;
            }
            else if (b == 0)
            {
                gcd = b;
            }
            else
            {
                while (b != 0)
                {
                    t = b;
                    b = a % b;
                    a = t;
                }
                gcd = a;
                Console.WriteLine("gcd is : " + a);
                

            }
            */
            #endregion

            #region 5.10 \\ LCM
            /*
            int a, b, gcd, x, t,lcd,k;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            k = a * b;
            if (a > b)
            {
                x = b;
            }
            else if (a < b)
            {
                x = a;
            }

            if (a == 0)
            {
                gcd = a;
            }
            else if (b == 0)
            {
                gcd = b;
            }
            else
            {
                while (b != 0)
                {
                    t = b;
                    b = a % b;
                    a = t;
                }
                gcd = a;
           

            }
            lcd = k / gcd;
            Console.WriteLine("lcd :"+lcd);
            */
            #endregion

        }
    }
}