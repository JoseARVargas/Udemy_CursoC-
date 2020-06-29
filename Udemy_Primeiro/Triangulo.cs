using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Udemy_Primeiro
{
    class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangulo()
        {
            this.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            this.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            this.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public double Area()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
