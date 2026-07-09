namespace POO.ClassesEOutrosTipos.Heranca;

public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }

    public void ImprimirCpf()
    {
        Console.WriteLine($"Cpf:{CPF}");
    }
}