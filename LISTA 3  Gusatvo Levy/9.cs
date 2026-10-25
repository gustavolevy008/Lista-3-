using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {//
            int[] num = new int[5];
            int[] num2 = new int[5];
            int[] soma = new int[5];
            int cont;
            Console.WriteLine("primeira lista");
            for (cont = 0; cont < num.Length; cont++)
            {
                num[cont]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("segunda lista");
            for (cont = 0; cont < num.Length; cont++)
            {
                num2[cont] = int.Parse(Console.ReadLine());
                soma[cont] = num[cont] + num2[cont];
            }
            Console.WriteLine("\nsoma das listas");
            for (cont = 0; cont < num.Length; cont++)
            {
                Console.WriteLine($"soma da {cont+1}° casa de cada lista: {soma[cont]}");
            }
        }//
    }
}
