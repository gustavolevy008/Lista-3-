using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {//
            int[] num = new int[6];
            int[] dobro = new int[6];
            int cont;
            Console.WriteLine("digite cinco numeros inteiros");
            for (cont = 0; cont < num.Length; cont++)
            {
                num[cont] = int.Parse(Console.ReadLine());
                dobro[cont] = num[cont] * 2;
            }
            Console.Clear();
            Console.WriteLine($"\nnumeros digitados:");
            for (cont = 0; cont < num.Length; cont++)
            {
                Console.WriteLine(num[cont]);
            }
            Console.WriteLine($"\no dobro dos numeros digitados:");
            for (cont = 0; cont < num.Length; cont++)
            {
                Console.WriteLine(dobro[cont]);
            }
            Console.ReadKey();



        }//
    }
}
