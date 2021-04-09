using System;

namespace Chap_8
{
    class Program
    {
        #region 8.1 ex
        static void binarySearch(int[] arr,int low_index,int high_index)
        {
            int mid_index, num;

            Console.WriteLine("enter the searching value : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (low_index <= high_index)
            {
                mid_index = (low_index + high_index) / 2;

                if (num == arr[mid_index])
                {
                    Console.WriteLine($"yes, we got it bro!! in index {mid_index}");
                    break;
                }

                if (num < arr[mid_index])
                {
                    high_index = mid_index - 1;
                }

                else
                {
                    low_index = mid_index + 1;
                }
            }
            if (low_index > high_index)
            {
                Console.WriteLine($"No, we didn't get it bro!!");
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region 8.1
            /*
            int[] arr = { 1, 4, 6, 8, 9, 11, 14, 15, 20, 25, 33, 83, 87, 97, 99, 100 };

            int low_index = 0;
            int high_index = 15;
            int mid_index , num;

            Console.WriteLine("enter the searching value : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (low_index <= high_index)
            {
                mid_index = (low_index + high_index)/ 2;

                if ( num == arr[mid_index])
                {
                    Console.WriteLine($"yes, we got it bro!! in index {mid_index}");
                    break;
                }

                if (num < arr[mid_index])
                {
                    high_index = mid_index - 1;
                }

                else
                {
                    low_index = mid_index + 1;
                }
            }
            if (low_index > high_index)
            {
                Console.WriteLine($"No, we didn't get it bro!!");
            }
            */
            #endregion

            #region 8.1 ex

            int[] arr = { 1, 4, 6, 8, 9, 11, 14, 15, 20, 25, 33, 83, 87, 97, 99, 100 };

            int low_index = 0;
            int high_index = 15;
            

            binarySearch(arr,low_index,high_index);
            
            #endregion
        }
    }
}
