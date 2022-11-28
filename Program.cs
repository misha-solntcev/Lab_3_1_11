using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 11. Дано целое число N (> 1). Вывести наименьшее из целых чисел K, 
    для которых сумма 1 + 2 + … + K будет больше или равна N, 
    и саму эту сумму. */

namespace Lab_3_1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 105;
            int sum = 0;
            int K = 0;
            while(sum < N)
            {
                K++;
                sum += K;                
                Console.WriteLine($"K = {K}, sum = {sum} ");
            }
            Console.ReadKey();
        }
    }
}
