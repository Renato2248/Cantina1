using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
   
   
    

    public class ItemCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal => Produto.Preco * Quantidade;
        public override string ToString() => $"{Produto.Nome} x{Quantidade} - R${Subtotal}";
    }

}
