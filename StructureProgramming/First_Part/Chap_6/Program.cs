using System;

namespace Chap_6
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 6.1
            /*
            double ft_marks, st_marks, fint_marks, total_marks;

            Console.Write("enter first term marks: ");
            ft_marks = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter second term marks: ");
            st_marks = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter final term marks: ");
            fint_marks = Convert.ToDouble(Console.ReadLine());

            total_marks = (ft_marks / 4.00) + (st_marks / 4.00) + (fint_marks / 2.00);

            Console.WriteLine($"total marks {total_marks:F2}");
            */
            #endregion

            #region 6.2/3/4
            /*
            int [] my_array = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            Console.WriteLine(my_array[1]);
            Console.WriteLine(my_array[9]);
            Console.WriteLine(my_array[10]); //index 10 not found 
            */

            #endregion

            #region 6.5
            /*
            int[] my_array = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            my_array[2] = 100;
            my_array[9] = 1;
            Console.WriteLine(my_array[1]);
            Console.WriteLine(my_array[2]);
            Console.WriteLine(my_array[9]);
         
            */
            #endregion

            #region 6.7
            /*
            int[] my_array = new int[5] { 5, 10, 15, 20, 25 };

           
            // Console.WriteLine(my_array[-1]);  index not found so never run
            Console.WriteLine(my_array[4]);
            */
            #endregion

            #region 6.8
            /*
            int[] my_array = new int[5] { 5, 10, 15, 20, 25 };

           for (int i = 0; i < my_array.Length; i++) // index first to last
            {
                Console.WriteLine(my_array[i]);
            }
           */
            #endregion

            #region 6.8 extra
            /*
            int[] my_array = new int[5] { 5, 10, 15, 20, 25 };

           for (int i = 4; i >= 0; i--) // index last to first
            {
                Console.WriteLine(my_array[i]);
            }
           */
            #endregion

            #region 6.9
            /*
            int[] array1 = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] array2 = new int[10];
            int i, j;

            for (i = 0, j = 9; i < array1.Length; i++, j--)
            {
                array2[j] = array1[i];
            }

            for (i = 0; i < array1.Length; i++)
            {
                array1[i] = array2[i];
            }

            for (i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{array2[i]}");
            }
            */
            #endregion

            #region 6.10
            /*
            int[] array1 = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int i, j,temp;

            for (i = 0, j = 9; i <= 4; i++, j--)
            {
                temp = array1[j];
                array1[j] = array1[i];
                array1[i] = temp;
                
            }

            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine($"{array1[i]}");
            }
            */
            #endregion

            #region 6.11/6.12
            
            int[] ft_marks = new int[40] { 83, 86, 97, 95, 93, 95, 86, 52, 49, 41, 42, 47, 90, 59, 63, 86, 40, 46, 92, 56, 51, 48, 67, 49, 42, 90, 42, 83, 47, 95, 69, 82, 82, 58, 69, 67, 53, 56, 71, 62 };
            int[] st_marks = new int[40] { 86, 97, 95, 93, 95, 86, 52, 49, 41, 42, 47, 90, 59, 63, 86, 40, 46, 92, 56, 51, 48, 67, 49, 42, 90, 42, 83, 47, 95, 69, 82, 82, 58, 69, 67, 53, 56, 71, 62, 49 };
            int[] final_marks = new int[40] { 87, 64, 91, 43, 89, 66, 58, 73, 99, 81, 100, 64, 55, 69, 85, 81, 80, 67, 88, 71, 62, 78, 58, 66, 98, 75, 86, 90, 80, 58, 100, 64, 55, 69, 85, 81, 80, 67, 88, 71 };

            int i;
            double[] total_marks= new double[40];
            for (i = 0; i < 40; i++)
            {
                total_marks[i]= (ft_marks[i]/4.00)+ (st_marks[i] / 4.00) + (final_marks[i] / 2.00);
            }
            for (i = 0; i < 40; i++)
            {
                Console.WriteLine($"Roll number {i+1} is {total_marks[i]:F2}");
            }
            int count = 0;
            for (i = 0; i < 40; i++)
            {
                
                if (total_marks[i] >= 50 && total_marks[i] <=60)
                {
                    count++;
                }
                
            }
            Console.WriteLine("\ntotal student 50 to 60 number : " + count);
            #endregion



        }
    }
}
