using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се напише програма, която създава масив с 20 елемента от цело-
            числен тип и инициализира всеки от елементите със стойност, равна
            на индекса на елемента умножен по 5. Елементите на масива да се
            изведат на конзолата.*/
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }
}
