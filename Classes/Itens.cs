using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Itens
    {
        public int ID {  get; set; }
        public string Nome {  get; set; }
        public string Categoria { get; set; }
        public int Valor { get; set; }
        public int Quantidade { get; set; }

        public Itens() { }

        public Itens(int id, string nome, string categoria, int valor, int quantidade)
        {
            this.ID = id;
            this.Nome = nome;
            this.Categoria = categoria;
            this.Valor = valor;
            this.Quantidade = quantidade;

        }


        // Função so pra testar usando Value.PrintarTudoTeste dentro do Dicionario de todosOsITens
        public void PrintaTudoTeste()
        {
            Console.WriteLine(this.ID);
            Console.WriteLine(this.Nome);
            Console.WriteLine(this.Valor);
            Console.WriteLine(this.Quantidade);
            Console.WriteLine(this.Categoria);

        }
    }
}
