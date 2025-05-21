using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Номинал купюры = ");
            int nom = int.Parse(Console.ReadLine());
            Console.Write("Количество купюр = ");
            int value = int.Parse(Console.ReadLine());
            float sum = nom * value;
            Console.WriteLine($"Сумма денег={sum:F2}");
            Console.Read();
        }
    }
}
