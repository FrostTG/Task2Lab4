using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, sum = 0, sum2 = 0;
            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    sum++;
                }
                else
                {
                    if (N < 0)
                    {
                        sum2++;
                    }
                }
            } while (N != 0);
            if (sum > sum2) //А можно ли этот оператор заменить тернарным?
            {
                Console.WriteLine("Положительных чисел больше");
            }
            else
            {
                if (sum < sum2)
                {
                    Console.WriteLine("Отрицательных чисел больше");
                }
                else
                {

                }

            Console.ReadKey();
            }
        }
    }
}
