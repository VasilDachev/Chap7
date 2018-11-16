using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сортиране на масив означава да подредим елементите му в нараст-
            ващ (намаляващ) ред. Напишете програма, която сортира масив. Да се
            използва алгоритъма "selection sort".*/
            int i;
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for ( i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int p, t;
            

            for (int j = 0; j < length - 1; j++)
            {
                p = j;
                for (i = j + 1; i < length; i++) if (arr[i] < arr[p]) p = i;
                if (p != j)
                {
                    t = arr[j];
                    arr[j] = arr[p];
                    arr[p] = t;
                }

            }
            for (i = 0; i < length; i++) Console.Write("{0}", arr[i]);
            
        }
    }
}
