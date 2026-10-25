using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3aa
{
    internal class Program
    {
        static void Main(string[] args)
        {//
            int[] num = new int[6];
            int cont, soma = 0;
            double media;
            Console.WriteLine("digite numeros inteiros e veja a media aritmetica deles");
            for (cont = 0; cont < num.Length; cont++)
            {
                num[cont] = int.Parse(Console.ReadLine());
                soma = soma + num[cont];
            }
            media = soma / 6;
            Console.WriteLine($"a média é: {media}");
            Console.ReadKey();

        }//
    }
}
