namespace POO.ClassesEOutrosTipos.Heranca;

public class Funcionario : PessoaFisica
{
    public string Matricula { get; set; }

    public void ImprimirMatricula()
    {
        Console.WriteLine($"Matricula:{Matricula}");
    }

    public static void ExemploHeranca02()
    {
        var funcionario = new Funcionario();
        funcionario.Endereco = "Rua do Brasil, n 13";
        funcionario.Cidade = "SP";
        funcionario.Cep = "02342424";
        funcionario.CPF = "00000000000";
        funcionario.Matricula = "FUNC-111111";

        funcionario.ImprimirDados();
        funcionario.ImprimirCpf();
        funcionario.ImprimirMatricula();
    }
}