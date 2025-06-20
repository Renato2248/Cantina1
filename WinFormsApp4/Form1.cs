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
            metododePagamento.Items.AddRange(new string[] { "Pix", "Cart�o de Cr�dito/D�bito", "Dinheiro" });
            metododePagamento.SelectedIndex = 0;
            Total();

            lstProdutos.Items.Add(new Produto { Codigo = 1, Nome = "Coxinha", Estoque = 20, Preco = 5.00m });
            lstProdutos.Items.Add(new Produto { Codigo = 2, Nome = "Refrigerante Lata", Estoque = 30, Preco = 4.50m });
            lstProdutos.Items.Add(new Produto { Codigo = 3, Nome = "P�o de Queijo", Estoque = 15, Preco = 3.50m });
            lstProdutos.Items.Add(new Produto { Codigo = 3, Nome = "Pastel Carne", Estoque = 15, Preco = 6.00m });
            lstProdutos.Items.Add(new Produto { Codigo = 3, Nome = "Pastel Queijo", Estoque = 15, Preco = 5.50m });
            lstProdutos.Items.Add(new Produto { Codigo = 3, Nome = "Suco Natural", Estoque = 15, Preco = 4.00m });
            lstProdutos.Items.Add(new Produto { Codigo = 3, Nome = "Hamburguer de Queijo", Estoque = 15, Preco = 9.00m });
            lstProdutos.Items.Add(new Produto { Codigo = 3, Nome = "Hamburguer Simples", Estoque = 15, Preco = 8.00m });
            lstProdutos.Items.Add(new Produto { Codigo = 3, Nome = "X-Tudo", Estoque = 15, Preco = 12.00m });
            lstProdutos.Items.Add(new Produto { Codigo = 3, Nome = "Agua Mineral", Estoque = 15, Preco = 2.50m });
        }
        private void Total()
        {
            total = 0;


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
                    lblTotal.Text = "O carrinho est� vazio.";
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

            if (lstCarrinho.SelectedItem != null)
            {
                ItemCarrinho item = (ItemCarrinho)lstCarrinho.SelectedItem;
                lstCarrinho.Items.Remove(lstCarrinho.SelectedItem);
            }
            Total();





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
                    MessageBox.Show("falta grana ae ");
                }
            }

            if (metododePagamento.SelectedIndex == -1)

            {
                MessageBox.Show("nao escolheu metodo de pagamento");
                return;
            }


            MessageBox.Show($"Compra j� Feita \n" +
               $" Nome: {txtNomeCliente.Text} \n" +
               $" Data: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")} \n" +
               $" MetodoDePagamento: {metododePagamento.SelectedItem} \n" +
               $" Valor pago: {total.ToString("C", new CultureInfo("pt-BR"))}");



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
            else { }
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTroco_Click(object sender, EventArgs e)
        {

        }

        private void Butaobalcao_Click(object sender, EventArgs e)
        {
            Form2 formBalcao = new Form2();
            formBalcao.ShowDialog();
        }
    }


}
