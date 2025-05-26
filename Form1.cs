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
            labeltotal.Text = $"R$ {total.ToString("N2", new CultureInfo("pt-BR"))}";
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
                lblTotal.Text = "O valor total da compra é: R$ " + total.ToString("F2");
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
        private void Troco();
        {
          if (decimal.TryParse(valorrecebidotxt.text,out decimal valorRecebido))
          {
              decimal troco = valorRecebido - totalPedido;
              if (troco < 0) troco =0;
              lblValorTroco.Text = TableLa
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

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorreebidotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
