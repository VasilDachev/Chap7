using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която намира максимална редица от последо-
            вателни еднакви елементи в масив. Пример: {2, 1, 1, 2, 3, 3, 2, 2,
            2, 1} → {2, 2, 2}.*/
            int br = 1, count = 1, number = 0;

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
                if (arr[i] == arr[i + 1]) count++;
                else count = 1;

                if (count > br)
                {
                    br = count;
                    number = arr[i];
                }
            }

            for (int i = 0; i < br; i++) Console.Write("{0}, ", number);
        }
    }
}
