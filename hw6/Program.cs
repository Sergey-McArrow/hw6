using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i < num2; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
            }


            Console.WriteLine("Task 11");
            ulong first = 1;
            ulong second = 1;

            int counter100 = 100;
            Console.WriteLine(first);
            Console.WriteLine(second);
            while (counter100 > 0)
            {
                ulong fibo = first + second;
                counter100--;
                Console.WriteLine(fibo);
                first = second;
                second = fibo;
            }
        }
    }
}
