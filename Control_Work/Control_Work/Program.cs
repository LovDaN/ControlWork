using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу!");
            Console.WriteLine("Укажите кол-во символов в массиве");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int[] newArray = new int[numbers];
            int[] secondArray = FillArray(newArray);
            PrintArray(secondArray);
            Console.WriteLine();
            int[] resultArray = SortArray(secondArray);
            PrintArray(resultArray);

        }
        static int[] FillArray(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10000);
            }
            return arr;
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (i == 0) Console.Write("[");
                if (i == arr.Length - 1) Console.Write("]");
                if (arr[i] == 0) continue;
                Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(" ");
                
            }
        }
        static int[] SortArray(int[] arr)
        {
            
            int[] resultArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]/1000 == 0)
                {
                    
                    resultArray[i] = arr[i];
                    
                }
                
            }
            return resultArray;
        }
    }
}
