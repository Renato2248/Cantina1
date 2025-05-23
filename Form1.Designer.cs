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
            cmbMetodoPagamento = new ComboBox();
            lstProdutos = new ListBox();
            lstCarrinho = new ListBox();
            bntAdicionarCarrinho = new Button();
            bntFinalizarPedido = new Button();
            bntRemoverItem = new Button();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            txtQuantidade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            SuspendLayout();
            // 
            // cmbMetodoPagamento
            // 
            cmbMetodoPagamento.FormattingEnabled = true;
            cmbMetodoPagamento.Location = new Point(471, 23);
            cmbMetodoPagamento.Name = "cmbMetodoPagamento";
            cmbMetodoPagamento.Size = new Size(121, 23);
            cmbMetodoPagamento.TabIndex = 0;
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
            bntAdicionarCarrinho.Location = new Point(385, 122);
            bntAdicionarCarrinho.Name = "bntAdicionarCarrinho";
            bntAdicionarCarrinho.Size = new Size(75, 23);
            bntAdicionarCarrinho.TabIndex = 3;
            bntAdicionarCarrinho.Text = "Adicionar";
            bntAdicionarCarrinho.UseVisualStyleBackColor = true;
            bntAdicionarCarrinho.Click += bntAdicionarCarrinho_Click;
            // 
            // bntFinalizarPedido
            // 
            bntFinalizarPedido.Location = new Point(385, 215);
            bntFinalizarPedido.Name = "bntFinalizarPedido";
            bntFinalizarPedido.Size = new Size(75, 23);
            bntFinalizarPedido.TabIndex = 4;
            bntFinalizarPedido.Text = "Finalizar";
            bntFinalizarPedido.UseVisualStyleBackColor = true;
            // 
            // bntRemoverItem
            // 
            bntRemoverItem.Location = new Point(385, 174);
            bntRemoverItem.Name = "bntRemoverItem";
            bntRemoverItem.Size = new Size(75, 23);
            bntRemoverItem.TabIndex = 5;
            bntRemoverItem.Text = "Remover";
            bntRemoverItem.UseVisualStyleBackColor = true;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(385, 263);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(100, 23);
            txtNomeCliente.TabIndex = 7;
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
            txtQuantidade.Location = new Point(316, 86);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtQuantidade);
            Controls.Add(label1);
            Controls.Add(txtNomeCliente);
            Controls.Add(bntRemoverItem);
            Controls.Add(bntFinalizarPedido);
            Controls.Add(bntAdicionarCarrinho);
            Controls.Add(lstCarrinho);
            Controls.Add(lstProdutos);
            Controls.Add(cmbMetodoPagamento);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMetodoPagamento;
        private ListBox lstProdutos;
        private ListBox lstCarrinho;
        private Button bntAdicionarCarrinho;
        private Button bntFinalizarPedido;
        private Button bntRemoverItem;
        private TextBox txtNomeCliente;
        private Label label1;
        private NumericUpDown txtQuantidade;
    }
}
