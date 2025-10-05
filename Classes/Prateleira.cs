using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Prateleira
    {
        public string Categoria { get; set; }
        public int ID { get; set; }
        public List<Itens> Itens { get; set; } = new List<Itens>();

        public Prateleira() { }
        
        public Prateleira(string categoria, int numeroPrateleira, List<Itens> itensLista)
        {
            this.ID = numeroPrateleira;
            this.Categoria = categoria;
            this.Itens = itensLista;
        }


        // Testar 
        public void TestarPrateleiras()
        {
            Console.WriteLine(this.ID);
            Console.WriteLine(this.Categoria);
        }
    }
}
