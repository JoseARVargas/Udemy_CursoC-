using System;
using System.Globalization;

namespace Udemy_Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Triangulo

            //Console.WriteLine("Entre com as medidas do triângulo x:"); 
            //Triangulo x = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triângulo y:");
            //Triangulo y = new Triangulo();            

            //double xArea = x.Area();            
            //Console.WriteLine("Área x: " + xArea);

            //double yArea = y.Area();
            //Console.WriteLine("Área y: " + yArea);

            //if (xArea > yArea)
            //{
            //    Console.WriteLine("O maior triângulo é: X");
            //}
            //else
            //{
            //    Console.WriteLine("O maior triângulo é: Y");
            //}

            #endregion

            #region Produto

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos adicionados ao Estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o número de produtos a ser removido do Estoque:");
            int qteRemover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qteRemover);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p);

            #endregion
        }


    }
}