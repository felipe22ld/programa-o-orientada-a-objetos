namespace POO.ClassesEOutrosTipos.ClasseSelada;

public sealed class Configuracao
{
    public string Host { get; set; }

    public static void ExemploClasseSelada()
    {
        // => object initialize
        var configuracao = new Configuracao
        {
            Host = "localhostTeste",
        };

        Console.WriteLine(configuracao.Host);
    }
}