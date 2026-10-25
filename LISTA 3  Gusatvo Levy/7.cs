using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {//
            int[] num = new int[10];
            int num2, cont;
            for (cont = 0; cont < num.Length; cont++)
                num[cont] = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um numero");
            num2 = int.Parse(Console.ReadLine());
            for (cont = 0; cont < num.Length; cont++)
                if (num2 == num[cont])
                {
                    Console.WriteLine($"o {num2} está no vetor, posição: {cont + 1}");
                }
            Console.ReadKey();
        }
    }
}
