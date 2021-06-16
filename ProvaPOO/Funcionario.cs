using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProvaPOO
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public Funcionario(string Nome, string tipo)
        {
            this.Nome = Nome;
            this.Tipo = tipo;
        }

        public abstract void AdicionaProduto(string nome, double preco, double peso, int quantidade, List<Produto> listaDeProdutos);

        //Calcula o preço final a se pagar pelos produtos
        public double FinalizarCompra(List<Produto> listaDeProdutos)
        {
            double ValorTotal = 0;

            if (listaDeProdutos.Count > 0)
            {
                for (int i = 0; i < listaDeProdutos.Count; i++)
                {
                    ValorTotal += listaDeProdutos[i].CalculaPreco();
                }
                return ValorTotal;
            }
            else
            {
                return -1;
            }
        }
        
        //Retorna um texto e a forma de pagamento para o formulario
        public string RecebePagamento(string formaPagamento)
        {
            return "\nPagamento feito por: " + formaPagamento + "\n";
        }

    }
}
