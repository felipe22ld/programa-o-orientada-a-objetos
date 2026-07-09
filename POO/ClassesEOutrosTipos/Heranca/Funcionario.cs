namespace POO.ClassesEOutrosTipos.Heranca;

public class Funcionario : PessoaFisica
{
    public string Matricula { get; set; }

    public void ImprimirMatricula()
    {
        Console.WriteLine($"Matricula:{Matricula}");
    }
}