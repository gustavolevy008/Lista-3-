using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {//
            int[] num = new int[10];
            int cont, par = 0;
            Console.WriteLine("digite dez numeros e veja quantos são pares");
            for ( cont = 0; cont < num.Length; cont++ )
            {
                num[cont]=int.Parse(Console.ReadLine());
                if (num[cont]%2==0)
                    par++;
            }
            Console.WriteLine($"a quantidade de numeros pares é: {par}");
            Console.ReadKey();

        }//
    }
}
