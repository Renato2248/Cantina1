namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        List<ItemCarrinho> carrinho = new List<ItemCarrinho>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            produtos.Add(new Produto { Codigo = 1, Nome = "Coxinha", Estoque = 20, Preco = 5.00m });
            produtos.Add(new Produto { Codigo = 2, Nome = "Refrigerante", Estoque = 30, Preco = 6.50m });
            produtos.Add(new Produto { Codigo = 3, Nome = "Pão de Queijo", Estoque = 15, Preco = 3.00m });

            lstProdutos.DataSource = new BindingSource(produtos, null);
            cmbMetodoPagamento.Items.AddRange(new string[] { "Dinheiro", "Cartão", "Pix" });
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItem is Produto produtoSelecionado)
            {
                int qtd = int.Parse(txtQuantidade.Text);
                if (qtd <= 0 || qtd > produtoSelecionado.Estoque)
                {
                    MessageBox.Show("Quantidade inválida ou insuficiente em estoque.");
                    return;
                }

                produtoSelecionado.Estoque -= qtd;
                carrinho.Add(new ItemCarrinho { Produto = produtoSelecionado, Quantidade = qtd });
                AtualizarListas();
            }
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

            decimal total = carrinho.Sum(item => item.Subtotal);
            MessageBox.Show($"Pedido finalizado!\nCliente: {nomeCliente}\nPagamento: {pagamento}\nTotal: R${total}");

            carrinho.Clear();
            AtualizarListas();
        }
    }

    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }
        public override string ToString() => $"{Codigo} - {Nome} - R${Preco} - Estoque: {Estoque}";
    }

    public class ItemCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal => Produto.Preco * Quantidade;
        public override string ToString() => $"{Produto.Nome} x{Quantidade} - R${Subtotal}";
    }
}
