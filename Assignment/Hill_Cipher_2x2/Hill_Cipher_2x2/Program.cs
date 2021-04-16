using System;
using System.Linq;
using System.Collections.Generic;

namespace Hill_Cipher_2x2
{
    public class EncriptionKey
    {
        public int[,] arr = new int[2, 2];
    } // go to line 102

    class Program
    {
        static string Encryption(string txt, EncriptionKey var)
        {
            string CipherText = null;

            List<int> value = new List<int>(); // get a list for value

            for (int i = 0; i < txt.Length; i++)  // adding value into this list
            {
                int val = (int)txt[i] - 65; 
                value.Add(val);
            }

            //int[] textValue = new int[value.Count()];

            for (int i = 0; i < value.Count(); i += 2)
            {
                int a = var.arr[0, 0] * value[i];
                int b = var.arr[0, 1] * value[i + 1];
                int c = var.arr[1, 0] * value[i];
                int d = var.arr[1, 1] * value[i + 1];
                int val1 = (a + b) % 26;
                int val2 = (c + d) % 26;
                char c1 = (char)(65 + val1);
                char c2 = (char)(65 + val2);
                CipherText += c1;
                CipherText += c2;
            }

            return CipherText; // go to line no 113
        }

        static void Swap(ref int num1, ref int num2) // swap function
        {
            int newnum;
            newnum = num1;
            num1 = num2;
            num2 = newnum; // back to line no 63
        }
        static EncriptionKey Decryption(EncriptionKey keys)
        {
            int determinent = (keys.arr[0, 0] * keys.arr[1, 1]) - (keys.arr[0, 1] * keys.arr[1, 0]);

            if (determinent < 0) determinent += 26;

            EncriptionKey decrypt = new EncriptionKey();
            decrypt = keys;

            Swap(ref decrypt.arr[0, 0], ref decrypt.arr[1, 1]); // invertion KE Matrix go to line no 45

            decrypt.arr[0, 1] = (decrypt.arr[0, 1] * -1) % 26;
            decrypt.arr[1, 0] = (decrypt.arr[1, 0] * -1) % 26;

            if (decrypt.arr[0, 1] < 0) decrypt.arr[0, 1] += 26;
            if (decrypt.arr[1, 0] < 0) decrypt.arr[1, 0] += 26;

            int x = 0;

            for (int i = 1; i < 26; i++)
            {
                if (Convert.ToBoolean((determinent * i) % 26 == 1))
                {
                    x = i;
                    break;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    decrypt.arr[i, j] *= x;
                    decrypt.arr[i, j] %= 26;

                    if (decrypt.arr[i, j] < 0)
                        decrypt.arr[i, j] += 26;
                }
            }

            return decrypt;  // go to line no 120
        }


        static void Main(string[] args)
        {
            Console.Write("Enter Your text : ");  // start
            var plainText = Console.ReadLine().ToUpper();

            EncriptionKey key = new EncriptionKey(); // go to line no 7
            Console.WriteLine("Enter Your key : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    key.arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            string cipherText = Encryption(plainText, key); // go to encryption method 14 no line

            Console.WriteLine($"Cipher Text : {cipherText}");
            Console.ReadKey();

            EncriptionKey decryptKey = new EncriptionKey();
            decryptKey = Decryption(key); 

            string decryptText = Encryption(cipherText, decryptKey); // go to deycryption method line no 52
            Console.WriteLine($"\nDecrypt Text : {decryptText}"); 
            Console.ReadKey();
        }
    }
}