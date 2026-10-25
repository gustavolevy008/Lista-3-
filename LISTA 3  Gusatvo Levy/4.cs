using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {//
            int[] num = new int[8];
            int cont;
            int maior = int.MinValue;
            int menor = int.MaxValue;

            Console.WriteLine("digite oito numeros e veja uqal é o maior e o menor deles!!!");
            for (cont = 0; cont < num.Length; cont++)
            {
                num[cont]=int.Parse(Console.ReadLine());
           
                if (num[cont] > maior)
                {
                    maior = num[cont];
                }
                if (num[cont] < menor)
                {
                    menor = num[cont];
                }
            }
            Console.WriteLine($"\nO maior numero é: {maior}");
            Console.WriteLine($"\nO menor numero é: {menor}");
            Console.ReadKey();
        }//
    }
}
