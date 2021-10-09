using sistema_gerenciamento_empresarial.Models.Beneficios;
using System.IO;
using System;

class GerenciarFuncionariosService : Salario
{

    protected static void registrarFuncionario()
    {
        Console.Clear();
        char separator = Path.AltDirectorySeparatorChar;
        string path = $@"Data{separator}funcionarios.txt";

        Console.WriteLine("______________________________\nDigite o nome do funcionário:\n______________________________");
        string nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("______________________________\nDigite o cargo do funcionário:\n______________________________");
        string cargo = Console.ReadLine();
        File.AppendAllText(path, $"\n\n{FuncionarioInfo(nome, cargo)}\n\n");
    }

    protected static void DeletarFuncionario()
    {
        Console.Clear();
        char separator = Path.AltDirectorySeparatorChar;
        string path = $@"Data{separator}funcionarios.txt";
        if(!File.Exists(path))
        {
            Console.WriteLine("Não há funcionários para deletar");
            Console.ReadKey();
            Menus.MenuPrincipal();
            
        }else
        {
            
        }
       Console.WriteLine("______________________________\nDigite o nome do funcionário:\n______________________________");
        string nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("______________________________\nDigite o cargo do funcionário:\n______________________________");
        string cargo = Console.ReadLine();
        Console.Clear();


        Salario funcionario = new Salario();
        double salario = funcionario.Calular_Salario(cargo);

        string dados = $"\n\n{FuncionarioInfo(nome, cargo)}\n\n";

        string arquivo = File.ReadAllText(path);
        string arquivoProcessado= arquivo.Replace(dados, string.Empty);
        File.Delete(path);
        File.AppendAllText(path, arquivoProcessado);
        string arquivoPosDeleta = File.ReadAllText(path);
        if(arquivoPosDeleta.Equals(string.Empty))
            File.Delete(path);
    }


    protected static void LerRegistroFuncionarios()
    {
        Console.Clear();
        char separator = Path.AltDirectorySeparatorChar;
        string path = $@"Data{separator}funcionarios.txt";

        if(File.Exists(path))
            Console.WriteLine(File.ReadAllText(path));
        else
        {
            Console.WriteLine("Não há funcionários no momento.");
        }
    }



    private static string FuncionarioInfo(string nome, string cargo)
    {
        Salario funcionario = new Salario();
        funcionario._nome = nome;
        funcionario._cargo = cargo;
        funcionario.Calular_Salario();
        string funcionario_info = $@"Nome: {funcionario._nome}
                                     Cargo: {funcionario._cargo}
                                     Salario: {funcionario._salario}
                                     Benefícios: {Beneficios.DeterminarBeneficios(funcionario._cargo)}";

        return funcionario_info;
    }

}