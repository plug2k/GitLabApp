using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLabApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной X:");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = (Math.Sin(x) + Math.Cos(x)) / 2;
            Console.WriteLine($"Значение F = {F} при X = {x}. ");
            Console.ReadKey();
        }
    }
}
