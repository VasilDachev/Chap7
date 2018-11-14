using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се напише програма, която чете два масива от конзолата и прове-
            рява дали са еднакви (два масива са еднакви, когато имат еднаква
            дължина и елементите им, записани под едни и същи индекси, са
            еднакви).*/
            bool arraysEqual = true;

            Console.Write("Enter lenght of first array: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr1 = new int[length];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter lenght of second array: ");

            if (length != int.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
            else
            {
                int[] arr2 = new int[length];

                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    arr2[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine("\nArrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("\nArrays are the same.");
            }
        }
    }
}
