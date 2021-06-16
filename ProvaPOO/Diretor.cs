using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    class Diretor : Funcionario, IAcessoIrrestrito
    {
        public Diretor(string nome) : base(nome, "Diretor")
        {

        }

        //Diretor adiciona produto. Função que adiciona um produto na listaDeProdutos
        public override void AdicionaProduto(string nome, double preco, double peso, int quantidade, List<Produto> listaDeProdutos)
        {
            listaDeProdutos.Add(new Produto(nome, preco, peso, quantidade, listaDeProdutos));
        }

        //Diretor Remove um produto. No form se a quantidade for 0 retira da Lista e da ComboBox
        public void RemoverProduto(List<Produto> listaDeProdutos, int posicao)
        {
            listaDeProdutos[posicao].Quantidade -= 1;
        }
    }
}
