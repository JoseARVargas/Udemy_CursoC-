using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cap5Udemy_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados de cadastro da conta:");

            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Depósito: ");
            double depInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            ContaBacaria conta = new ContaBacaria(numero, nome, depInicial);

            
        }
    }
}
