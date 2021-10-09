using System;

    internal class Menus: GerenciarFuncionariosService
    {

        internal static void MenuPrincipal()
        {
            Console.Clear();
            Inicio:
            Console.WriteLine("_______________|Gerenciar Funcionarios|_______________\n\n\n");
            Console.WriteLine("Digite o indice da ação escolhida:\n(0) Fechar o programa.\n(1) Registrar funcionário.\n(2) Deletar funcionário.\n(3) Ler registro de funcionários.");
            string indicador = Console.ReadLine();

            switch(indicador)
            {

                case "0":
                    Console.Clear();
                    Environment.Exit(0);
                break;
                case "1":
                    registrarFuncionario();
                    Console.Clear();
                    Console.WriteLine("Pressione qualquer tecla para sair!");
                    Console.ReadKey();
                    Console.Clear();

                goto Inicio;
                case "2":
                    DeletarFuncionario();
                    Console.Clear();
                    Console.WriteLine("Pressione qualquer tecla para sair!");
                    Console.ReadKey();
                    Console.Clear();
                goto Inicio;
                case "3":
                    LerRegistroFuncionarios();
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Pressione qualquer tecla para sair!");
                    Console.ReadKey();
                    Console.Clear();
                goto Inicio;
                default:
                goto Inicio;

            }

        }

    }
