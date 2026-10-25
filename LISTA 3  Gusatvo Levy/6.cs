using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {//
            int[] num = new int[5];
            int cont;
            Console.WriteLine("digite cindo numeros intiros");
            for(cont= 0;cont<num.Length;cont++)
            {
                num[cont] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("numeros digitados na order reversa");
            for (cont = 4; cont >= 0; cont--)
            { 
                Console.WriteLine(num[cont]);
            }
            Console.ReadKey();
        }//
    }
}
