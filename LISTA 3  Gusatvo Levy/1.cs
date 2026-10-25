using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {//
            int[]num = new int[5];
            int cont;
            Console.WriteLine("digite cinco numeros inteiros");
            for (cont = 0; cont < num.Length; cont++)
            {
                num[cont] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (cont = 0; cont < num.Length; cont++)
            {
                Console.WriteLine($"{cont+1}° numero: {num[cont]}");
            }
            Console.ReadKey();

        }//
    }
}
