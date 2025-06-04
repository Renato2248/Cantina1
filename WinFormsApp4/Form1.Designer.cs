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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstProdutos
            // 
            lstProdutos.BackColor = Color.FromArgb(243, 241, 238);
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 15;
            lstProdutos.Location = new Point(83, 86);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(184, 184);
            lstProdutos.TabIndex = 1;
            lstProdutos.SelectedIndexChanged += lstProdutos_SelectedIndexChanged;
            // 
            // lstCarrinho
            // 
            lstCarrinho.BackColor = Color.FromArgb(243, 241, 238);
            lstCarrinho.FormattingEnabled = true;
            lstCarrinho.ItemHeight = 15;
            lstCarrinho.Location = new Point(560, 86);
            lstCarrinho.Name = "lstCarrinho";
            lstCarrinho.Size = new Size(186, 184);
            lstCarrinho.TabIndex = 2;
            lstCarrinho.SelectedIndexChanged += lstCarrinho_SelectedIndexChanged;
            // 
            // bntAdicionarCarrinho
            // 
            bntAdicionarCarrinho.BackColor = Color.FromArgb(243, 241, 238);
            bntAdicionarCarrinho.Location = new Point(326, 129);
            bntAdicionarCarrinho.Name = "bntAdicionarCarrinho";
            bntAdicionarCarrinho.Size = new Size(75, 23);
            bntAdicionarCarrinho.TabIndex = 3;
            bntAdicionarCarrinho.Text = "Adicionar";
            bntAdicionarCarrinho.UseVisualStyleBackColor = false;
            bntAdicionarCarrinho.Click += bntAdicionarCarrinho_Click;
            // 
            // bntFinalizarPedido
            // 
            bntFinalizarPedido.BackColor = Color.Transparent;
            bntFinalizarPedido.BackgroundImage = (Image)resources.GetObject("bntFinalizarPedido.BackgroundImage");
            bntFinalizarPedido.BackgroundImageLayout = ImageLayout.Stretch;
            bntFinalizarPedido.FlatAppearance.BorderSize = 0;
            bntFinalizarPedido.FlatStyle = FlatStyle.Flat;
            bntFinalizarPedido.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bntFinalizarPedido.Location = new Point(302, 432);
            bntFinalizarPedido.Name = "bntFinalizarPedido";
            bntFinalizarPedido.Size = new Size(225, 65);
            bntFinalizarPedido.TabIndex = 4;
            bntFinalizarPedido.Text = "Finalizar";
            bntFinalizarPedido.UseVisualStyleBackColor = false;
            bntFinalizarPedido.Click += bntFinalizarPedido_Click;
            // 
            // bntRemoverItem
            // 
            bntRemoverItem.BackColor = Color.FromArgb(243, 241, 238);
            bntRemoverItem.FlatStyle = FlatStyle.Flat;
            bntRemoverItem.Location = new Point(326, 167);
            bntRemoverItem.Name = "bntRemoverItem";
            bntRemoverItem.Size = new Size(75, 23);
            bntRemoverItem.TabIndex = 5;
            bntRemoverItem.Text = "Remover";
            bntRemoverItem.UseVisualStyleBackColor = false;
            bntRemoverItem.Click += bntRemoverItem_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = Color.FromArgb(243, 241, 238);
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
            txtQuantidade.BackColor = Color.FromArgb(243, 241, 238);
            txtQuantidade.Location = new Point(326, 86);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 9;
            txtQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(230, 255, 0);
            lblTotal.FlatStyle = FlatStyle.Flat;
            lblTotal.Location = new Point(560, 343);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 255, 0);
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
            label3.BackColor = Color.FromArgb(230, 255, 0);
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 340);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 13;
            label3.Text = "Valor recebido";
            // 
            // valorreebidotxt
            // 
            valorreebidotxt.BackColor = Color.FromArgb(243, 241, 238);
            valorreebidotxt.Location = new Point(325, 340);
            valorreebidotxt.Name = "valorreebidotxt";
            valorreebidotxt.Size = new Size(100, 23);
            valorreebidotxt.TabIndex = 14;
            valorreebidotxt.Text = "0";
            valorreebidotxt.TextChanged += valorreebidotxt_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(230, 255, 0);
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(194, 372);
            label4.Name = "label4";
            label4.Size = new Size(126, 22);
            label4.TabIndex = 15;
            label4.Text = "Troco";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
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
            metododePagamento.BackColor = Color.FromArgb(243, 241, 238);
            metododePagamento.FormattingEnabled = true;
            metododePagamento.Location = new Point(316, 274);
            metododePagamento.Name = "metododePagamento";
            metododePagamento.Size = new Size(121, 23);
            metododePagamento.TabIndex = 17;
            metododePagamento.SelectedIndexChanged += metododePagamento_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(243, 241, 238);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 122, 106);
            ClientSize = new Size(1391, 649);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
