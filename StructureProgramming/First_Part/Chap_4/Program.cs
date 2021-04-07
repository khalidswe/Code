using System;

namespace Chap_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 4.1
            /*
            for(int i=1; i<=10;i++)
            {
                Console.WriteLine(i);
            }
            */
            #endregion

            #region 4.2
            /*
            int i = 1;
            while( i<=10)
            {
                Console.WriteLine(i);
                i++;
            }
            */
            #endregion

            #region 4.4 
            /*
            int i = 1; //break system
            while( i<=100)
            {
                Console.WriteLine(i);
                i++;
               
                if (i > 50 && i <60 )
                {   
                    break;
                }
                /*if (i >= 60)     //  ex: 4.5
                {
                    continue;
                }

            }
            */
            #endregion

            #region 4.6&7
            /*
            Console.WriteLine("enter input");
            int a = Convert.ToInt32(Console.ReadLine());

            /* for(int i = 1; i <= 10; i++)
             {
                 Console.WriteLine($"{a} * {i} = " + (a * i));
             }
             */
            /* int i = 1;
           while( i <= 10)
            {
                Console.WriteLine($"{a} * {i} = " + (a * i));
                i++;
            }
            */
            #endregion

            #region 4.9
            /*
            Console.WriteLine("enter input");
            int a = Convert.ToInt32(Console.ReadLine());
            int m=0;
            
             for(int i = 1; i <= 10; i++)
             {
                m = m + a;
                Console.WriteLine($"{a} * {i} = " +m);
             }
             */

            #endregion
            #region 4.10
            /*
            int n, i;

            for(n=1;n<=10;n++)
            {
                int m = 0;
                
                for (i = 1; i <= 10; i++)   
                {
                    m = m + n;
                    Console.WriteLine($"{n} * {i} = "+m);
                  
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region 4.11
            /*
            int m ,i,j;
            Console.WriteLine("How many loop: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("enter last value: ");
                 m = Convert.ToInt32(Console.ReadLine());
                for(j = 10; j <= m; j++)
                {
                    if ( j % 11 == 0)
                    {
                        continue;
                    }
                  
                Console.WriteLine(j);
                }
            }
            */

            #endregion

            #region 4.12
            /*
            int a, b, c;

            for(a = 1; a <= 3; a++)
            {
                for (b = 1; b <= 3; b++)
                {
                    for (c = 1; c <= 3; c++)
                    {
                        Console.WriteLine($"{a} ,{b} ,{c} ");
                    }
                }
            }
            */
            #endregion

            #region 4.13
            /*
            int a, b, c;

            for(a = 1; a <= 3; a++)
            {
                for (b = 1; b <= 3 && b !=a ; b++)
                {
                    for (c = 1; c <= 3 && c !=a && c != b; c++)
                    {
                        Console.WriteLine($"{a} ,{b} ,{c} ");
                    }
                }
            }
            */
            #endregion

            #region 4.15

            int a, b, c;

            for (a = 1; a <= 3; a++)
            {
                for (b = 1; b <= 3 ; b++)
                {
                    for (c = 1; c <= 3; c++)
                    {   
                        if( b != a && c!=a && c!=b)
                        Console.WriteLine($"{a} ,{b} ,{c} ");
                    }
                }
            }

            #endregion
        }
    }
}
