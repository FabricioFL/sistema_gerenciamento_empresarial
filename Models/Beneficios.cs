namespace sistema_gerenciamento_empresarial.Models.Beneficios
{
    internal class Beneficios
{
    internal static string DeterminarBeneficios(string cargo)
    {

        switch(cargo)
        {
            case "diretor":
                 return "Plano de saude tipo S, Plano dentario tipo S, Vale alimentação tipo S, Vale transporte tipo S";
            case "gerente":
                return "Plano de saude tipo A, Plano dentario tipo A, Vale alimentação tipo A, Vale transporte tipo A";
            case "senior":
                return "Plano de saude tipo B, Plano dentario tipo B, Vale alimentação tipo B, Vale transporte tipo B";
            case "pleno":
                return "Plano de saude tipo C, Plano dentario tipo C, Vale alimentação tipo C, Vale transporte tipo C";
            case "junior":
                return "Plano de saude tipo D, Plano dentario tipo D, Vale alimentação tipo D";
            case "estagiario":
                return "Plano de saude tipo E, Plano dentario tipo E, Vale alimentação tipo E";
            default:
                return "Cargo não existente!";

        }
    }
}
}