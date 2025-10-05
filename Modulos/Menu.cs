using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos;

    public static class Menu
    {
    public static List<Itens> ExplorarMercado(Dictionary<int, Prateleira> Prateleiras, List<Itens> sacola)
    {
        // Exibir Todas as Categorias das prateleiras
        for (int i = 0; i < Prateleiras.Count; i++)
        {
            Console.WriteLine(i + " Prateleira - " + Prateleiras[i].Categoria);
        }

        // loop

        int opcaoPrateleira;
        while (true)
        {

            Console.WriteLine("Digite o numero de qual Prateleira você quer explorar?");
            // Capturar opção e converter para int
            int.TryParse(Console.ReadLine(), out opcaoPrateleira);

            //Verificar se prateleira existe
            if (!Prateleiras.ContainsKey(opcaoPrateleira))
            {
                Console.WriteLine("Prateleira " + opcaoPrateleira + " não existe, tente outra opção.");
                continue;
            }
            break;
        }

        // Exibir todos os produtos daquela prateleira
        Console.Clear();
        for (int i = 0; i < Prateleiras[opcaoPrateleira].Itens.Count; i++)
        {
            Prateleiras[opcaoPrateleira].Itens[i].MostrarInformacoesDoItem();
        }

        Console.WriteLine("Digite o ID do item que você quer pegar:");

        // Validar se o ID do item existe no dicionario
        int itemSelecionado;
        int.TryParse(Console.ReadLine(), out itemSelecionado);

        Itens itemEncontrado = Prateleiras[opcaoPrateleira].Itens.Find(item => item.ID == itemSelecionado);

        if (itemEncontrado != null)
        {
            sacola.Add(itemEncontrado);
            Prateleiras[opcaoPrateleira].Itens

            return sacola;
        }

        // Armazenar na lista

        // Subtrair quantidade de itens

    }

    }

