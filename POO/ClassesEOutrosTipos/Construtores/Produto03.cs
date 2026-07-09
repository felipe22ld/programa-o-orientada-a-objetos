namespace POO.ClassesEOutrosTipos.Construtores;

public class Produto03
{
    public string Descricao { get; set; }

    public Produto03()
    {
        Console.WriteLine("Construtor padrao chamado!");
        Console.WriteLine("objeto criado");
        Descricao = "Mouse Teste";
    }

    public Produto03(string descricao)
    {
        Console.WriteLine("Construtor padrao chamado!");
        Console.WriteLine("objeto criado");
        Descricao = descricao;
    }

    public static void ExemplosConstrutores()
    {
        var produto03 = new Produto03();
        // produto03.Descricao = "Mouse";
        Console.WriteLine(produto03.Descricao);

        var produto03v2 = new Produto03("Testando");
        Console.WriteLine(produto03v2.Descricao);
    }
}