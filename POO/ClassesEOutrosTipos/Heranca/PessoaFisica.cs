namespace POO.ClassesEOutrosTipos.Heranca;

public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }

    public void ImprimirCpf()
    {
        Console.WriteLine($"Cpf:{CPF}");
    }

    public static void ExemploHeranca01()
    {
        var pessoaFisica = new PessoaFisica();
        pessoaFisica.Id = 1;
        pessoaFisica.Endereco = "Rua do Brasil, n 10";
        pessoaFisica.Cidade = "Rio de Janeiro";
        pessoaFisica.Cep = "010101010";
        pessoaFisica.CPF = "FSICA-01234567890";

        pessoaFisica.ImprimirDados();
        pessoaFisica.ImprimirCpf();
    }
}