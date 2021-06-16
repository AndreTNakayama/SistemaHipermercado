using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public List<Produto> listaProdutos { get; set; }

        public Produto(string nome, double valor, double peso, int quantidade, List<Produto> listaDeProdutos)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Peso = peso;
            this.Quantidade = quantidade;
            this.listaProdutos = listaDeProdutos;
        }

        /* Calcula o preço de cada produto. Se o produto não precisar da informação do Peso 
           o preço final é calculado a partir da multiplicação do Valor do produto e a Quantidade do produto
           Se o item tiver peso, não é necessário levar a quantidade em conta, e o preço final é a Valor
           do produto multiplicado pelo Peso
        */
        public double CalculaPreco()
        {
            if(Peso == -1)
            {
                return Preco = Valor * Quantidade;
            }
            else
            {
                return Preco = Valor * Peso;
            }
        }
    }
}
