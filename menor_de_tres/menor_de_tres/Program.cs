using System;
using System.Globalization;

namespace menor_de_tres {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int a, b, c, menor;

            Console.Write("Primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c) {
                menor = a;
            }
            else if (b < c) {
                menor = b;
            }
            else {
                menor = c;
            }
            Console.WriteLine("Menor = " + menor);
        }
    }
}
