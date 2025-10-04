using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Prateleira
    {
        public string Categoria { get; set; }
        public int ID { get; set; }
        public List<Itens> Itens { get; set; } = new List<Itens>();


        public Prateleira(string categoria, int numeroPrateleira, List<Itens> itensLista)
        {
            this.Categoria = categoria;
            this.ID = numeroPrateleira;
            this.Itens = itensLista;
        }
    }
}
