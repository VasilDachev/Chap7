using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която намира максималната редица от после-
            дователни нарастващи елементи в масив. Пример: {3, 2, 3, 4, 2,
            2, 4} → {2, 3, 4}.*/
            int same = 1, same1 = 1, start = 0, last = 0;

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] +1 == arr[i + 1])
                {
                    same++;
                    if (same > same1)
                        last = i + 1;
                    start = last - same1 + 1;
                }
                else same = 1;

                
            }

            for (int i = 0; i < same1+start; i++) Console.Write("{0}, ", arr[i]);

          
        }
    }
}
