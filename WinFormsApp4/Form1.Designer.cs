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
            label5 = new Label();
            Butaobalcao = new Button();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstProdutos
            // 
            lstProdutos.BackColor = Color.FromArgb(243, 241, 238);
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 15;
            lstProdutos.Location = new Point(12, 86);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(255, 199);
            lstProdutos.TabIndex = 1;
            lstProdutos.SelectedIndexChanged += lstProdutos_SelectedIndexChanged;
            // 
            // lstCarrinho
            // 
            lstCarrinho.BackColor = Color.FromArgb(243, 241, 238);
            lstCarrinho.FormattingEnabled = true;
            lstCarrinho.ItemHeight = 15;
            lstCarrinho.Location = new Point(478, 86);
            lstCarrinho.Name = "lstCarrinho";
            lstCarrinho.Size = new Size(240, 199);
            lstCarrinho.TabIndex = 2;
            lstCarrinho.SelectedIndexChanged += lstCarrinho_SelectedIndexChanged;
            // 
            // bntAdicionarCarrinho
            // 
            bntAdicionarCarrinho.BackColor = Color.FromArgb(230, 255, 0);
            bntAdicionarCarrinho.FlatStyle = FlatStyle.Flat;
            bntAdicionarCarrinho.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            bntAdicionarCarrinho.Location = new Point(323, 129);
            bntAdicionarCarrinho.Name = "bntAdicionarCarrinho";
            bntAdicionarCarrinho.Size = new Size(120, 33);
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
            bntFinalizarPedido.Location = new Point(522, 501);
            bntFinalizarPedido.Name = "bntFinalizarPedido";
            bntFinalizarPedido.Size = new Size(225, 65);
            bntFinalizarPedido.TabIndex = 4;
            bntFinalizarPedido.Text = "Finalizar";
            bntFinalizarPedido.UseVisualStyleBackColor = false;
            bntFinalizarPedido.Click += bntFinalizarPedido_Click;
            // 
            // bntRemoverItem
            // 
            bntRemoverItem.BackColor = Color.FromArgb(230, 255, 0);
            bntRemoverItem.FlatStyle = FlatStyle.Flat;
            bntRemoverItem.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            bntRemoverItem.Location = new Point(323, 195);
            bntRemoverItem.Name = "bntRemoverItem";
            bntRemoverItem.Size = new Size(120, 32);
            bntRemoverItem.TabIndex = 5;
            bntRemoverItem.Text = "Remover";
            bntRemoverItem.UseVisualStyleBackColor = false;
            bntRemoverItem.Click += bntRemoverItem_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = Color.FromArgb(243, 241, 238);
            txtNomeCliente.Location = new Point(903, 104);
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
            txtQuantidade.Location = new Point(323, 86);
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
            lblTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTotal.Location = new Point(537, 423);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 21);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 255, 0);
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(772, 104);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 11;
            label2.Text = "Nomes Cliente";
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.BackColor = Color.FromArgb(243, 241, 238);
            labeltotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            labeltotal.Location = new Point(627, 423);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(20, 21);
            labeltotal.TabIndex = 12;
            labeltotal.Text = "0";
            labeltotal.Click += labeltotal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(230, 255, 0);
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(772, 206);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 13;
            label3.Text = "Valor recebido";
            // 
            // valorreebidotxt
            // 
            valorreebidotxt.BackColor = Color.FromArgb(243, 241, 238);
            valorreebidotxt.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            valorreebidotxt.Location = new Point(903, 206);
            valorreebidotxt.Name = "valorreebidotxt";
            valorreebidotxt.Size = new Size(100, 29);
            valorreebidotxt.TabIndex = 14;
            valorreebidotxt.Text = "0";
            valorreebidotxt.TextChanged += valorreebidotxt_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(230, 255, 0);
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(771, 251);
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
            lblTroco.BackColor = Color.FromArgb(243, 241, 238);
            lblTroco.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTroco.Location = new Point(903, 252);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(70, 21);
            lblTroco.TabIndex = 16;
            lblTroco.Text = "R$ 0,00";
            lblTroco.Click += lblTroco_Click;
            // 
            // metododePagamento
            // 
            metododePagamento.BackColor = Color.FromArgb(243, 241, 238);
            metododePagamento.FormattingEnabled = true;
            metododePagamento.Location = new Point(903, 155);
            metododePagamento.Name = "metododePagamento";
            metododePagamento.Size = new Size(121, 23);
            metododePagamento.TabIndex = 17;
            metododePagamento.SelectedIndexChanged += metododePagamento_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(230, 255, 0);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(230, 255, 0);
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(772, 153);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 19;
            label5.Text = "Form de Pagar";
            // 
            // Butaobalcao
            // 
            Butaobalcao.Location = new Point(185, 528);
            Butaobalcao.Name = "Butaobalcao";
            Butaobalcao.Size = new Size(75, 23);
            Butaobalcao.TabIndex = 20;
            Butaobalcao.Text = "Balcão";
            Butaobalcao.UseVisualStyleBackColor = true;
            Butaobalcao.Click += Butaobalcao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 122, 106);
            ClientSize = new Size(1391, 649);
            Controls.Add(Butaobalcao);
            Controls.Add(label5);
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
        private Label label5;
        private Button Butaobalcao;
    }
}
