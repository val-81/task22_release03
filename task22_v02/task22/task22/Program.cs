using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task22
{
    class Program
    {
        static void ArrayUser(int x)
        {
            int[] array = new int[x];
            int Summ = 0;
            int Max = 0;

            Random random = new Random();

            for (int i = 0; i < x; i++)
            {
                array[i] = random.Next(0, x);
                Summ += array[i];
                if (Max < array[i]) 
                { 
                    Max = array[i]; 
                }
            }
            Console.WriteLine($"Максимальный элемент массива и его значение:  {Max}");
            Console.WriteLine($"Сумма массива = {Summ}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите размер массива");
            int x = Convert.ToInt32(Console.ReadLine());
            ArrayUser(x);
            Console.ReadKey();
        }
    }
}
