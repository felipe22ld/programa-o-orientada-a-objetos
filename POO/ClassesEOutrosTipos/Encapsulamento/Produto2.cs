namespace POO.ClassesEOutrosTipos.Encapsulamento;

public class Produto2
{
    public int Id { get; private set; }
    public string Descricao { get; set; }
    private decimal Preco { get; set; }

    public void SetPreco(decimal novoPreco)
    {
        if (novoPreco < 0)
        {
            Console.WriteLine(("Preço inválido"));
            return;
        }

        Preco = novoPreco;
    }

    public void SetId(int novoId)
    {
        if (novoId < 0)
        {
            Console.WriteLine(("Id inválido"));
            return;
        }

        Id = novoId;
    }

    public decimal GetPreco()
    {
        return Preco;
    }

    public static void ExemploEncapsulamento()
    {
        var produto = new Produto2();
        produto.Descricao = "Mouse";
        // produto.Preco = -500;
        produto.SetPreco(150);
        Console.WriteLine(produto.GetPreco());
        produto.SetId(10);
        Console.WriteLine(produto.Id);
    }
}