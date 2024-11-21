using System;

namespace SistemaInventario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Gerenciamento de Inventário!");
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Visualizar Estoque");
            Console.WriteLine("3. Registrar Movimentação");
            Console.WriteLine("Escolha uma opção:");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastrar Produto selecionado.");
                    break;
                case "2":
                    Console.WriteLine("Visualizar Estoque selecionado.");
                    break;
                case "3":
                    Console.WriteLine("Registrar Movimentação selecionado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
