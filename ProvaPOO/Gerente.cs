using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    class Gerente : Funcionario, IAcessoIrrestrito
    {
        public Gerente(string nome) : base(nome, "Gerente")
        {

        }

        //Gerente adiciona produto. Função que adiciona um produto na listaDeProdutos
        public override void AdicionaProduto(string nome, double preco, double peso, int quantidade, List<Produto> listaDeProdutos)
        {
            listaDeProdutos.Add(new Produto(nome, preco, peso, quantidade, listaDeProdutos));
        }

        //Gerente Remove um produto. No form se a quantidade for 0 retira da Lista e da ComboBox
        public void RemoverProduto(List<Produto> listaDeProdutos, int posicao)
        {
            listaDeProdutos[posicao].Quantidade -= 1;
        }
    }
}
