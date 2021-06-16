using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    interface IAcessoIrrestrito
    {
        public abstract void RemoverProduto(List<Produto> listaDeProdutos, int posicao);
    }
}
