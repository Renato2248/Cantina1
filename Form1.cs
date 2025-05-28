using System.Configuration;
using System.Globalization;
using System.Numerics;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        List<ItemCarrinho> carrinho = new List<ItemCarrinho>();
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
            metododePagamento.Items.AddRange(new string[] { "Pix", "Cartão de Crédito/Débito", "Dinheiro" });
            metododePagamento.SelectedIndex = 0;
            Total();

            produtos.Add(new Produto { Codigo = 1, Nome = "Coxinha", Estoque = 20, Preco = 5.00m });
            produtos.Add(new Produto { Codigo = 2, Nome = "Refrigerante", Estoque = 30, Preco = 6.50m });
            produtos.Add(new Produto { Codigo = 3, Nome = "Pão de Queijo", Estoque = 15, Preco = 3.00m });


            foreach (Produto produto in produtos)
            {
                lstProdutos.Items.Add(produto);
            }
        }
        private void Total()
        {
            decimal total = 0;


            foreach (ItemCarrinho produto in lstCarrinho.Items)
            {


                total += produto.Subtotal;

            }
            labeltotal.Text = total.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {



        }


        private void btnRemoverItem_Click(object sender, EventArgs e)


        {

        }

        private void AtualizarListas()
        {
            lstProdutos.DataSource = null;
            lstProdutos.DataSource = new BindingSource(produtos, null);

            lstCarrinho.DataSource = null;
            lstCarrinho.DataSource = new BindingSource(carrinho, null);
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (lstCarrinho.SelectedItem != null)
            {
                Produto produto = (Produto)lstCarrinho.SelectedItem;

                total -= produto.Preco;
                labeltotal.Text = total.ToString();
                lstCarrinho.Items.RemoveAt(lstCarrinho.SelectedIndex);

                if (total == 0)
                {
                    lblTotal.Text = "O carrinho está vazio.";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione algo do Carrinho Por Favor.");
            }
        }


        private void bntAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtQuantidade.Text);
            var itemselecionado = lstProdutos.SelectedItem as Produto;

            if (itemselecionado != null)

            {
                lstCarrinho.Items.Add(new ItemCarrinho { Produto = itemselecionado, Quantidade = quantidade });
                lstCarrinho.Focus();
            }
            else
            {
                MessageBox.Show("erro, item nao selecionado kkk");
            }
            Total();



        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void bntRemoverItem_Click(object sender, EventArgs e)
        {

            if (lstCarrinho.SelectedIndex != null)
            {

                lstCarrinho.Items.RemoveAt(lstCarrinho.SelectedIndex);
            }
            else
            {


            }
        }

        private void cmbMetodoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntFinalizarPedido_Click(object sender, EventArgs e)
        {


            if (metododePagamento.SelectedIndex == 2 && valorreebidotxt.Text != "")
            {
                decimal valorRecebido = decimal.Parse(valorreebidotxt.Text);
                decimal total = decimal.Parse(labeltotal.Text);

                if (valorRecebido >= total)
                {


                    decimal troco = valorRecebido - total;

                    lblTroco.Text = troco.ToString();
                }

                else
                {
                    MessageBox.Show("vc e pobre e fodido e n tem dinheiro e ta faltando dinheiro kkkkk");
                }
            }
            else
            {
                MessageBox.Show("nao tem nada");
            }





        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorreebidotxt_TextChanged(object sender, EventArgs e)
        {



        }

        private void labeltotal_Click(object sender, EventArgs e)
        {

        }

        private void metododePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metododePagamento.SelectedIndex == 0 || metododePagamento.SelectedIndex == 1)
            {
                valorreebidotxt.Text = labeltotal.Text;

            }
        }
    }


}
