using System;

    internal class Menus: GerenciarFuncionariosService
    {

        internal static void MenuPrincipal()
        {
            Console.Clear();
            Inicio:
            Console.WriteLine("_______________|Gerenciar Funcionários|_______________\n\n\n");
            Console.WriteLine("Digite o indice da ação escolhida:\n(0) Fechar o programa.\n(1) Registrar funcionário.\n(2) Deletar funcionário.\n(3) Ler registro de funcionários.");
            Console.WriteLine("______________________________________________________");
            string indicador = Console.ReadLine();

            switch(indicador)
            {

                case "0":
                    Console.Clear();
                    Environment.Exit(0);
                break;
                case "1":
                    InstrucoesRegistrar();
                    Console.Clear();
                    registrarFuncionario();
                    Console.Clear();
                    Console.WriteLine("Pressione qualquer tecla para sair!");
                    Console.ReadKey();
                    Console.Clear();

                goto Inicio;
                case "2":
                    InstrucoesDeletar();
                    Console.Clear();
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

        internal static void InstrucoesRegistrar()
        {
            Console.Clear();
            Console.WriteLine("_______________|Regras para registrar um funcionário|_______________\n\n");
            Console.WriteLine(
            @"para registar um funcionário você deve seguir as seguintes regras:

            (1) no primeiro campo digite apenas o nome completo.

            (2) no segundo campo digite apenas o cargo do funcionário, o cargo deve seguir rigorosamente o modelo:

            >diretor;
            >gerente;
            >senior;
            >pleno;
            >junior;
            >estagiario;"
            );
            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        internal static void InstrucoesDeletar()
        {
            Console.Clear();
            Console.WriteLine("_______________|Regras para deletar um funcionário|_______________\n\n");
            Console.WriteLine(
            @"para deletar um funcionário você deve seguir as seguintes regras:

            (1) no primeiro campo digite apenas o nome completo.
            
            (2) no segundo campo digite apenas o cargo do funcionário, o cargo deve seguir rigorosamente o modelo:

            >diretor;
            >gerente;
            >senior;
            >pleno;
            >junior;
            >estagiario;"
            );
            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

    }
