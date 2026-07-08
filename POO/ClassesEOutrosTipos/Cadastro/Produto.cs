namespace POO.ClassesEOutrosTipos.Cadastro;

public class Produto
{
    private int Id;

    // isso é uma propriedade
    public string Descricao { get; set; }


    // public readonly int Estoque;
    public int Estoque { get; }

    public Produto()
    {
        Estoque = 10;
    }

    //Comportamento da classe => método
    public void ImprimirDescricao()
    {
        //Ação que será executada
        Console.WriteLine(Descricao);
    }

    public void SetId(int id)
    {
        Id = id;
    }

    public int GetId()
    {
        return Id;
    }

    public static void Executar()
    {
        //classe dinâmica, instância o obj e utiliza o método
        var produto = new Produto
        {
            Descricao = "Teclado"
        };
        produto.SetId(1);
        produto.ImprimirDescricao();
        Console.WriteLine(produto.GetId());
        produto.ImprimirDescricao();

        //classe estatica, chama o método direto da classe. Não precisa instanciar o obj
        var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
        Console.WriteLine(resultado);
    }
    // classe => Modelo para representar um objeto no mundo real.
    //objeto => é um instancia de uma classe cria com o new.
    //propriedades => guarda informações sobre o obj.
    // metodo => executa a ação do objeto.
    //public => pode ser acessado de qualquer lugar da aplicação.
    //praivado => ´so pode ser acessado dentro da própria classe.
    //classe estática => não precisa ser instanciada, só pode ser acessada diretamente pelo nome da classe.
}

public static class Calculos
{
    public static int SomarNumeros(int a, int b)
    {
        return a + b;
    }

    public static void Executar()
    {
        var resultado = Calculos.SomarNumeros(2, 3);
        Console.WriteLine(resultado);
    }
}