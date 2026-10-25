using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {//
            int[] nota = new int[5];
            int cont, aprovados = 0, media = 0;
            Console.WriteLine("digite a nota dos alunos");
            for (cont = 0; cont < nota.Length; cont++)
            {
                Console.Write($"nota do {cont + 1}° aluno: ");
                nota[cont] = int.Parse(Console.ReadLine());
                media = media + nota[cont];
                if (nota[cont] >= 6)
                {
                    aprovados++;
                }
            }
            Console.Clear();
            for (cont = 0; cont < nota.Length; cont++)
            {
                Console.WriteLine($"nota do {cont+1}° aluno: {nota[cont]}");
            }
            Console.Write($"\nmedia da turma: {media / 5}");
            Console.Write($"\no número de alunos aprovados é de: {aprovados}");
            Console.ReadKey();
            
        }
    }
}
