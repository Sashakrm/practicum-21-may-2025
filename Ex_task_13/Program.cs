using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int input = int.Parse(Console.ReadLine());
            int dublicat = input;
            int total_input = input / 10; //получаем десятки
            int total_dublicat = dublicat % 10;//получаем единицы
            Console.WriteLine($"{total_input} {total_dublicat}");
            Console.Read();
        }
    }
}
