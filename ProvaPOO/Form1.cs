using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaPOO
{
    public partial class frmHipermercado : Form
    {
        List<Produto> listaDeProdutos = new List<Produto>();
        List<Funcionario> listaDeFuncionario = new List<Funcionario>();

        Funcionario Funcionario;

        double ValorTotal = 0;
        int contadorItems = 0;

        public frmHipermercado()
        {
            InitializeComponent();

            //Cria os funcionparios
            listaDeFuncionario.Add(new AtendenteDoCaixa("Eduardo"));
            listaDeFuncionario.Add(new Diretor("Sandra"));
            listaDeFuncionario.Add(new Gerente("Felipe"));

            //Adiciona o Nome (Tipo) do funcionario na ComboBox
            for(int i = 0; i < listaDeFuncionario.Count; i++)
            {
                Funcionario = listaDeFuncionario[i];
                cbxUsuario.Items.Add(listaDeFuncionario[i].Nome + " (" + this.Funcionario.Tipo + ")");
            }

            //Por padrão do sistema inicia a ComboBox com o primeiro funcionário (Caixa)
            cbxUsuario.SelectedIndex = 0;

            //Como o funcionario é o caixa todo que envolve a ação de remover produto está desabilitada e verificar lucro também
            cbxRemover.Visible = false;
            btnRemover.Visible = false;
            groupBoxRemover.Visible = false;
            btnVerificarLucro.Enabled = false;

            //A variável funcionario recebe o primeiro funcionario (Caixa)
            Funcionario = listaDeFuncionario[0];

            //Por padrão do sistema inicia a ComboBox de Pagamento com a primeira opção (Cartão)
            cbxPagamento.SelectedIndex = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Inicia o contador com o valor inicial da lista de Produtos e adiciona +1
            contadorItems = listaDeProdutos.Count + 1;

            try
            {
                //Pega os valores das TextBox para Nome, Preço, Peso e Quantidade
                string nome = txtProduto.Text;
                double preco = Convert.ToDouble(txtPreco.Text);
                double peso = 0;
                int quantidade = 0;

                //Se a quantidade estiver vazia ou o CheckBox de Quilo estiver marcada o item não é um produto de quantidade
                if (txtQuantidade.Text == "" || chkQuilo.Checked)
                {
                    quantidade = 1;
                }
                else
                {
                    quantidade = Convert.ToInt32(txtQuantidade.Text);
                }

                //Se o peso estiver vazio é pq precisa especificar a quantidade de produtos
                if (txtPeso.Text == "")
                {
                    peso = -1;
                }
                else
                {
                    peso = Convert.ToDouble(txtPeso.Text);
                }

                //If para verificar qual funcionario adicionará o produto. OBS: Todos os usuarios podem adicionar um produto
                if (typeof(Diretor) == this.Funcionario.GetType())
                {
                    Funcionario.AdicionaProduto(nome, preco, peso, quantidade, listaDeProdutos);
                }
                else if (typeof(Gerente) == this.Funcionario.GetType())
                {
                    Funcionario.AdicionaProduto(nome, preco, peso, quantidade, listaDeProdutos);
                }
                else if (typeof(AtendenteDoCaixa) == this.Funcionario.GetType())
                {
                    Funcionario.AdicionaProduto(nome, preco, peso, quantidade, listaDeProdutos);
                }

                //If para colocar as informações na Nota
                if (txtPeso.Text == "")
                {
                    lblNotinha.Text += "\n" + txtProduto.Text + " " + quantidade + "un R$: " + txtPreco.Text;
                }
                else
                {
                    lblNotinha.Text += "\n" + txtProduto.Text + " " + txtPreco.Text + " " + txtPeso.Text + "/kg" + " R$: " + (Convert.ToDouble(txtPreco.Text) * peso);
                }

                //For utilizado para colocar os itens dentro da ComboBox
                for (int i = 0; i < quantidade; i++)
                {
                    if (txtPeso.Text == "")
                    {
                        cbxRemover.Items.Add(contadorItems + " . " + txtProduto.Text + " un R$:" + txtPreco.Text);
                    }
                    else
                    {
                        cbxRemover.Items.Add(contadorItems + " . " + txtProduto.Text + "R$: " + txtPreco.Text + " | " + txtPeso.Text);
                    }
                }

                //Após adicionar o produto limpa os campos de Produto, Preço, Peso e Quantidade e Adiciona +1 no contador de itens
                contadorItems++;
                txtProduto.Text = "";
                txtPreco.Text = "";
                txtPeso.Text = "";
                txtQuantidade.Text = "";

                //Botão finalizar fica disponivel após adicionar um item
                btnFinalizar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Insira os valores corretamente!");
            }  
        }

        public void AtualizaLista()
        {
            contadorItems = 0;

            /* ---------------------------------------------------------
            For utilizado para atualizar a lista após um item ser removido,
            Por exemplo: Temos os itens 1, 2 e 3 (todos eles são diferentes).
            Após a remoção do 2 o item 3 passa a ser o item de número 2 
            --------------------------------------------------------- */

            for (int i=0; i<listaDeProdutos.Count; i++)
            {
                contadorItems++;
                for(int j=0; j<listaDeProdutos[i].Quantidade; j++)
                {
                    if (listaDeProdutos[i].Peso == -1)
                    {
                        cbxRemover.Items.Add(contadorItems + " . " + listaDeProdutos[i].Nome + " un R$:" + listaDeProdutos[i].Valor);
                    }
                    else
                    {
                        cbxRemover.Items.Add(contadorItems + " . " + listaDeProdutos[i].Nome+ "R$: " + listaDeProdutos[i].Valor + " | " + listaDeProdutos[i].Peso);
                    }
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            /* Chama a função FinalizarCompra e guarda na variavel global ValorTotal
               A função FinalizarCompra é uma função dos Funcionarios onde calcula o valor total da compra */
            ValorTotal = Funcionario.FinalizarCompra(listaDeProdutos);

            //Se o retorno for -1 é porque a lista de itens está vazia e nao tem nada para calcular
            if(ValorTotal != -1)
            {
                //Se o retorno nao for -1 é porque o retorno é o preço final
                btnAdicionar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnPagamento.Enabled = true;

                //Coloca na Nota o preço e o funcionario que atendeu
                lblNotinha.Text += "\n -------------------------------------- \n";
                lblNotinha.Text += "Total: " + ValorTotal.ToString("C");
                lblNotinha.Text += "\nAtendido por: " + Funcionario.Nome + "(" + this.Funcionario.Tipo + ")";
            }
            else
            {
                MessageBox.Show("Lista Vazia"); 
                btnFinalizar.Enabled = false;
            }

            //Após finalizar a compra, limpa a lista de compras e a ComboBox de remover produtos;
            listaDeProdutos.Clear();
            cbxRemover.Items.Clear();
            cbxRemover.SelectedItem = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                //Se o usuario nao selecionar um item da ComboBox escolhe o primeiro
                if(cbxRemover.SelectedItem == null)
                {
                    cbxRemover.SelectedIndex = 0;
                }

                string retorno = cbxRemover.SelectedItem.ToString();
                //Pega os dois primeiros valores, subtrai 1 para utilizar como variavel
                int variavel = Convert.ToInt32(retorno.Substring(0, 2)) - 1;

                //Se a quantidade do produto for maior que 0, por exemplo na lista tem 3 Refrigerantes
                if (listaDeProdutos[variavel].Quantidade > 0)
                {
                    //Verifica qual funcionario vai remover (DIRETOR ou GERENTE)
                    if (typeof(Diretor) == this.Funcionario.GetType())
                    {
                        Diretor Diretor = (Diretor)Funcionario;
                        Diretor.RemoverProduto(listaDeProdutos, variavel);
                    }
                    else if (typeof(Gerente) == this.Funcionario.GetType())
                    {
                        Gerente Gerente = (Gerente)Funcionario;
                        Gerente.RemoverProduto(listaDeProdutos, variavel);
                    }

                    lblNotinha.Text += "\n-Removido pelo(a) " + Funcionario.Tipo + ": " + listaDeProdutos[variavel].Nome + "-";

                    //Se a quantidade de produtos for igual a 0, remove o item da lista de Produtos
                    if (listaDeProdutos[variavel].Quantidade == 0)
                    {
                        listaDeProdutos.RemoveAt(variavel);
                    }
                    //Remove o item da ComboPox
                    cbxRemover.Items.RemoveAt(cbxRemover.SelectedIndex);

                    //Limpa a ComboBox para depois atualiza-la com os novos itens
                    cbxRemover.Items.Clear();
                    AtualizaLista();
                }
                else
                {
                    //Caso a quantidade do item nao for maior q 0 já remove da Lista e da ComboBox
                    lblNotinha.Text += "\n-Removido pelo(a) " + Funcionario.Tipo + ": " + listaDeProdutos[cbxRemover.SelectedIndex].Nome + "-";
                    listaDeProdutos.RemoveAt(variavel);
                    cbxRemover.Items.Remove(cbxRemover.SelectedItem);
                }

                cbxRemover.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Não há produtos para remover!");
            }
        }

        private void cbxQuilo_CheckedChanged(object sender, EventArgs e)
        {
            //Verifica se o CheckBox de Quilo está marcado
            bool varOne;
            bool varTwo;

            if (chkQuilo.Checked)
            {
                varOne = true;
                varTwo = false;  
            }
            else
            {
                varOne = false;
                varTwo = true;
            }

            lblPeso.Visible = varOne;
            txtPeso.Visible = varOne;
            lblQuantidade.Visible = varTwo;
            txtQuantidade.Visible = varTwo;
        }

        private void cbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verifica qual usuario está usando o sistema. Bloqueia ou libera ações
            bool varOne;

            if (cbxUsuario.SelectedIndex == 0)
            {
                varOne = false;
                Funcionario = listaDeFuncionario[0];
            }
            else if(cbxUsuario.SelectedIndex == 1)
            {
                varOne = true;
                Funcionario = listaDeFuncionario[1];
            }
            else
            {
                varOne = true;
                Funcionario = listaDeFuncionario[2];
            }

            if (typeof(Diretor) == this.Funcionario.GetType() || typeof(Gerente) == this.Funcionario.GetType())
            {
                btnVerificarLucro.Enabled = true;
            }
            else
            {
                btnVerificarLucro.Enabled = false;
            }

            cbxRemover.Visible = varOne;
            btnRemover.Visible = varOne;
            groupBoxRemover.Visible = varOne;
        }

        private void btnVerificarLicro_Click(object sender, EventArgs e)
        {
            //Vê o faturamento do dia do sistema
            double fechamento = 0;

            fechamento += FechamentoDoCaixa.ValorDia;

            MessageBox.Show("Lucro do dia: " + fechamento.ToString("C"));
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            //Reseta a lista de produtos e a ComboBox para adicionar os itens do proximo cliente
            btnAdicionar.Enabled = true;
            listaDeProdutos.Clear();
            cbxRemover.Items.Clear();
            ValorTotal = 0;
            lblNotinha.Text = "**** GRANDÃO SUPERMERCADO ****";
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            //Verifica qual será a forma de pagamente do Cliente
            btnNovoCliente.Enabled = true;
            btnPagamento.Enabled = false;

            new FechamentoDoCaixa(ValorTotal);

            string retorno = Funcionario.RecebePagamento(cbxPagamento.SelectedItem.ToString());
            lblNotinha.Text += retorno;
            lblNotinha.Text += "\n***OBRIGADO E VOLTE SEMPRE ***";
        }
    }
}
