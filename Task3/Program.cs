using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Да се напише програма, която сравнява два масива от тип char лек-
             сикографски(буква по буква) и проверява кой от двата е по - рано в
             лексикографската подредба.*/
            bool arrayEqual = true;
            char[] arr1 = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] arr2 = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            if (arr1.Length > arr2.Length) Console.WriteLine("Second array is lexicographicaly first.");
            else if (arr1.Length < arr2.Length) Console.WriteLine("First array is lexicographicaly first.");
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                    if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                }

                if (arrayEqual) Console.WriteLine("Arrays are lexicographicaly equal.");
            }
        }
    }
}
