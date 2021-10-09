namespace sistema_gerenciamento_empresarial.Models.Imposto
{
    class Imposto
{

    private double geral = 0.05;

    private double relacional;


    internal double imposto_geral
    {
        get{return geral;}
    }

    internal double imposto_relacional
    {
        get{return relacional;}
    }

     internal double DeterminarImpostoRelacional(string _cargo)
    {
        switch(_cargo)
        {
            case "diretor":
                relacional = 0.2;
            break;
            case "gerente":
                relacional = 0.1;
            break;
            case "senior":
                relacional = 0.08;
            break;
            case "pleno":
                relacional = 0.05;
            break;
            case "junior":
                relacional = 1;
            break;
            case "estagiario":
                relacional = 1;
            break;
            default:
            relacional = 0;
            break;

        }
        return relacional;
    }
    



}
}