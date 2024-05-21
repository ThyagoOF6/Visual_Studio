using System;
using System.Net.Http.Headers;

namespace idades {
    internal class Program {
        static void Main(string[] args) {
            
            String nome1, nome2;
            int idade1, idade2;
            double media;

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            media = (double) (idade1 + idade2) / 2.0;
            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " eh de " + media + "anos");

        }
    }
}
