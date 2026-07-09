namespace POO.ClassesEOutrosTipos.Encapsulamento;

public class Produto
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
}