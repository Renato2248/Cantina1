namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstProdutos = new ListBox();
            lstCarrinho = new ListBox();
            bntAdicionarCarrinho = new Button();
            bntFinalizarPedido = new Button();
            bntRemoverItem = new Button();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            txtQuantidade = new NumericUpDown();
            lblTotal = new Label();
            label2 = new Label();
            labeltotal = new Label();
            label3 = new Label();
            valorreebidotxt = new TextBox();
            label4 = new Label();
            lblTroco = new Label();
            metododePagamento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            SuspendLayout();
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 15;
            lstProdutos.Location = new Point(147, 86);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(120, 184);
            lstProdutos.TabIndex = 1;
            // 
            // lstCarrinho
            // 
            lstCarrinho.FormattingEnabled = true;
            lstCarrinho.ItemHeight = 15;
            lstCarrinho.Location = new Point(560, 86);
            lstCarrinho.Name = "lstCarrinho";
            lstCarrinho.Size = new Size(120, 184);
            lstCarrinho.TabIndex = 2;
            // 
            // bntAdicionarCarrinho
            // 
            bntAdicionarCarrinho.Location = new Point(326, 129);
            bntAdicionarCarrinho.Name = "bntAdicionarCarrinho";
            bntAdicionarCarrinho.Size = new Size(75, 23);
            bntAdicionarCarrinho.TabIndex = 3;
            bntAdicionarCarrinho.Text = "Adicionar";
            bntAdicionarCarrinho.UseVisualStyleBackColor = true;
            bntAdicionarCarrinho.Click += bntAdicionarCarrinho_Click;
            // 
            // bntFinalizarPedido
            // 
            bntFinalizarPedido.Location = new Point(326, 401);
            bntFinalizarPedido.Name = "bntFinalizarPedido";
            bntFinalizarPedido.Size = new Size(75, 23);
            bntFinalizarPedido.TabIndex = 4;
            bntFinalizarPedido.Text = "Finalizar";
            bntFinalizarPedido.UseVisualStyleBackColor = true;
            bntFinalizarPedido.Click += bntFinalizarPedido_Click;
            // 
            // bntRemoverItem
            // 
            bntRemoverItem.Location = new Point(326, 167);
            bntRemoverItem.Name = "bntRemoverItem";
            bntRemoverItem.Size = new Size(75, 23);
            bntRemoverItem.TabIndex = 5;
            bntRemoverItem.Text = "Remover";
            bntRemoverItem.UseVisualStyleBackColor = true;
            bntRemoverItem.Click += bntRemoverItem_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(326, 209);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(100, 23);
            txtNomeCliente.TabIndex = 7;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 325);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(326, 86);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 9;
            txtQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(560, 343);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 217);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Nome";
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.Location = new Point(610, 343);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(13, 15);
            labeltotal.TabIndex = 12;
            labeltotal.Text = "0";
            labeltotal.Click += labeltotal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 343);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 13;
            label3.Text = "Valor recebido";
            // 
            // valorreebidotxt
            // 
            valorreebidotxt.Location = new Point(325, 340);
            valorreebidotxt.Name = "valorreebidotxt";
            valorreebidotxt.Size = new Size(100, 23);
            valorreebidotxt.TabIndex = 14;
            valorreebidotxt.Text = "0";
            valorreebidotxt.TextChanged += valorreebidotxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 372);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 15;
            label4.Text = "troco";
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Location = new Point(343, 372);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(44, 15);
            lblTroco.TabIndex = 16;
            lblTroco.Text = "R$ 0,00";
            // 
            // metododePagamento
            // 
            metododePagamento.FormattingEnabled = true;
            metododePagamento.Location = new Point(316, 274);
            metododePagamento.Name = "metododePagamento";
            metododePagamento.Size = new Size(121, 23);
            metododePagamento.TabIndex = 17;
            metododePagamento.SelectedIndexChanged += metododePagamento_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(metododePagamento);
            Controls.Add(lblTroco);
            Controls.Add(label4);
            Controls.Add(valorreebidotxt);
            Controls.Add(label3);
            Controls.Add(labeltotal);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(txtQuantidade);
            Controls.Add(label1);
            Controls.Add(txtNomeCliente);
            Controls.Add(bntRemoverItem);
            Controls.Add(bntFinalizarPedido);
            Controls.Add(bntAdicionarCarrinho);
            Controls.Add(lstCarrinho);
            Controls.Add(lstProdutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstProdutos;
        private ListBox lstCarrinho;
        private Button bntAdicionarCarrinho;
        private Button bntFinalizarPedido;
        private Button bntRemoverItem;
        private TextBox txtNomeCliente;
        private Label label1;
        private NumericUpDown txtQuantidade;
        private Label lblTotal;
        private Label label2;
        private Label labeltotal;
        private Label label3;
        private TextBox valorreebidotxt;
        private Label label4;
        private Label lblTroco;
        private ComboBox metododePagamento;
    }
}
