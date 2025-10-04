using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class CorredoresClasse
    {
        public int NumeroDoCorredor {  get; set; }
        public string CategoriaDoCorredor { get; set; }
        public List<Prateleira> Prateleiras { get; set; } = new List<Prateleira>();

        public CorredoresClasse(int numero, string categoria, List<Prateleira> prateleira)
        {
            this.NumeroDoCorredor = numero;
            this.CategoriaDoCorredor= categoria;
            this.Prateleiras = prateleira;
        }

    }
}
