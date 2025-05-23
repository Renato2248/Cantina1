namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        List<ItemCarrinho> carrinho = new List<ItemCarrinho>();

        public Form1()
        {
            InitializeComponent();
            produtos.Add(new Produto { Codigo = 1, Nome = "Coxinha", Estoque = 20, Preco = 5.00m });
            produtos.Add(new Produto { Codigo = 2, Nome = "Refrigerante", Estoque = 30, Preco = 6.50m });
            produtos.Add(new Produto { Codigo = 3, Nome = "Pão de Queijo", Estoque = 15, Preco = 3.00m });

            foreach (Produto produto in produtos)
            {
                lstProdutos.Items.Add(produto);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {



        }


        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (lstCarrinho.SelectedItem is ItemCarrinho item)
            {
                item.Produto.Estoque += item.Quantidade;
                carrinho.Remove(item);
                AtualizarListas();
            }
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
            string nomeCliente = txtNomeCliente.Text;
            string pagamento = cmbMetodoPagamento.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nomeCliente) || string.IsNullOrWhiteSpace(pagamento))
            {
                MessageBox.Show("Informe o nome e o método de pagamento.");
                return;
            }


        }

        private void bntAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtQuantidade.Text);
            var itemselecionado = lstProdutos.SelectedItem as Produto;

            if (itemselecionado != null)
            {
              lstCarrinho.Items.Add(new ItemCarrinho { Produto = itemselecionado, Quantidade = quantidade});
            }
            else
            {
                MessageBox.Show("erro, item nao selecionado kkk");
            }
            



        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }


}
