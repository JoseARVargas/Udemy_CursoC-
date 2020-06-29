using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cap5Udemy_Banco
{
    public class ContaBacaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBacaria(int numero, string nome)
        {
            Numero = numero;
            Titular = nome;
        }

        public ContaBacaria(int numero, string nome, double depInicial) : this(numero,nome) {
            Deposito(depInicial);
        }

        public void Deposito(double valorDeposito)
        {
            if(valorDeposito > 0)
            {
                this.Saldo += valorDeposito;
            }
            else
            {
                Console.WriteLine("Valor inválido para depósito, favor entrar com um valor válido");
            }
        }

        public void Saque (double valorSaque)
        {
            if (valorSaque > 0)
            {
                this.Saldo -= (valorSaque + 5.00);
            }
            else
            {
                Console.WriteLine("Valor inválido para saque, favor entrar com um valor válido");
            }
        }

        public override string ToString()
        {
            return "Conta"
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
