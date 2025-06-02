using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }
        public override string ToString() => $"{Codigo} - {Nome} - R${Preco} - Estoque: {Estoque}";
    }

}
