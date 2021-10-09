using sistema_gerenciamento_empresarial.Models.Imposto;
using System.Collections.Generic;

class Salario
{

    private double salario;

    private string cargo;

    private string nome;

    internal double _salario
    {
        get{return salario;}
    }

    internal string _nome
    {
        get{return nome;}
        set{nome = value;}
    }

    internal string _cargo
    {
        get{return cargo;}
        set{cargo = value;}
    }




    internal void Calular_Salario()
    {

        Imposto salarioLiquido = new Imposto();
        double imposto = salarioLiquido.DeterminarImpostoRelacional(cargo);

        switch(cargo)
        {
            case "diretor":
                salario = 50000 * imposto;
            break;
            case "gerente":
                salario = 28000 * imposto;
            break;
            case "senior":
                salario = 24000 * imposto;
            break;
            case "pleno":
                salario = 12000 * imposto;
            break;
            case "junior":
                salario = 4000 * imposto;
            break;
            case "estagiario":
                salario = 1600 * imposto;
            break;

        }

    }

        internal double Calular_Salario(string cargo)
    {

        Imposto salarioLiquido = new Imposto();
        double imposto =  salarioLiquido.DeterminarImpostoRelacional(cargo);

        Dictionary<string, double> cargos = new Dictionary<string, double>();
        cargos.Add("diretor", 50000 * imposto);
        cargos.Add("gerente", 28000 * imposto);
        cargos.Add("senior", 24000 * imposto);
        cargos.Add("pleno", 12000 * imposto);
        cargos.Add("junior", 4000 * imposto);
        cargos.Add("estagiario", 1600 * imposto);
        cargos.Add(" ", double.NaN);

        return cargos[cargo];
    }



}