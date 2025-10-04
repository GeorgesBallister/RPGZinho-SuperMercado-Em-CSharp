using Classes;

public static class CriandoDados
{
    public static void CriandoCorredores(List<CorredoresClasse> corredores)
    {
        var itens = new List<Itens>();
        var iten1 = new Itens(1, "comida1", "Comidas", 20, 1);
        itens.Add(iten1);
        var prateleira1 = new Prateleira("Comida", 1, itens);
        var prateleiras = new List<Prateleira>();
        prateleiras.Add(prateleira1);
        var corredor1 = new CorredoresClasse(1, "testando", prateleiras);

        corredores.Add(corredor1);
    }
    public static void CriandoPrateleiras()
    {

    }
    public static void CriandoProdutos()
    {

    }



}