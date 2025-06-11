namespace WinFormsApp4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1Preparando = new ListBox();
            listBox2Feitos = new ListBox();
            label1Preparando = new Label();
            label2Feito = new Label();
            SuspendLayout();
            // 
            // listBox1Preparando
            // 
            listBox1Preparando.BackColor = Color.FromArgb(243, 241, 238);
            listBox1Preparando.BorderStyle = BorderStyle.None;
            listBox1Preparando.FormattingEnabled = true;
            listBox1Preparando.ItemHeight = 15;
            listBox1Preparando.Location = new Point(133, 122);
            listBox1Preparando.Name = "listBox1Preparando";
            listBox1Preparando.Size = new Size(288, 360);
            listBox1Preparando.TabIndex = 0;
            listBox1Preparando.SelectedIndexChanged += listBox1Preparando_SelectedIndexChanged;
            // 
            // listBox2Feitos
            // 
            listBox2Feitos.BackColor = Color.FromArgb(243, 241, 238);
            listBox2Feitos.BorderStyle = BorderStyle.None;
            listBox2Feitos.FormattingEnabled = true;
            listBox2Feitos.ItemHeight = 15;
            listBox2Feitos.Location = new Point(626, 122);
            listBox2Feitos.Name = "listBox2Feitos";
            listBox2Feitos.Size = new Size(272, 360);
            listBox2Feitos.TabIndex = 1;
            // 
            // label1Preparando
            // 
            label1Preparando.AutoSize = true;
            label1Preparando.BackColor = Color.FromArgb(230, 255, 0);
            label1Preparando.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label1Preparando.Location = new Point(133, 79);
            label1Preparando.Name = "label1Preparando";
            label1Preparando.Size = new Size(104, 21);
            label1Preparando.TabIndex = 2;
            label1Preparando.Text = "Preparando";
            // 
            // label2Feito
            // 
            label2Feito.AutoSize = true;
            label2Feito.BackColor = Color.FromArgb(230, 255, 0);
            label2Feito.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label2Feito.Location = new Point(626, 79);
            label2Feito.Name = "label2Feito";
            label2Feito.Size = new Size(50, 21);
            label2Feito.TabIndex = 3;
            label2Feito.Text = "Feito";
            label2Feito.Click += label2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 122, 106);
            ClientSize = new Size(1459, 659);
            Controls.Add(label2Feito);
            Controls.Add(label1Preparando);
            Controls.Add(listBox2Feitos);
            Controls.Add(listBox1Preparando);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1Preparando;
        private ListBox listBox2Feitos;
        private Label label1Preparando;
        private Label label2Feito;
    }
}