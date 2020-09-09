using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika_Dif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа g p a b:");
            int g = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double A = Math.Pow(g, a) % p;
            Console.WriteLine("Значение A:" + A.ToString());
            double B = Math.Pow(g, b) % p;
            Console.WriteLine("Значение B:" + B.ToString());
            double Ka = Math.Pow(B, a) % p;
            Console.WriteLine("Значение ключа Ka:" + Ka.ToString());
            double Kb = Math.Pow(A, b) % p;
            Console.WriteLine("Значение ключа Kb:" + Kb.ToString());
            double K = Math.Pow(g, a * b) % p;
            Console.WriteLine("Искомый ключ K:" + K.ToString());
            Console.ReadKey();
        }
    }
}
