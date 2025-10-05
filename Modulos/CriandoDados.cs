using System;
using System.Collections.Generic;
using System.Text.Json;
using Classes;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer; // seu namespace com Itens, Prateleira, CorredoresClasse

public static class CriandoDados
{
    // To usando Dicionario aqui porque meu foco é usar o dicionario, sei que é mais facil com outras estruturas, mas este é o meu desafio, quero puxar o JSon para uma lista e puxar os itens dessa lista como dicionarios
    public static Dictionary<int, Itens> CriandoItens()
    {

        // Caminho do Json com os produtos Ficticios:
        string caminhoDadosItens = "..\\..\\..\\Dados Ficticios\\TodoOsProdutos.json";

        // Ler arquivo
        string jsonString = File.ReadAllText(caminhoDadosItens);

        // Desserializar JSON em uma lista de Itens
        var dadosDoArquivo = JsonSerializer.Deserialize<List<Itens>>(jsonString)
                             ?? new List<Itens>(); // garante não ser null

        // convertendo a Lista dos dados desserializados para um dicionario fazendo um lambda cada chave deste novo dicionario sera o ID do item (dicionario dentro da lista que antes era JSON)
        var TodosOsProdutos = dadosDoArquivo.ToDictionary(item => item.ID);


        return TodosOsProdutos;
    }


    // Só para testar a minha teoria de que se eu for puxar os dados e utilziando uma lista daria no memso
    //public static void TesteParalelo()
    //{

    //    // Caminho do Json com os produtos Ficticios:
    //    string caminhoDadosItens = "..\\..\\..\\Dados Ficticios\\TodoOsProdutos.json";

    //    // Ler arquivo
    //    string jsonString = File.ReadAllText(caminhoDadosItens);

    //    var dadosDoArquivo = JsonSerializer.Deserialize<List<Itens>>(jsonString)
    //                     ?? new List<Itens>(); // garante não ser null

    //    for (int i = 0; i < dadosDoArquivo.Count; i++)
    //    {
    //        dadosDoArquivo[i].PrintaTudoTeste();

    //    }
    //}



    public static Dictionary<int, Prateleira> CriandoPrateleiras(Dictionary<int, Itens> dicionarioDeItens)
    {
        Dictionary<int, Prateleira> prateleiras = new Dictionary<int, Prateleira>();

        // Organizar as prateleiras por categorias, lendo todos os dados dos itens, lendo suas categorias, criando somente prateleiras com nomes de categorias que existem dentro do JSON

        // 1. Ler Dicionario de Itens e Puxar as categorias;
        List<string> categorias = new List<string>();
        foreach (var valores in dicionarioDeItens.Values)
        {
            categorias.Add(valores.Categoria);
        }

        // 2. Montar Prateleiras com base nas categorias
        for (int i = 0; i < categorias.Count; i++)
        {
            //Molde para armazenar valores
            var prateleiraModelo = new Prateleira();
            prateleiraModelo.ID = i;
            prateleiraModelo.Categoria = categorias[i];

            // 2.1 Adcionar itens somente daquela categoria
            foreach (var valores in dicionarioDeItens)
            {
                if (valores.Value.Categoria == categorias[i])
                {
                    prateleiraModelo.Itens.Add(valores.Value);
                }
            }
           prateleiras.Add(i, prateleiraModelo);
        }
        return prateleiras;
    }
}
