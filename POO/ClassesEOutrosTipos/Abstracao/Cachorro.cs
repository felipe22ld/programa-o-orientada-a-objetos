namespace POO.ClassesEOutrosTipos.Abstracao;

public class Cachorro : Animal
{
    public override string GetInformacoes()
    {
        return "Cachorro é um bom amigo.";
    }

    public static void ExemploAbstracao()
    {
        // var animal = new Animal();
        var cachorro = new Cachorro();
        cachorro.Nome =  "Fred";
        cachorro.ImprimirDados();
    }
}