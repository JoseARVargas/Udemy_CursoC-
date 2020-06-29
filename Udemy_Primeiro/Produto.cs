using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Udemy_Primeiro
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        // Construtor Padrão
        public Produto()
        {

        }

        // Construtor com sobrecarga para inserção de todos os atributos da classe
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Construtor com sobrecarga para inserção de Nome e Preço
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        // Método que retorna o valor total de um determinado Produto em Estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Método que adiciona uma quantidade de produtos ao Estoque
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        // Método que remove uma quantidade de produtos do Estoque
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        // Método de sobrecarga do método ToString() que exibe os atributos do objeto Produto
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
