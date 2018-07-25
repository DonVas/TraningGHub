using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TraningGHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array number of elements: ");
            char[] arr = new char[int.Parse(Console.ReadLine())];
            Arrayin(arr, arr.Length);
            string arrays = "";
            foreach (char item in arr)
            {
                arrays += item;
            }
            Console.WriteLine($@"{arrays}");
            Arrayout(arr, arr.Length);
            Console.WriteLine("Number of elements for 2 dimension array: ");
            char[,] arr2 = new char[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
            Arr2dimensionIN(arr2);
            Arr2dimensionOut(arr2);

        }

        private static void Arr2dimensionIN(char[,] arr2)
        {
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = (char)(i + j);
                }
            }
        }

        private static void Arr2dimensionOut(char[,] arr2)
        {
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine(arr2[i, j]);
                }
            }
        }
        private static void Arrayin(char[] arr, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                arr[i] = Convert.ToChar(i);
            }
        }
        private static void Arrayout(char[] arr, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
