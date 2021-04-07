using System;

namespace Chap_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region: 2.1
            /*int a;
            int b;
            int sum;

            a = 50;
            b = 60;
            sum = a + b;
            Console.WriteLine("sum is "+sum);
            */
            #endregion

            #region: 2.2
            /*int a, b, sum;
            a = 50;
            b = 60;
            

            sum = a + b;
            Console.WriteLine("sum is " + sum);
            */
            #endregion

            #region: 2.3
            /*
            int a=50, b=60, sum;
            
            sum = a + b;
            Console.WriteLine("sum is " + sum);
            */
            #endregion

            #region: 2.4
            /*
            int x,y;
            x=1;
            y=x;
            x=2;
           
            Console.WriteLine(y);
            */
            #endregion

            #region: 2.5
            /*
            int a=50, b=60, sum;
            
            sum = a + b;
            Console.WriteLine($"{a} + {b} = " + sum);
            */
            #endregion

            #region: 2.6
            /*
            int a=50, b=60, sum;
            
            sum = a + b;
            Console.WriteLine($"{a} + {b} = " + sum);
            */
            #endregion

            #region: 2.7
            /*
            int n;
            double x;
            x=10.5;
            n= (int) x;
            
            Console.WriteLine("the value of n is " + n);
            Console.WriteLine("the value of x is " + x);
            */
            #endregion

            #region: 2.9
             /*     
          
            double a,b,sum;
            a=9.5;
            b=8.743;

            sum = a + b;

            Console.WriteLine("1st: Sum: is {0}", sum);
            Console.WriteLine("2nd: Sum: is {0:0.##}", sum);

            Console.WriteLine($"sum is " +sum);
            Console.WriteLine($"2nd: Sum: is {sum:F2}");

            */

            #endregion

            #region: 2.10
            /*
            int a,b,sum;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;

            Console.WriteLine($"sum is " +sum);
            */
            #endregion

            #region: 2.11
            /*
            int a,b,sum;
            a = Convert.ToInt32(Console.ReadLine());
            b = Console.ReadLine(); //wrong line 

            sum = a + b;

            Console.WriteLine($"sum is " +sum);
            */
            #endregion

            #region: 2.12
            /* 
            char ch;
            Console.WriteLine("Enter the character");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"the char is : " +ch);
            */
            #endregion

            #region: 2.12
            /*
            int num1 , num2;

            Console.WriteLine("Enter the number 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = " +(num1+num2));
            Console.WriteLine($"{num1} - {num2} = " +(num1-num2));
            Console.WriteLine($"{num1} * {num2} = " +(num1*num2));
            Console.WriteLine($"{num1} / {num2} = " +(num1/num2));
            */
            #endregion


        }
    }
}
