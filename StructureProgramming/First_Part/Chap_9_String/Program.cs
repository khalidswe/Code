using System;

namespace Chap_9_String
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 9.1
            /*
            char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h',' ','i','s' };

            Console.WriteLine(country);
           
            */
            #endregion

            #region 9.4 upper case
            /*
            char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h', ' ', 'i', 's' };
            int i;

            for (i = 0; i < country.Length; i++)
            {   if (country[i] >= 'a' && country[i] <= 'z')
                {
                    country[i] = (char) ('A' + (country[i] - 'a'));
                }
                
            }
            Console.WriteLine(country);
            */
            #endregion

            #region 9.4 lower case
            /*
            char[] country = { 'B', 'a', 'n', 'g', 'L', 'a', 'd', 'e', 's', 'h', ' ', 'i', 'S' };
            int i;

            for (i = 0; i < country.Length; i++)
            {
                if (country[i] >= 'A' && country[i] <= 'Z')
                {
                    country[i] = (char)('a' + (country[i] - 'A'));
                }

            }
            Console.WriteLine(country);
            */
            #endregion

            #region

           int[] country = new int[100];
            int i;
            while(1 == true)
            {

            }
           
            Console.WriteLine(country.Length);

            #endregion
        }
    }
}
