using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvGitLabApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Функция F(x) = 5 * Cos(2*x)");
            Console.Write("Введите x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double F; 
            F = 5 * Math.Cos(2 * x); // Функция F(x)
            Console.WriteLine("Функция F({0:0.##}) = {1:0.####}", x, F);
            Console.ReadLine();
        }
    }
}
