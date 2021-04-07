using System;

namespace Chap_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3.4
            /*
            int n ;
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("n is negative");
            }
            else if (n>0)
                {
                Console.WriteLine("n is positive");
            }
            else
                Console.WriteLine("n is zero");
            */
            #endregion

            #region 3.8/9
            /*
            int n ;
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("n is even");
            }
            else
                Console.WriteLine("n is odd");
            */
            #endregion

            #region 3.10
            /*
             char n ;
            n = Convert.ToChar(Console.ReadLine());
            if (n >= 'a' && n <= 'z')
            {
                Console.WriteLine("this word is lower case");
            }
            if (n >= 'A' && n <= 'Z')
            {
                Console.WriteLine("this word is UPPER case");
            }
            */
            #endregion

            #region 3.12
            /*
             
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 && n <= 100)
            {
                Console.WriteLine("this input is in 1 to 100");
            }
            else
            {
                Console.WriteLine("this input is out of 1 to 100");
            }
            */
            #endregion

            #region 3.13
            /*
            
            char n = Convert.ToChar(Console.ReadLine()); // upper case and lower case two types 
            if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u' || n == 'A' || n == 'E' || n == 'I' || n == 'O' || n == 'U')
            {
                Console.WriteLine("this input is vowel");
            }
            else
            {
                Console.WriteLine("this input is consonant");
            }
            */
            #endregion


        }
    }
}
