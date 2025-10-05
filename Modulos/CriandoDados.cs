using Classes;
using JsonSerializer = System.Text.Json.JsonSerializer; // seu namespace com Itens, Prateleira, CorredoresClasse

namespace Modulos;
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


    public static Dictionary<int, Prateleira> CriandoPrateleiras(Dictionary<int, Itens> dicionarioDeItens)
    {
        if (dicionarioDeItens == null) throw new ArgumentNullException(nameof(dicionarioDeItens));

        var prateleiras = new Dictionary<int, Prateleira>();

        // 1. Puxar categorias únicas (case-insensitive)
        var categorias = dicionarioDeItens.Values
            .Select(i => i.Categoria ?? string.Empty)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();

        // 2. Montar prateleiras com base nas categorias
        for (int i = 0; i < categorias.Count; i++)
        {
            var prateleiraModelo = new Prateleira
            {
                ID = i,
                Categoria = categorias[i],
                Itens = new List<Itens>() // garante lista inicializada
            };


            // 2.1 Adicionar itens somente daquela categoria (case-insensitive)
            foreach (var kvp in dicionarioDeItens)
            {
                var item = kvp.Value;
                if (string.Equals(item.Categoria, categorias[i], StringComparison.OrdinalIgnoreCase))
                {
                    prateleiraModelo.Itens.Add(item);
                }
            }

            prateleiras.Add(i, prateleiraModelo);
        }

        return prateleiras;
    }


}
