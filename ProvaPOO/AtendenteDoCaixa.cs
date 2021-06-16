using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    class AtendenteDoCaixa : Funcionario
    {
        public AtendenteDoCaixa(string nome) : base(nome, "Caixa")
        {

        }

        //Caixa adiciona produto. Função que adiciona um produto na listaDeProdutos
        public override void AdicionaProduto(string nome, double preco, double peso, int quantidade, List<Produto> listaDeProdutos)
        {
            listaDeProdutos.Add(new Produto(nome, preco, peso, quantidade, listaDeProdutos));
        }
    }
}
