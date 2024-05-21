using System;
using System.Globalization;

namespace area {
    internal class Program {
        static void Main(string[] args) {

            double b1, b2, h, area;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;
            area = (b1 + b2) / 2.0 * h;
            Console.WriteLine(area);

        }
    }
}
