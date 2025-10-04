namespace RPGZinhoSuperMercadoEmCSharp;

// Pacotes e bibliotecas
using System.IO;
using Newtonsoft.Json;
using Classes;

public class Program
{
    public static void Main()
    {

        // Crud Lista de compras
        // Criar Itens Ficticios
        // 1 - Menuzinho ali com as operações
            // Explorar Mercado
                // Checar Categorias
                    // Ver Itens
                     // Adcionar item na sacola (Dicionario)
            // Remover Item
            // Ver Lista
            // Comprar tudo
        // Aparecer nota fiscal
        // Relatorio 

        Console.WriteLine("Seja bem vindo ao mercadinho Legal, onde voce pode comprar suas muambas");
        Console.WriteLine("Pressione alguma Enter para continuar:");
        Console.ReadLine();
        Console.Clear();




        bool menuOnOff = true;
        while (menuOnOff)
        {
            // Menu
            Console.WriteLine("======Menu======");
            Console.WriteLine("1 - Explorar Mercado");
            Console.WriteLine("2 - Remover item da sacola");
            Console.WriteLine("3 - Adcionar item na sacola");
            Console.WriteLine("4 - Ver Lista");
            Console.WriteLine("5 - Comprar tudo");
            Console.WriteLine("6 - Ir Embora");
            Console.WriteLine("\nDigite uma opção:");

            int opcaoMenu;

            int.TryParse(Console.ReadLine(), out opcaoMenu);

            switch (opcaoMenu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Explorando mercado");
                    CriandoDados.FuncaoTeste();
                    break;

                case 6:
                    Console.Clear();
                    menuOnOff = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("opção invaldia");
                    break;
            }

        }

        Console.WriteLine("Saindo do programa....");

    }
}